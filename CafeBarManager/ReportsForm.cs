using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CafeBarManager
{
    public partial class ReportsForm : Form
    {

        private List<Order> _orders;
        private string _currentFilter = "Weekly";

        public ReportsForm(List<Order> orders)
        {
            InitializeComponent();
            this._orders = orders;

            this.Size = new Size(1200, 750);
            this.StartPosition = FormStartPosition.CenterScreen;
            

            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void label7_Click(object sender, EventArgs e){}
        

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            btnDaily.Click += (s, ev) => ChangeFilter("Daily", btnDaily);
            btnWeekly.Click += (s, ev) => ChangeFilter("Weekly", btnWeekly);
            btnMonthly.Click += (s, ev) => ChangeFilter("Monthly", btnMonthly);

            
            RefreshData();
        }

        private void chartRevenue_Load(object sender, EventArgs e){}

        private void ChangeFilter(string filterType, Button clickedButton)
        {
            _currentFilter = filterType;

            
            btnDaily.BackColor = Color.Transparent;
            btnDaily.ForeColor = Color.DarkGray;
            btnWeekly.BackColor = Color.Transparent;
            btnWeekly.ForeColor = Color.DarkGray;
            btnMonthly.BackColor = Color.Transparent;
            btnMonthly.ForeColor = Color.DarkGray;

            
            clickedButton.BackColor = Color.FromArgb(52, 152, 219);
            clickedButton.ForeColor = Color.White;

            RefreshData();
        }


        private void RefreshData()
        {
            if (_orders == null || !_orders.Any()) return;

            DateTime now = DateTime.Now;
            List<Order> filteredOrders = new List<Order>();
            Dictionary<string, decimal> chartData = new Dictionary<string, decimal>();

            // 1. ФИЛТРИРАЊЕ И ПОДГОТОВКА НА ПОДАТОЦИ ЗА ГРАФИКОНОТ
            if (_currentFilter == "Daily")
            {
                lblPeriodTitle.Text = "ВКУПЕН ПРИХОД (ДЕНЕС)";
                // Земи ги само нарачките од денес
                filteredOrders = _orders.Where(o => o.CreationTime.Date == now.Date).ToList();

                // Групирај по часови (на пример: 08:00, 09:00...)
                for (int i = 8; i <= 23; i++)
                {
                    string hourStr = $"{i:00}:00";
                    decimal hourlyTotal = filteredOrders.Where(o => o.CreationTime.Hour == i).Sum(o => o.TotalWithDDV);
                    chartData.Add(hourStr, hourlyTotal);
                }
            }
            else if (_currentFilter == "Weekly")
            {
                lblPeriodTitle.Text = "ВКУПЕН ПРИХОД (ОВАА НЕДЕЛА)";
                // Земи нарачки од последните 7 дена
                DateTime startOfWeek = now.AddDays(-6).Date;
                filteredOrders = _orders.Where(o => o.CreationTime.Date >= startOfWeek).ToList();

                // Наполни ги деновите од понеделник до недела 
                for (int i = 6; i >= 0; i--)
                {
                    DateTime day = now.AddDays(-i);
                    string dayName = day.ToString("ddd"); 
                    decimal dayTotal = filteredOrders.Where(o => o.CreationTime.Date == day.Date).Sum(o => o.TotalWithDDV);
                    chartData.Add(dayName, dayTotal);
                }
            }
            else if (_currentFilter == "Monthly")
            {
                lblPeriodTitle.Text = "ВКУПЕН ПРИХОД (ОВОЈ МЕСЕЦ)";
                // Нарачки од овој месец
                filteredOrders = _orders.Where(o => o.CreationTime.Month == now.Month && o.CreationTime.Year == now.Year).ToList();

                // Групирај по недели во месецот 
                for (int i = 1; i <= 4; i++)
                {
                    string weekStr = $"Нед {i}";
                    
                    decimal weekTotal = filteredOrders.Where(o => ((o.CreationTime.Day - 1) / 7) + 1 == i).Sum(o => o.TotalWithDDV);
                    chartData.Add(weekStr, weekTotal);
                }
            }

            
            decimal totalRevenue = filteredOrders.Sum(o => o.TotalWithDDV);
            int totalOrdersCount = filteredOrders.Count;
            decimal averageOrder = totalOrdersCount > 0 ? totalRevenue / totalOrdersCount : 0;
            decimal totalDDV = filteredOrders.Sum(o => o.TotalDDV); 

            lblTotalRevenue.Text = $"{totalRevenue:N0}";
            lblTotalOrders.Text = totalOrdersCount.ToString();
            lblAverageOrder.Text = $"{averageOrder:F0}";
            lblTotalDDV.Text = $"{totalDDV:N0}";

            // 3. ЦРТАЊЕ НА СТОЛБОВИТЕ ВО ГРАФИКОНОТ
            chartRevenue.Series.Clear();
            Series series = new Series("Revenue")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                Color = Color.FromArgb(52, 152, 219) 
            };

            
            ChartArea chartArea = chartRevenue.ChartAreas[0];
            chartArea.BackColor = Color.Transparent;
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(40, 48, 68);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(40, 48, 68);
            chartArea.AxisX.LabelStyle.ForeColor = Color.Gray;
            chartArea.AxisY.LabelStyle.ForeColor = Color.Gray;

            foreach (var point in chartData)
            {
                series.Points.AddXY(point.Key, point.Value);
            }

            chartRevenue.Series.Add(series);


            RenderTopProducts(filteredOrders);

            RenderTopWaiters(filteredOrders);

            RenderEfficiency(filteredOrders);

        }



        private void RenderTopProducts(List<Order> filteredOrders)
        {
            
            flpTopProducts.Controls.Clear();
            flpTopProducts.SuspendLayout();
            flpTopProducts.AutoScroll = true; 
            flpTopProducts.FlowDirection = FlowDirection.TopDown; 
            flpTopProducts.WrapContents = false; 

            if (filteredOrders == null || !filteredOrders.Any())
            {
                flpTopProducts.ResumeLayout();
                return;
            }

            // Извлекување на ТОП 5 најпродавани артикли
            var topProducts = filteredOrders
                .SelectMany(o => o.Items)
                .GroupBy(item => item.SelectedProduct.Name)
                .Select(g => new
                {
                    ProductName = g.Key,
                    TotalQuantity = g.Sum(item => item.Quantity)
                })
                .OrderByDescending(p => p.TotalQuantity)
                .Take(5)
                .ToList();

            if (!topProducts.Any())
            {
                flpTopProducts.ResumeLayout();
                return;
            }

            int maxSales = topProducts.Max(p => p.TotalQuantity);

            
            int rowWidth = flpTopProducts.Width - 25;

            int rank = 1;
            foreach (var prod in topProducts)
            {
               
                Panel row = new Panel
                {
                    Size = new Size(rowWidth, 45),
                    Margin = new Padding(0, 0, 0, 6),
                    BackColor = Color.Transparent 
                };

                // #1, #2, #3... 
                Label lblRank = new Label
                {
                    Text = $"#{rank}",
                    ForeColor = Color.Orange,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 12),
                    AutoSize = true
                };

                // Име на артиклот 
                Label lblName = new Label
                {
                    Text = prod.ProductName,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Location = new Point(45, 12),
                    AutoSize = true
                };

                // КОЛИЧИНА
                Label lblCount = new Label
                {
                    Text = $"{prod.TotalQuantity}x",
                    ForeColor = Color.FromArgb(52, 152, 219), 
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(rowWidth - 50, 12),
                    AutoSize = true
                };

                // ПРОГРЕС ЛИНЕАРНА ПАТЕКА (
                int barStartX = 180;
                int barWidth = rowWidth - barStartX - 70; 

                Panel barBg = new Panel
                {
                    Size = new Size(barWidth, 6),
                    Location = new Point(barStartX, 18),
                    BackColor = Color.FromArgb(40, 48, 68) 
                };

                Panel barFg = new Panel
                {
                    Height = 6,
                    Location = new Point(0, 0),
                    BackColor = Color.FromArgb(52, 152, 219) 
                };

                // Пресметка за точниот процент на пополнетост
                double pct = maxSales > 0 ? (double)prod.TotalQuantity / maxSales : 0;
                barFg.Width = (int)(barBg.Width * pct);
                barBg.Controls.Add(barFg);

                // Ги редиме сите контроли во редот
                row.Controls.Add(lblRank);
                row.Controls.Add(lblName);
                row.Controls.Add(barBg);
                row.Controls.Add(lblCount);

                flpTopProducts.Controls.Add(row);
                rank++;
            }

            flpTopProducts.ResumeLayout();
        }



        private void RenderTopWaiters(List<Order> filteredOrders)
        {
            // Ги чистиме претходните контроли во десниот FlowLayoutPanel
            flpTopWaiters.Controls.Clear();
            flpTopWaiters.SuspendLayout();
            flpTopWaiters.AutoScroll = true;
            flpTopWaiters.FlowDirection = FlowDirection.TopDown;
            flpTopWaiters.WrapContents = false;

            if (filteredOrders == null || !filteredOrders.Any())
            {
                flpTopWaiters.ResumeLayout();
                return;
            }

            // 1. Групирање на нарачките по келнер и пресметка на вкупен промет и број на маси
            var topWaiters = filteredOrders
                .GroupBy(o => o.WaiterName) // Претпоставуваме дека својството во твојата Order класа се вика WaiterName или Waiter
                .Select(g => new
                {
                    WaiterName = g.Key,
                    TotalOrdersCount = g.Count(),
                    TotalEarnings = g.Sum(o => o.TotalWithDDV)
                })
                .OrderByDescending(w => w.TotalOrdersCount) // Ги рангираме според бројот на услужени маси
                .Take(4) // Најдобрите 4 како на дизајнот
                .ToList();

            int rowWidth = flpTopWaiters.Width - 25;
            int rank = 1;

            // Листа на убави бои за круговите на келнерите (Сина, Зелена, Виолетова, Портокалова...)
            Color[] avatarColors = {
                Color.FromArgb(52, 152, 219),
                Color.FromArgb(46, 204, 113),
                Color.FromArgb(155, 89, 182),
                Color.FromArgb(230, 126, 34)
            };

            foreach (var waiter in topWaiters)
            {
                // Главен контејнер за еден келнер
                Panel row = new Panel
                {
                    Size = new Size(rowWidth, 60),
                    Margin = new Padding(0, 0, 0, 10),
                    BackColor = Color.Transparent
                };

                // 1. Ранг бројче (#1, #2...)
                Label lblRank = new Label
                {
                    Text = rank.ToString(),
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(5, 20),
                    Size = new Size(20, 20),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                // 2. Иницијали за аватарот (на пр. "Петар Петков" -> "ПП")
                string initials = "";
                string[] names = waiter.WaiterName.Split(' ');
                if (names.Length > 0 && !string.IsNullOrEmpty(names[0])) initials += names[0][0];
                if (names.Length > 1 && !string.IsNullOrEmpty(names[1])) initials += names[1][0];
                initials = initials.ToUpper();

                // 3. Кружен Аватар (PictureBox со нацртан круг во Paint настанот)
                PictureBox pbAvatar = new PictureBox
                {
                    Size = new Size(36, 36),
                    Location = new Point(35, 12),
                    BackColor = Color.Transparent
                };
                Color circleColor = avatarColors[(rank - 1) % avatarColors.Length];

                pbAvatar.Paint += (s, pe) =>
                {
                    pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    using (Brush b = new SolidBrush(circleColor))
                    {
                        pe.Graphics.FillEllipse(b, 0, 0, pbAvatar.Width - 1, pbAvatar.Height - 1);
                    }
                    using (Font f = new Font("Segoe UI", 10, FontStyle.Bold))
                    {
                        SizeF textSize = pe.Graphics.MeasureString(initials, f);
                        pe.Graphics.DrawString(initials, f, Brushes.White,
                            (pbAvatar.Width - textSize.Width) / 2,
                            (pbAvatar.Height - textSize.Height) / 2);
                    }
                };

                // 4. Име на келнерот
                Label lblName = new Label
                {
                    Text = waiter.WaiterName,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(85, 12),
                    AutoSize = true
                };

                // 5. Статистика под името (Услужени маси)
                Label lblSub = new Label
                {
                    Text = $"{waiter.TotalOrdersCount} услужени маси",
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    Location = new Point(85, 32),
                    AutoSize = true
                };

                // 6. Вкупен промет што го направил (Скроз десно со зелена боја)
                Label lblEarnings = new Label
                {
                    Text = $"{waiter.TotalEarnings:N0} ден",
                    ForeColor = Color.FromArgb(46, 204, 113),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(rowWidth - 100, 20),
                    Size = new Size(95, 20),
                    TextAlign = ContentAlignment.MiddleRight
                };

                // Ги додаваме сите ситни контроли во редот
                row.Controls.Add(lblRank);
                row.Controls.Add(pbAvatar);
                row.Controls.Add(lblName);
                row.Controls.Add(lblSub);
                row.Controls.Add(lblEarnings);

                // Го додаваме редот во десниот FlowLayoutPanel
                flpTopWaiters.Controls.Add(row);
                rank++;
            }

            flpTopWaiters.ResumeLayout();
        }



        private void RenderEfficiency(List<Order> filteredOrders)
        {
            pnlEfficiency.Controls.Clear();

            if (filteredOrders == null || !filteredOrders.Any()) return;

            // 1. Сигурна пресметка на времетраење во минути
            var orderDurations = filteredOrders
                .Where(o => o.PaymentTime != null)
                .Select(o => {
                    DateTime creation = (DateTime)o.CreationTime;
                    DateTime payment = (DateTime)o.PaymentTime;
                    return (payment - creation).TotalMinutes;
                })
                .Where(min => min > 0)
                .ToList();

            if (!orderDurations.Any()) return;

            double avgMinutes = orderDurations.Average();

            // Форматирање во MM:SS (минути:секунди)
            int displayMin = (int)avgMinutes;
            int displaySec = (int)((avgMinutes - displayMin) * 60);
            string avgTimeStr = $"{displayMin}:{displaySec:D2}";

            // 2. Реален кафич рејтинг на брзина (како на дизајнот)
            int excellent = 0; // Одлично (≤ 2 мин)
            int good = 0;      // Добро (2–5 мин)
            int moderate = 0;  // Умерено (5–10 мин)
            int slow = 0;      // Бавно (> 10 мин)

            foreach (var duration in orderDurations)
            {
                if (duration <= 2.0) excellent++;
                else if (duration <= 5.0) good++;
                else if (duration <= 10.0) moderate++;
                else slow++;
            }

            int total = orderDurations.Count;
            double pctExcellent = (double)excellent / total * 100;
            double pctGood = (double)good / total * 100;
            double pctModerate = (double)moderate / total * 100;
            double pctSlow = (double)slow / total * 100;

            // 3. Исцртување на големиот тајмер во центарот
            Label lblBigTime = new Label
            {
                Text = avgTimeStr,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                Location = new Point(45, 45),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            Label lblMinUnit = new Label
            {
                Text = "мин.",
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(68, 82),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            Label lblTitleText = new Label
            {
                Text = "ПРОСЕЧНО ВРЕМЕ НА ЧЕКАЊЕ",
                ForeColor = Color.FromArgb(120, 130, 150),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(190, 45),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            Label lblTrend = new Label
            {
                Text = "↓ 22 сек. подобрување денес",
                ForeColor = Color.FromArgb(46, 204, 113),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(190, 68),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            pnlEfficiency.Controls.AddRange(new Control[] { lblBigTime, lblMinUnit, lblTitleText, lblTrend });

            // 4. Легенда со оригиналните вредности од сликата
            string[] labels = { "Одлично (≤2 мин)", "Добро (2–5 мин)", "Умерено (5–10 мин)", "Бавно (>10 мин)" };
            double[] percentages = { pctExcellent, pctGood, pctModerate, pctSlow };
            Color[] colors = {
            Color.FromArgb(46, 204, 113), // Зелена
            Color.FromArgb(52, 152, 219), // Сина
            Color.FromArgb(241, 196, 15), // Жолта
            Color.FromArgb(231, 76, 60)   // Црвена
            };

            int startY = 160;
            for (int i = 0; i < 4; i++)
            {
                Panel colorDot = new Panel
                {
                    Size = new Size(10, 10),
                    Location = new Point(35, startY + 5),
                    BackColor = colors[i]
                };
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(0, 0, 10, 10);
                colorDot.Region = new Region(path);

                Label lblCat = new Label
                {
                    Text = labels[i],
                    ForeColor = Color.FromArgb(200, 200, 200),
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    Location = new Point(55, startY),
                    AutoSize = true,
                    BackColor = Color.Transparent
                };

                Label lblPct = new Label
                {
                    Text = $"{percentages[i]:F0}%",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(pnlEfficiency.Width - 70, startY),
                    Size = new Size(50, 20),
                    TextAlign = ContentAlignment.MiddleRight,
                    BackColor = Color.Transparent
                };

                pnlEfficiency.Controls.AddRange(new Control[] { colorDot, lblCat, lblPct });
                startY += 28;
            }

            // 5. Цртање на прстенот
            pnlEfficiency.Paint += (s, pe) =>
            {
                pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (Pen bgPen = new Pen(Color.FromArgb(35, 43, 58), 12))
                {
                    pe.Graphics.DrawEllipse(bgPen, 30, 25, 110, 110);
                }

                // Динамичка боја во зависност од тоа дали локалот е брз или бавен во просек
                Color ringColor = colors[0]; // Зелена ако е одлично
                if (avgMinutes > 2 && avgMinutes <= 5) ringColor = colors[1]; // Сина ако е добро
                else if (avgMinutes > 5 && avgMinutes <= 10) ringColor = colors[2]; // Жолта ако е умерено
                else if (avgMinutes > 10) ringColor = colors[3]; // Црвена ако ептен каснат

                using (Pen activePen = new Pen(ringColor, 12))
                {
                    activePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    activePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                    // Колку е побрз просекот, толку повеќе се полни кругот
                    float sweepAngle = (float)((total - slow) / (double)total * 360.0);
                    if (sweepAngle > 360) sweepAngle = 360;
                    if (sweepAngle < 20) sweepAngle = 20;

                    pe.Graphics.DrawArc(activePen, 30, 25, 110, 110, -90, sweepAngle);
                }
            };

            pnlEfficiency.Invalidate();
        }

        private void ExportTXT_Click(object sender, EventArgs e)
        {
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                InitialDirectory = Directory.Exists(downloadsPath) ? downloadsPath : Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = $"Izvestaj_Statistika_{DateTime.Now:yyyy_MM_dd}.txt",
                Title = "Зачувај го извештајот во Downloads"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine("==================================================");
                    sb.AppendLine("          CAFE-BAR FINKI - СТАТИСТИЧКИ ИЗВЕШТАЈ   ");
                    sb.AppendLine("==================================================");
                    sb.AppendLine($"Датум на генерирање: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
                    sb.AppendLine("--------------------------------------------------\n");

                    sb.AppendLine("[ ГЕНЕРАЛЕН ПРОФИТ И ПРОМЕТ ]");
                    sb.AppendLine($"Вкупен приход:      {lblTotalRevenue.Text} ден.");
                    sb.AppendLine($"Вкупно нарачки:     {lblTotalOrders.Text}");
                    sb.AppendLine($"Просек по нарачка:  {lblAverageOrder.Text} ден.");
                    sb.AppendLine("--------------------------------------------------\n");

                    sb.AppendLine("[ НАЈПРОДАВАНИ АРТИКЛИ ]");
                    int artRank = 1;
                    foreach (Control row in flpTopProducts.Controls)
                    {
                        if (row is Panel)
                        {
                            string rankStr = $"#{artRank}";
                            string prodName = "";
                            string prodQty = "";

                            foreach (Control c in row.Controls)
                            {
                                if (c is Label)
                                {
                                    if (c.Text.StartsWith("#")) continue;
                                    if (c.Text.EndsWith("x") || c.Text.Contains("пар.")) prodQty = c.Text;
                                    else prodName = c.Text;
                                }
                            }

                            if (!string.IsNullOrEmpty(prodName))
                            {
                                sb.AppendLine($"{rankStr}. {prodName.PadRight(25)} Продадено: {prodQty}");
                            }
                            artRank++;
                        }
                    }
                    sb.AppendLine("--------------------------------------------------\n");

                    sb.AppendLine("[ УЧИНОК НА КЕЛНЕРИ ]");
                    int waiterRank = 1;
                    foreach (Control row in flpTopWaiters.Controls)
                    {
                        if (row is Panel)
                        {
                            string waiterName = "";
                            string waiterSales = "";

                            foreach (Control c in row.Controls)
                            {
                                if (c is Label)
                                {
                                    if (c.Text.Contains("ден")) waiterSales = c.Text;
                                    else if (!int.TryParse(c.Text, out _) && !c.Text.Contains("услужени")) waiterName = c.Text;
                                }
                            }

                            if (!string.IsNullOrEmpty(waiterName))
                            {
                                sb.AppendLine($"#{waiterRank} {waiterName.PadRight(25)} Направен промет: {waiterSales}");
                            }
                            waiterRank++;
                        }
                    }
                    sb.AppendLine("==================================================");
                    sb.AppendLine("        Крај на извештајот. Лиценцирано за FINKI. ");
                    sb.AppendLine("==================================================");

                    // Сега работи без грешка бидејќи горе имаме using System.Text;
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                    MessageBox.Show("Извештајот е успешно зачуван како текстуален фајл во Downloads!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Грешка при зачувување на фајлот: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    
    }
}
