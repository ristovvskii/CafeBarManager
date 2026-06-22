namespace CafeBarManager
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalDDV = new System.Windows.Forms.Label();
            this.lblAverageOrder = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblPeriodTitle = new System.Windows.Forms.Label();
            this.pnlTimeFilter = new System.Windows.Forms.Panel();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.btnDaily = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpTopProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flpTopWaiters = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEfficiency = new System.Windows.Forms.Panel();
            this.ExportTXT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.pnlTimeFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.chartRevenue);
            this.panel1.Controls.Add(this.lblTotalDDV);
            this.panel1.Controls.Add(this.lblAverageOrder);
            this.panel1.Controls.Add(this.lblTotalOrders);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblTotalRevenue);
            this.panel1.Controls.Add(this.lblPeriodTitle);
            this.panel1.Controls.Add(this.pnlTimeFilter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 380);
            this.panel1.TabIndex = 0;
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.chartRevenue.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea2);
            this.chartRevenue.Location = new System.Drawing.Point(35, 169);
            this.chartRevenue.Name = "chartRevenue";
            series2.ChartArea = "ChartArea1";
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            series2.Name = "Revenue";
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Size = new System.Drawing.Size(480, 157);
            this.chartRevenue.TabIndex = 14;
            this.chartRevenue.Text = "chart1";
            // 
            // lblTotalDDV
            // 
            this.lblTotalDDV.AutoSize = true;
            this.lblTotalDDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDDV.ForeColor = System.Drawing.Color.White;
            this.lblTotalDDV.Location = new System.Drawing.Point(457, 338);
            this.lblTotalDDV.Name = "lblTotalDDV";
            this.lblTotalDDV.Size = new System.Drawing.Size(43, 16);
            this.lblTotalDDV.TabIndex = 13;
            this.lblTotalDDV.Text = "8,193";
            // 
            // lblAverageOrder
            // 
            this.lblAverageOrder.AutoSize = true;
            this.lblAverageOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageOrder.ForeColor = System.Drawing.Color.White;
            this.lblAverageOrder.Location = new System.Drawing.Point(246, 339);
            this.lblAverageOrder.Name = "lblAverageOrder";
            this.lblAverageOrder.Size = new System.Drawing.Size(31, 16);
            this.lblAverageOrder.TabIndex = 12;
            this.lblAverageOrder.Text = "152";
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.ForeColor = System.Drawing.Color.White;
            this.lblTotalOrders.Location = new System.Drawing.Point(53, 338);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(31, 16);
            this.lblTotalOrders.TabIndex = 9;
            this.lblTotalOrders.Text = "312";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(444, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "ДДВ собран";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(230, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Просек / нар.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Нарачки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(319, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "ден";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(203, 129);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(104, 37);
            this.lblTotalRevenue.TabIndex = 4;
            this.lblTotalRevenue.Text = "45,500";
            // 
            // lblPeriodTitle
            // 
            this.lblPeriodTitle.AutoSize = true;
            this.lblPeriodTitle.ForeColor = System.Drawing.Color.White;
            this.lblPeriodTitle.Location = new System.Drawing.Point(192, 102);
            this.lblPeriodTitle.Name = "lblPeriodTitle";
            this.lblPeriodTitle.Size = new System.Drawing.Size(153, 13);
            this.lblPeriodTitle.TabIndex = 3;
            this.lblPeriodTitle.Text = "Вкупен приход (оваа недела)";
            // 
            // pnlTimeFilter
            // 
            this.pnlTimeFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.pnlTimeFilter.Controls.Add(this.btnMonthly);
            this.pnlTimeFilter.Controls.Add(this.btnWeekly);
            this.pnlTimeFilter.Controls.Add(this.btnDaily);
            this.pnlTimeFilter.Location = new System.Drawing.Point(35, 53);
            this.pnlTimeFilter.Name = "pnlTimeFilter";
            this.pnlTimeFilter.Size = new System.Drawing.Size(480, 35);
            this.pnlTimeFilter.TabIndex = 2;
            // 
            // btnMonthly
            // 
            this.btnMonthly.FlatAppearance.BorderSize = 0;
            this.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.ForeColor = System.Drawing.Color.DimGray;
            this.btnMonthly.Location = new System.Drawing.Point(320, 0);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(160, 35);
            this.btnMonthly.TabIndex = 2;
            this.btnMonthly.Text = "Месечен";
            this.btnMonthly.UseVisualStyleBackColor = true;
            // 
            // btnWeekly
            // 
            this.btnWeekly.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekly.ForeColor = System.Drawing.Color.DimGray;
            this.btnWeekly.Location = new System.Drawing.Point(160, 0);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(160, 35);
            this.btnWeekly.TabIndex = 1;
            this.btnWeekly.Text = "Неделен";
            this.btnWeekly.UseVisualStyleBackColor = true;
            // 
            // btnDaily
            // 
            this.btnDaily.FlatAppearance.BorderSize = 0;
            this.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaily.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaily.ForeColor = System.Drawing.Color.White;
            this.btnDaily.Location = new System.Drawing.Point(0, 0);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(160, 35);
            this.btnDaily.TabIndex = 0;
            this.btnDaily.Text = "Дневен";
            this.btnDaily.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Профит и Промет";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.flpTopWaiters);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(612, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 342);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.flpTopProducts);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 452);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 247);
            this.panel3.TabIndex = 2;
            // 
            // flpTopProducts
            // 
            this.flpTopProducts.AutoScroll = true;
            this.flpTopProducts.BackColor = System.Drawing.Color.Transparent;
            this.flpTopProducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTopProducts.Location = new System.Drawing.Point(22, 23);
            this.flpTopProducts.Name = "flpTopProducts";
            this.flpTopProducts.Size = new System.Drawing.Size(565, 221);
            this.flpTopProducts.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Најпродавани Артикли";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.pnlEfficiency);
            this.panel4.Location = new System.Drawing.Point(642, 413);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 286);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "📊 Статистика и Извештаи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(57, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Преглед на перформанси · 21 Јуни 2026";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Најдобар Келнер";
            // 
            // flpTopWaiters
            // 
            this.flpTopWaiters.AutoScroll = true;
            this.flpTopWaiters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTopWaiters.Location = new System.Drawing.Point(15, 28);
            this.flpTopWaiters.Name = "flpTopWaiters";
            this.flpTopWaiters.Size = new System.Drawing.Size(529, 298);
            this.flpTopWaiters.TabIndex = 2;
            // 
            // pnlEfficiency
            // 
            this.pnlEfficiency.Location = new System.Drawing.Point(3, 3);
            this.pnlEfficiency.Name = "pnlEfficiency";
            this.pnlEfficiency.Size = new System.Drawing.Size(524, 280);
            this.pnlEfficiency.TabIndex = 3;
            // 
            // ExportTXT
            // 
            this.ExportTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.ExportTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportTXT.ForeColor = System.Drawing.Color.White;
            this.ExportTXT.Location = new System.Drawing.Point(966, 12);
            this.ExportTXT.Name = "ExportTXT";
            this.ExportTXT.Size = new System.Drawing.Size(203, 34);
            this.ExportTXT.TabIndex = 6;
            this.ExportTXT.Text = "Зачувај Извештај";
            this.ExportTXT.UseVisualStyleBackColor = false;
            this.ExportTXT.Click += new System.EventHandler(this.ExportTXT_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.ExportTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.pnlTimeFilter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTimeFilter;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnWeekly;
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblPeriodTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Label lblTotalDDV;
        private System.Windows.Forms.Label lblAverageOrder;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flpTopProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flpTopWaiters;
        private System.Windows.Forms.Panel pnlEfficiency;
        private System.Windows.Forms.Button ExportTXT;
    }
}