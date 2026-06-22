using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBarManager
{
    public class BarLayout
    {
        public List<Table> Tables { get; private set; }

        public Rectangle BarCounter { get; private set; }

        public BarLayout()
        {
            Tables = new List<Table>();
            InitializeLayout();
        }


        private void InitializeLayout()
        {
            int offsetX = 40;  // ДЕСНО
            int offsetY = 120;  //НАДОЛУ

            
            BarCounter = new Rectangle(140 + offsetX, 10 + offsetY, 600, 50);

            // ==============================================================
            // 1. ЦЕНТРАЛНИ ГОЛЕМИ МАСИ (2 реда по 3 маси = Вкупно 6)
            // ==============================================================
            // Прв ред централни
            Tables.Add(new Table(1, 210 + offsetX, 110 + offsetY, 85, 85));
            Tables.Add(new Table(2, 395 + offsetX, 110 + offsetY, 85, 85));
            Tables.Add(new Table(3, 580 + offsetX, 110 + offsetY, 85, 85));

            // Втор ред централни
            Tables.Add(new Table(4, 210 + offsetX, 260 + offsetY, 85, 85));
            Tables.Add(new Table(5, 395 + offsetX, 260 + offsetY, 85, 85));
            Tables.Add(new Table(6, 580 + offsetX, 260 + offsetY, 85, 85));

            // ==============================================================
            // 2. СТРАНИЧНИ МАЛИ МАСИ (По 3 во колона - Лево и Десно)
            // ==============================================================
            // Лева колона
            Tables.Add(new Table(7, 40 + offsetX, 100 + offsetY, 65, 65));
            Tables.Add(new Table(8, 40 + offsetX, 230 + offsetY, 65, 65));
            Tables.Add(new Table(9, 40 + offsetX, 360 + offsetY, 65, 65));

            // Десна колона
            Tables.Add(new Table(10, 760 + offsetX, 100 + offsetY, 65, 65));
            Tables.Add(new Table(11, 760 + offsetX, 230 + offsetY, 65, 65));
            Tables.Add(new Table(12, 760 + offsetX, 360 + offsetY, 65, 65));

            // ==============================================================
            // 3. ДОЛЕН ХОРИЗОНТАЛЕН РЕД (Точно 4 мали маси)
            // ==============================================================
            Tables.Add(new Table(13, 190 + offsetX, 420 + offsetY, 65, 65));
            Tables.Add(new Table(14, 335 + offsetX, 420 + offsetY, 65, 65));
            Tables.Add(new Table(15, 480 + offsetX, 420 + offsetY, 65, 65));
            Tables.Add(new Table(16, 625 + offsetX, 420 + offsetY, 65, 65));
        }


      

        public void Draw(Graphics g)
        {
            // 1. ЦРТАЊЕ НА ШАНКОТ
            using (Brush barBrush = new SolidBrush(Color.FromArgb(39, 45, 59)))
            {
                g.FillRectangle(barBrush, BarCounter);
            }
            using (Pen barPen = new Pen(Color.FromArgb(55, 63, 81), 2))
            {
                g.DrawRectangle(barPen, BarCounter);
            }

            using (Font barFont = new Font("Segoe UI", 11, FontStyle.Bold))
            {
                SizeF barTextSize = g.MeasureString("Ш А Н К  ( B A R )", barFont);
                float barTextX = BarCounter.X + (BarCounter.Width / 2) - (barTextSize.Width / 2);
                float barTextY = BarCounter.Y + (BarCounter.Height / 2) - (barTextSize.Height / 2);
                g.DrawString("Ш А Н К  ( B A R )", barFont, Brushes.White, barTextX, barTextY);
            }

            // 2. ЦРТАЊЕ НА МАСИТЕ И НИВНИТЕ КАРТИЧКИ
            foreach (Table table in Tables)
            {
                
                int paddingX = 26;
                int paddingY = 20;
                int cardX = table.X - paddingX;
                int cardY = table.Y - paddingY;
                int cardWidth = table.Width + (paddingX * 2);
                int cardHeight = table.Height + (paddingY * 2) + 8; 

                
                using (System.Drawing.Drawing2D.GraphicsPath cardPath = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 16;
                    cardPath.AddArc(cardX, cardY, radius, radius, 180, 90);
                    cardPath.AddArc(cardX + cardWidth - radius, cardY, radius, radius, 270, 90);
                    cardPath.AddArc(cardX + cardWidth - radius, cardY + cardHeight - radius, radius, radius, 0, 90);
                    cardPath.AddArc(cardX, cardY + cardHeight - radius, radius, radius, 90, 90);
                    cardPath.CloseAllFigures();

                    using (Brush cardBrush = new SolidBrush(Color.FromArgb(32, 38, 50)))
                    {
                        g.FillPath(cardBrush, cardPath);
                    }

                    using (Pen cardPen = new Pen(Color.FromArgb(48, 56, 74), 1))
                    {
                        g.DrawPath(cardPen, cardPath);
                    }
                }

                
                Color statusColor = table.GetStatusColor();
                Color modernStatusColor = statusColor;
                if (statusColor == Color.Green) modernStatusColor = Color.FromArgb(46, 204, 113);
                else if (statusColor == Color.Yellow) modernStatusColor = Color.FromArgb(241, 196, 15);
                else if (statusColor == Color.Red) modernStatusColor = Color.FromArgb(231, 76, 60);

                using (Brush chairBrush = new SolidBrush(Color.FromArgb(48, 57, 74)))
                using (Brush tableBrush = new SolidBrush(modernStatusColor))
                {
                    int chairSize = 14;
                    if (table.Width > 70) 
                    {
                        g.FillRectangle(chairBrush, table.X + (table.Width / 2) - 20, table.Y - chairSize + 2, 40, chairSize); // Горе
                        g.FillRectangle(chairBrush, table.X + (table.Width / 2) - 20, table.Y + table.Height - 2, 40, chairSize); // Долу
                        g.FillRectangle(chairBrush, table.X - chairSize + 2, table.Y + (table.Height / 2) - 20, chairSize, 40); // Лево
                        g.FillRectangle(chairBrush, table.X + table.Width - 2, table.Y + (table.Height / 2) - 20, chairSize, 40); // Десно
                    }
                    else // Мали маси
                    {
                        g.FillRectangle(chairBrush, table.X - chairSize + 2, table.Y + (table.Height / 2) - 15, chairSize, 30); // Лево
                        g.FillRectangle(chairBrush, table.X + table.Width - 2, table.Y + (table.Height / 2) - 15, chairSize, 30); // Десно
                    }

                   
                    g.FillEllipse(tableBrush, table.X, table.Y, table.Width, table.Height);
                }

                
                using (Font font = new Font("Segoe UI", 11, FontStyle.Bold))
                {
                    string text = table.TableNumber.ToString();
                    SizeF textSize = g.MeasureString(text, font);
                    float textX = table.X + (table.Width / 2) - (textSize.Width / 2);
                    float textY = table.Y + (table.Height / 2) - (textSize.Height / 2) + 1;

                    g.DrawString(text, font, Brushes.White, textX, textY);
                }
            }
        }

        public Table GetTableAt(int mouseX, int mouseY)
        {
            foreach (Table table in Tables)
            {
                if (table.IsClicked(mouseX, mouseY))
                {
                    return table;
                }
            }
            return null;
        }

    }
}
