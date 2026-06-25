using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace CafeBarManager
{
    public partial class Form1 : Form
    {

        private BarLayout barLayout = new BarLayout();
        private Table selectedTable = null;
        private List<Product> menuProducts;
        private System.Windows.Forms.Timer clockTimer;
        private List<Order> dailyPaidOrders;
        private FlowLayoutPanel pnlMenuCards = null;

        private System.Windows.Forms.Timer liveClockTimer;
        private bool blinkToggle = false;

        private TextBox txtSearchMenu;

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Load += new EventHandler(Form1_Load);
            DoubleBuffered = true;

            InitializeClockTimer();

            if (!LoadMenuFromJSON())
            {
                menuProducts = Product.CreateMenu();
                SaveMenuToJSON(); 
            }

            if (!LoadOrdersFromJSON())
            {
                dailyPaidOrders = new List<Order>(); 
            }

            GenerateMockOrders();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, pnlTablesFloor, new object[] { true });

            SetCardShapes();
            UpdateFloorStatistics();

            pnlTablesFloor.Paint += new PaintEventHandler(pnlTablesFloor_Paint_1);

            pnlTablesFloor.MouseClick -= new MouseEventHandler(pnlTablesFloor_MouseClick);
            pnlTablesFloor.MouseClick += new MouseEventHandler(pnlTablesFloor_MouseClick);


            lblLiveTime.Text = DateTime.Now.ToString("HH:mm:ss");

            
            liveClockTimer = new System.Windows.Forms.Timer();
            liveClockTimer.Interval = 1000; // 1 секунда
            liveClockTimer.Tick += LiveClockTimer_Tick;
            liveClockTimer.Start();


            cmbWaiter.BackColor = Color.FromArgb(28, 35, 48);
            cmbWaiter.ForeColor = Color.White;
            cmbWaiter.DrawItem += new DrawItemEventHandler(cmbWaiter_DrawItem);



            int buttonWidth = pnlLeftMenu.Width - 30;
            int buttonHeight = 45;
            int startY = 180;
            int spacing = 55;

            Font menuFont = new Font("Segoe UI", 10, FontStyle.Bold);
            Color normalBg = Color.FromArgb(28, 35, 48);
            Color hoverBg = Color.Transparent;
            Color activeBg = Color.FromArgb(52, 152, 219);

            
            Button btnTableLayout = pnlLeftMenu.Controls["btnTableLayout"] as Button;
            if (btnTableLayout == null)
            {
                btnTableLayout = new Button { Name = "btnTableLayout" };
                pnlLeftMenu.Controls.Add(btnTableLayout);
            }
            btnTableLayout.Text = " Распоред на Маси ";
            btnTableLayout.Size = new Size(buttonWidth, buttonHeight);
            btnTableLayout.Location = new Point(15, startY);
            StyleMenuButton(btnTableLayout, menuFont, activeBg, hoverBg); 

            
            btnOpenInventory.Text = "Залиха и Набавки";
            btnOpenInventory.Size = new Size(buttonWidth, buttonHeight);
            btnOpenInventory.Location = new Point(15, startY + spacing);
            StyleMenuButton(btnOpenInventory, menuFont, normalBg, hoverBg);

          
            btnStatistics.Text = " Статистика и Извештаи ";
            btnStatistics.Size = new Size(buttonWidth, buttonHeight);
            btnStatistics.Location = new Point(15, startY + (spacing * 2));
            StyleMenuButton(btnStatistics, menuFont, normalBg, hoverBg);

            
            Button btnDigitalMenu = pnlLeftMenu.Controls["btnDigitalMenu"] as Button;
            if (btnDigitalMenu == null)
            {
                btnDigitalMenu = new Button { Name = "btnDigitalMenu" };
                pnlLeftMenu.Controls.Add(btnDigitalMenu);
            }
            btnDigitalMenu.Text = "   📋   Дигитално Мени";
            btnDigitalMenu.Size = new Size(buttonWidth, buttonHeight);
            btnDigitalMenu.Location = new Point(15, startY + (spacing * 3));
            StyleMenuButton(btnDigitalMenu, menuFont, normalBg, hoverBg);


            btnTableLayout.Click += (s, ev) =>
            {
                SetActiveMenuVisual(btnTableLayout, pnlLeftMenu, activeBg, normalBg);
                ToggleMainPanels(true);
            };

            btnDigitalMenu.Click += (s, ev) =>
            {
                SetActiveMenuVisual(btnDigitalMenu, pnlLeftMenu, activeBg, normalBg);
                ToggleMainPanels(false);
                ShowDigitalMenuPanel();
            };


            this.FormClosing += (s, ev) =>
            {
                SaveMenuToJSON();
            };

            this.FormClosing += (s, ev) =>
            {
                SaveMenuToJSON();
                SaveOrdersToJSON(); 
            };

        }


        private void SaveMenuToJSON()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(menuProducts, options);
                File.WriteAllText("menu.json", jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зачувување на менито: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool LoadMenuFromJSON()
        {
            try
            {
                if (File.Exists("menu.json"))
                {
                    string jsonString = File.ReadAllText("menu.json");
                    menuProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при вчитување на менито: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        private void SaveOrdersToJSON()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(dailyPaidOrders, options);
                File.WriteAllText("orders.json", jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зачувување на нарачките: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool LoadOrdersFromJSON()
        {
            try
            {
                if (File.Exists("orders.json"))
                {
                    string jsonString = File.ReadAllText("orders.json");
                    dailyPaidOrders = JsonSerializer.Deserialize<List<Order>>(jsonString);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при вчитување на нарачките: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void ToggleMainPanels(bool show)
        {
            pnlTablesFloor.Visible = show;
          
            if (pnlSelectedTableCard != null) pnlSelectedTableCard.Visible = show;
            if (pnlStatusCard != null) pnlStatusCard.Visible = show;
            if (pnlSimulatorCard != null) pnlSimulatorCard.Visible = show;

            // Ако го враќаме распоредот на маси, тргни го менито од екран
            if (show && pnlMenuCards != null)
            {
                pnlMenuCards.Visible = false;
            }
        }


        private void ShowDigitalMenuPanel()
        {

            if (pnlMenuCards == null)
            {
                pnlMenuCards = new FlowLayoutPanel();
                pnlMenuCards.Left = pnlLeftMenu.Right;
                pnlMenuCards.Top = pnlTablesFloor.Top;
                pnlMenuCards.Width = this.ClientSize.Width - pnlLeftMenu.Right;
                pnlMenuCards.Height = this.ClientSize.Height - pnlTablesFloor.Top;
                pnlMenuCards.BackColor = Color.FromArgb(19, 23, 31);
                pnlMenuCards.AutoScroll = true;
                pnlMenuCards.Padding = new Padding(35, 25, 35, 25);
                pnlMenuCards.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                // Спречување трепкање
                typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
                    System.Reflection.BindingFlags.SetProperty |
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic,
                    null, pnlMenuCards, new object[] { true });

                this.Controls.Add(pnlMenuCards);

                BuildDigitalMenuUI();
            }

            pnlMenuCards.BringToFront();
            pnlMenuCards.Visible = true;
            if (txtSearchMenu != null) txtSearchMenu.Focus();
        }


        private void BuildDigitalMenuUI()
        {
            pnlMenuCards.Controls.Clear();

            // Наслов + Пребарување
            FlowLayoutPanel topBar = new FlowLayoutPanel();
            topBar.Width = pnlMenuCards.Width - 80;
            topBar.Height = 50;
            topBar.BackColor = Color.Transparent;
            topBar.Margin = new Padding(10, 0, 10, 30);
            pnlMenuCards.SetFlowBreak(topBar, true);

            Label lblMenuHeader = new Label();
            lblMenuHeader.Text = "📋 МЕНИ ФИНКИ";
            lblMenuHeader.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblMenuHeader.ForeColor = Color.White;
            lblMenuHeader.AutoSize = true;
            lblMenuHeader.Margin = new Padding(0, 5, 40, 0);
            topBar.Controls.Add(lblMenuHeader);

            // Кутија за пребарување
            txtSearchMenu = new TextBox();
            txtSearchMenu.Width = 300;
            txtSearchMenu.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtSearchMenu.BackColor = Color.FromArgb(28, 35, 48);
            txtSearchMenu.ForeColor = Color.White;
            txtSearchMenu.BorderStyle = BorderStyle.FixedSingle;
            txtSearchMenu.Margin = new Padding(0, 5, 0, 0);

            // placeholder логика
            txtSearchMenu.Text = "🔍 Пребарај продукт...";
            txtSearchMenu.Enter += (s, e) => { if (txtSearchMenu.Text == "🔍 Пребарај продукт...") txtSearchMenu.Text = ""; };
            txtSearchMenu.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtSearchMenu.Text)) txtSearchMenu.Text = "🔍 Пребарај продукт..."; };

            
            txtSearchMenu.TextChanged += (s, e) =>
            {
                string query = txtSearchMenu.Text.ToLower();
                if (query == "🔍 пребарај продукт...") query = "";

                foreach (Control ctrl in pnlMenuCards.Controls)
                {
                    if (ctrl is Panel card && card.Tag != null)
                    {
                        string prodName = card.Tag.ToString().ToLower();
                        card.Visible = prodName.Contains(query);
                    }
                }
            };
            topBar.Controls.Add(txtSearchMenu);
            pnlMenuCards.Controls.Add(topBar);

            
            foreach (Product prod in menuProducts)
            {
                Panel card = new Panel();
                card.Size = new Size(215, 125);
                card.BackColor = Color.FromArgb(28, 35, 48);
                card.Margin = new Padding(12);
                card.Tag = prod.Name;
                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 12, 12));

                
                Color accentColor = Color.FromArgb(52, 152, 219);
                string nameLower = prod.Name.ToLower();

                if (nameLower.Contains("кафе") || nameLower.Contains("еспресо") || nameLower.Contains("капучино")) accentColor = Color.FromArgb(184, 134, 11);
                else if (nameLower.Contains("сок") || nameLower.Contains("лимонада")) accentColor = Color.FromArgb(230, 126, 34);
                else if (nameLower.Contains("пиво") || nameLower.Contains("вино") || nameLower.Contains("виски")) accentColor = Color.FromArgb(231, 76, 60);
                else if (nameLower.Contains("вода")) accentColor = Color.FromArgb(52, 152, 219);

                
                card.Paint += (s, e) =>
                {
                    using (SolidBrush brush = new SolidBrush(accentColor))
                    {
                        e.Graphics.FillRectangle(brush, 0, 0, 5, card.Height);
                    }
                };

                Label lblName = new Label
                {
                    Text = prod.Name,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(18, 18),
                    Width = card.Width - 30,
                    AutoEllipsis = true
                };
                card.Controls.Add(lblName);

                Label lblCode = new Label
                {
                    Text = $"Шифра: {prod.ID}",
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    ForeColor = Color.FromArgb(110, 125, 140),
                    Location = new Point(18, 50),
                    AutoSize = true
                };
                card.Controls.Add(lblCode);

                Label lblPrice = new Label
                {
                    Text = $"{prod.Price:F0} ден.",
                    Font = new Font("Segoe UI", 13, FontStyle.Bold),
                    ForeColor = Color.FromArgb(46, 204, 113),
                    Location = new Point(18, 82),
                    AutoSize = true
                };
                card.Controls.Add(lblPrice);

                pnlMenuCards.Controls.Add(card);
            }
        }


        private void StyleMenuButton(Button btn, Font font, Color normalBg, Color hoverBg)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = hoverBg;
            btn.FlatAppearance.MouseOverBackColor = hoverBg;

            btn.BackColor = normalBg;
            btn.ForeColor = Color.White;
            btn.Font = font;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Cursor = Cursors.Hand;


            btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 12, 12));


            btn.MouseEnter += (s, ev) =>
            {
                if (btn.BackColor != Color.FromArgb(52, 152, 219)) btn.BackColor = hoverBg;
            };
            btn.MouseLeave += (s, ev) =>
            {
                if (btn.BackColor != Color.FromArgb(52, 152, 219)) btn.BackColor = normalBg;
            };


        }

        private void SetActiveMenuVisual(Button activeBtn, Panel leftPanel, Color activeBg, Color normalBg)
        {
            foreach (Control c in leftPanel.Controls)
            {
                if (c is Button b)
                {
                    b.BackColor = (b == activeBtn) ? activeBg : normalBg;
                }
            }
        }

        private void LiveClockTimer_Tick(object sender, EventArgs e)
        {
            lblLiveTime.Text = DateTime.Now.ToString("HH:mm:ss");

            blinkToggle = !blinkToggle;
            pnlTablesFloor.Invalidate();
        }


        private void InitializeClockTimer()
        {
            clockTimer = new System.Windows.Forms.Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += (s, e) =>
            {

                pnlTablesFloor.Invalidate();
                if (selectedTable != null && selectedTable.Status == TableStatus.OccupiedServed)
                {
                    UpdateRightPanel();
                }
            };
            clockTimer.Start();
        }


        private void SetCardShapes()
        {

            if (pnlSelectedTableCard != null)
                pnlSelectedTableCard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlSelectedTableCard.Width, pnlSelectedTableCard.Height, 16, 16));

            if (pnlStatusCard != null)
                pnlStatusCard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlStatusCard.Width, pnlStatusCard.Height, 16, 16));

            if (pnlSimulatorCard != null)
                pnlSimulatorCard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlSimulatorCard.Width, pnlSimulatorCard.Height, 16, 16));
        }

        private void pnlTablesFloor_Paint_1(object sender, PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


            bool slowBlink = (DateTime.Now.Second / 2) % 2 == 0;


            Dictionary<int, TableStatus> originalStatuses = new Dictionary<int, TableStatus>();

            foreach (Table table in barLayout.Tables)
            {
                if (table.IsRequestingBill)
                {
                    originalStatuses[table.TableNumber] = table.Status;
                    table.Status = slowBlink ? (TableStatus)99 : TableStatus.OccupiedServed;
                }
            }


            barLayout.Draw(e.Graphics);


            foreach (Table table in barLayout.Tables)
            {
                if (table.IsRequestingBill && originalStatuses.ContainsKey(table.TableNumber))
                {
                    table.Status = originalStatuses[table.TableNumber];
                }
            }


            foreach (Table table in barLayout.Tables)
            {
                TimeSpan? waitingTime = table.GetCurrentWaitTime();
                if (waitingTime.HasValue)
                {
                    string timeText = $"{waitingTime.Value.Minutes:00}:{waitingTime.Value.Seconds:00}";

                    using (Font timerFont = new Font("Segoe UI", 9, FontStyle.Bold))
                    {
                        float textX = table.X + (table.Width / 2) - 18;
                        float textY = table.Y + table.Height - 20;
                        e.Graphics.DrawString(timeText, timerFont, Brushes.Black, textX, textY);
                    }
                }
            }

        }


        

        private void pnlTablesFloor_MouseClick(object sender, MouseEventArgs e)
        {
            Table clickedTable = barLayout.GetTableAt(e.X, e.Y);

            if (clickedTable != null)
            {
                selectedTable = clickedTable;

                UpdateRightPanel();
                UpdateFloorStatistics();
                pnlTablesFloor.Invalidate();

            }
        }

        private void UpdateFloorStatistics()
        {
            int freeCount = 0;
            int waitingCount = 0;
            int servedCount = 0;
            int billCount = 0;


            foreach (Table table in barLayout.Tables)
            {
                if (table.IsRequestingBill)
                {
                    billCount++;
                }

                switch (table.Status)
                {
                    case TableStatus.Free:
                        freeCount++;
                        break;
                    case TableStatus.OccupiedUnserved:
                        waitingCount++;
                        break;
                    case TableStatus.OccupiedServed:
                        servedCount++;
                        break;
                }

            }


            DateTime today = DateTime.Today;
            decimal totalEarnings = dailyPaidOrders
                .Where(order => order.IsPaid && order.PaymentTime.HasValue && order.PaymentTime.Value.Date == today)
                .Sum(order => order.TotalWithDDV);

            lblStatFree.Text = "Слободни: " + freeCount;
            lblStatWaiting.Text = "Во чекање: " + waitingCount;
            lblStatServed.Text = "Опслужени: " + servedCount;
            lblStatBillRequested.Text = "Бараат сметка: " + billCount;
            lblStatEarnings.Text = "Приход денес: " + totalEarnings + " ден";
        }

        private void UpdateRightPanel()
        {
            if (selectedTable != null)
            {
                lblSelectedTableTitle.Text = "Маса " + selectedTable.TableNumber;

                if (selectedTable.IsRequestingBill)
                {
                    lblSelectedTableStatus.Text = "● Бара сметка";
                    lblSelectedTableStatus.ForeColor = Color.Gold;
                }
                else
                {
                    switch (selectedTable.Status)
                    {
                        case TableStatus.Free:
                            lblSelectedTableStatus.Text = "● Слободна";
                            lblSelectedTableStatus.ForeColor = Color.FromArgb(46, 204, 113);
                            break;
                        case TableStatus.OccupiedUnserved:
                            lblSelectedTableStatus.Text = "● Неопслужена";
                            lblSelectedTableStatus.ForeColor = Color.FromArgb(241, 196, 15);
                            break;
                        case TableStatus.OccupiedServed:
                            lblSelectedTableStatus.Text = "● Опслужена";
                            lblSelectedTableStatus.ForeColor = Color.FromArgb(231, 76, 60);
                            break;
                    }
                }

                TimeSpan? waitingTime = selectedTable.GetWaitTime();

                if (waitingTime.HasValue && selectedTable.Status == TableStatus.OccupiedServed)
                {
                    var efficiency = GetEfficiencyStatus(waitingTime.Value);

                    lblServiceTime.Text = $"Време: {waitingTime.Value.Minutes:00}:{waitingTime.Value.Seconds:00} мин.";
                    lblServiceTime.ForeColor = efficiency.color;
                    lblServiceTime.Visible = true;
                }
                else
                {
                    lblServiceTime.Visible = false;
                }

                lblTotalAmount.ForeColor = Color.DarkGreen;
                lblTotalAmount.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                lstOrders.Items.Clear();

                if (selectedTable.CurrentOrder != null && selectedTable.CurrentOrder.Items.Count > 0)
                {
                    foreach (OrderItem item in selectedTable.CurrentOrder.Items)
                    {
                        lstOrders.Items.Add(item.ToString());
                    }

                    lblTotalAmount.Text = $"{selectedTable.CurrentOrder.TotalWithDDV:F2} ден.";
                }
                else
                {
                    lstOrders.Items.Add("Нема активни нарачки.");
                    lblTotalAmount.Text = "0.00 ден.";
                }

            }

        }



        private void cmbWaiter_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox combo = sender as ComboBox;
            string text = combo.Items[e.Index].ToString();

           
            Color backgroundColor = Color.FromArgb(28, 35, 48); 
            Color textColor = Color.White;                      

            
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backgroundColor = Color.FromArgb(52, 152, 219); 
            }

            
            using (SolidBrush bgBrush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
            }

           
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (Font customFont = new Font("Segoe UI", 10, FontStyle.Regular))
            {
                
                Rectangle textRect = new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 5, e.Bounds.Height);

                StringFormat sf = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near
                };

                e.Graphics.DrawString(text, customFont, textBrush, textRect, sf);
            }

            
            e.DrawFocusRectangle();
        }


        private void lstOrders_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 30;
        }

        private void lstOrders_DrawItem(object sender, DrawItemEventArgs e)
        {

            if (e.Index < 0) return;

            string text = lstOrders.Items[e.Index].ToString();
            e.DrawBackground();

            Font customFont = new Font("Segoe UI", 11, FontStyle.Regular);

            
            Brush textBrush = Brushes.White;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                textBrush = Brushes.White;
            }
            else if (text == "Нема активни нарачки.")
            {
                textBrush = Brushes.Gray; 
            }

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Near;

            Rectangle textRect = new Rectangle(e.Bounds.X + 10, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height);
            e.Graphics.DrawString(text, customFont, textBrush, textRect, sf);

            e.DrawFocusRectangle();
        }

        private void btnOpenOrderDialog_Click(object sender, EventArgs e)
        {


            if (selectedTable == null) return;

            string waiter = cmbWaiter.SelectedItem?.ToString() ?? "Админ";
            OrderForm orderForm = new OrderForm(selectedTable, waiter, this.menuProducts);

            orderForm.TableChanged += (s, table) =>
            {
                pnlTablesFloor.Invalidate();
                UpdateFloorStatistics();
            };

            
            Order orderBeforePayment = selectedTable.CurrentOrder;

            if (orderForm.ShowDialog() == DialogResult.OK)
            {
                
                if (selectedTable.Status == TableStatus.Free && orderBeforePayment != null)
                {
                    dailyPaidOrders.Add(orderBeforePayment);
                }

                UpdateRightPanel();
                UpdateFloorStatistics();
                pnlTablesFloor.Invalidate();
            }

        }


        private void OnTableChangedFromOrderForm(object sender, Table changedTable)
        {
            UpdateRightPanel();
            UpdateFloorStatistics();
            pnlTablesFloor.Invalidate();
        }

        private void pnlLeftMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            if (selectedTable == null) return;


            if (selectedTable.CurrentOrder == null)
            {
                MessageBox.Show("Оваа маса нема активна нарачка за наплата!",
                                "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (selectedTable.Status == TableStatus.OccupiedUnserved)
            {
                MessageBox.Show("Не можете директно да наплатите нарачка што сè уште не е испорачана на масата! Прво одете на 'Додади артикл' и кликнете 'Испорачано'.",
                                "Предупредување", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (ReceiptForm receiptForm = new ReceiptForm(selectedTable))
            {
                DialogResult result = receiptForm.ShowDialog();


                if (result == DialogResult.OK)
                {

                    if (selectedTable.CurrentOrder != null)
                    {
                        dailyPaidOrders.Add(selectedTable.CurrentOrder);
                    }

                    selectedTable.Status = TableStatus.Free;
                    selectedTable.IsRequestingBill = false;
                    selectedTable.CurrentOrder = null;

                    UpdateRightPanel();
                    UpdateFloorStatistics();
                    pnlTablesFloor.Invalidate();
                }

            }
        }

        private void btnOpenInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(this.menuProducts);

            inventoryForm.ShowDialog();

            UpdateRightPanel();

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (dailyPaidOrders == null)
            {
                dailyPaidOrders = new List<Order>();
            }


            ReportsForm reportsForm = new ReportsForm(dailyPaidOrders);


            reportsForm.ShowDialog();
        }



        private void GenerateMockOrders()
        {
            dailyPaidOrders = new List<Order>();
            Random rand = new Random();
            string[] waiters = { "Петар Петков", "Ана Стојанова", "Марко Ангелов", "Ивана Јованова" };

            // === 1. ГЕНЕРИРАЊЕ ИСТОРИСКИ ПОДАТОЦИ (ЗА СТАТИСТИКАТА) ===
            for (int dayOffset = 0; dayOffset < 30; dayOffset++)
            {
                int ordersCount = rand.Next(5, 16);
                DateTime targetDate = DateTime.Now.AddDays(-dayOffset);

                for (int i = 0; i < ordersCount; i++)
                {
                    int tableNum = rand.Next(1, 18); 
                    string waiter = waiters[rand.Next(waiters.Length)];

                    Order mockOrder = new Order(tableNum, waiter);
                    mockOrder.CreationTime = new DateTime(
                        targetDate.Year, targetDate.Month, targetDate.Day,
                        rand.Next(8, 24), rand.Next(0, 60), rand.Next(0, 60)
                    );
                    mockOrder.IsPaid = true;
                    mockOrder.PaymentTime = mockOrder.CreationTime.AddMinutes(rand.Next(2, 20));

                    int productsInOrder = rand.Next(2, 6);
                    for (int p = 0; p < productsInOrder; p++)
                    {
                        Product randomProduct = menuProducts[rand.Next(menuProducts.Count)];
                        int quantity = rand.Next(1, 4);

                        OrderItem item = new OrderItem(randomProduct, quantity);
                        mockOrder.Items.Add(item);
                    }

                    dailyPaidOrders.Add(mockOrder);
                }
            }

            // === 2. ПОСТАВУВАЊЕ АКТИВНИ НАРАЧКИ НА МАСИТЕ ===
            if (barLayout != null && barLayout.Tables != null && barLayout.Tables.Count > 0)
            {
                Table table2 = barLayout.Tables.FirstOrDefault(t => t.TableNumber == 2);
                Table table4 = barLayout.Tables.FirstOrDefault(t => t.TableNumber == 4);
                Table table11 = barLayout.Tables.FirstOrDefault(t => t.TableNumber == 11);

                // --- МАСА 4: Окупација, неопслужена (ЖОЛТА) ---
                if (table4 != null)
                {
                    // 1. Повикуваме официјално седнење (ова креира и CurrentOrder)
                    table4.GuestsSeated("Марко Ангелов");

                    // 2. Симулираме дека седнале пред 4 минути за тајмерот да си брои реално
                    table4.SeatingTime = DateTime.Now.AddMinutes(-4);
                    table4.CurrentOrder.CreationTime = table4.SeatingTime.Value;

                    // 3. Ги полниме артиклите во нарачката
                    if (menuProducts.Count > 1)
                    {
                        table4.CurrentOrder.Items.Add(new OrderItem(menuProducts[0], 2));
                        table4.CurrentOrder.Items.Add(new OrderItem(menuProducts[1], 1));
                    }
                }

                // --- МАСА 2: Опслужена (ЦРВЕНА) ---
                if (table2 != null)
                {
                    // 1. Ги седнуваме гостите
                    table2.GuestsSeated("Петар Петков");

                    // 2. Симулираме дека седнале пред 12 минути
                    table2.SeatingTime = DateTime.Now.AddMinutes(-12);
                    table2.CurrentOrder.CreationTime = table2.SeatingTime.Value;

                    // 3. Ги додаваме продуктите во нарачката
                    if (menuProducts.Count > 2)
                    {
                        table2.CurrentOrder.Items.Add(new OrderItem(menuProducts[2], 1));
                        table2.CurrentOrder.Items.Add(new OrderItem(menuProducts[1], 2));
                    }

                    // 4. Професионално ја означуваме како услужена преку логиката во Table.cs
                    table2.OrderServed();
                    // Ако сакаш реално време на услуга (пр. услужена 2 минути по седнувањето):
                    table2.OrderServedTime = table2.SeatingTime.Value.AddMinutes(2);
                }

                // --- МАСА 11: Опслужена и БАРА СМЕТКА (Црвена со Блинк/Икона) ---
                if (table11 != null)
                {
                    // 1. Ги седнуваме гостите
                    table11.GuestsSeated("Ана Стојанова");

                    // 2. Симулираме дека седнале пред 25 минути
                    table11.SeatingTime = DateTime.Now.AddMinutes(-25);
                    table11.CurrentOrder.CreationTime = table11.SeatingTime.Value;

                    // 3. Ги додаваме продуктите во нарачката
                    if (menuProducts.Count > 3)
                    {
                        table11.CurrentOrder.Items.Add(new OrderItem(menuProducts[3], 3));
                    }

                    // 4. Официјално ја префрламе во услужена состојба
                    table11.OrderServed();
                    table11.OrderServedTime = table11.SeatingTime.Value.AddMinutes(4); // услужена по 4 мин

                    // 5. Вклучуваме статус дека активни побарува сметка!
                    table11.IsRequestingBill = true;
                }
            }
        }

        private void lblLiveTime_Click(object sender, EventArgs e){}


        private (string text, Color color) GetEfficiencyStatus(TimeSpan waitingTime)
        {
            double minutes = waitingTime.TotalMinutes;

            if (minutes <= 2)
                return ("Одлично  ", Color.FromArgb(46, 204, 113));     // Зелена
            if (minutes <= 5)
                return ("Добро 🔵", Color.FromArgb(52, 152, 219));    // Сина
            if (minutes <= 10)
                return ("Умерено 🟡", Color.FromArgb(241, 196, 15));   // Жолта

            return ("Бавно 🔴", Color.FromArgb(231, 76, 60));         // Црвена
        }

        private void btnSimulateBill_Click(object sender, EventArgs e)
        {
            string inputText = cmbSimulatorTables.Text.Trim();

            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Ве молиме изберете или внесете број на маса за симулација!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedTableNum;
            var digitsOnly = new string(inputText.Where(char.IsDigit).ToArray());

            if (!int.TryParse(digitsOnly, out selectedTableNum))
            {
                MessageBox.Show("Внесовте невалиден формат за маса. Внесете само бројка!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Table table = barLayout.Tables.FirstOrDefault(t => t.TableNumber == selectedTableNum);

            if (table == null)
            {
                MessageBox.Show($"Масата со број {selectedTableNum} не постои во распоредот!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (table.Status != TableStatus.OccupiedServed)
            {
                string poraka = "Не може да се побара сметка!\n";

                if (table.Status == TableStatus.Free)
                    poraka += $"Маса {selectedTableNum} е целосно празна.";
                else if (table.Status == TableStatus.OccupiedUnserved)
                    poraka += $"Нарачката за маса {selectedTableNum} сè уште не е донесена (не е услужена).";

                MessageBox.Show(poraka, "Симулацијата е одбиена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            table.IsRequestingBill = true;

            pnlTablesFloor.Invalidate();
            UpdateRightPanel();
            UpdateFloorStatistics();

            MessageBox.Show($"Успешна симулација! Маса {selectedTableNum} побара сметка. 💰", "Симулатор", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    
}


