namespace CafeBarManager
{
    partial class InventoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalItemsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWarningCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCriticalCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.H1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblStableCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpStockList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNewPurchase = new System.Windows.Forms.Panel();
            this.btnSavePurchase = new System.Windows.Forms.Button();
            this.lblTotalPurchasePrice = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNewTotalStockPreview = new System.Windows.Forms.Label();
            this.lblAddedStockPreview = new System.Windows.Forms.Label();
            this.lblCurrentStockPreview = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numPricePerUnit = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstRecentPurchases = new System.Windows.Forms.ListBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.stats_inventory = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlNewPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPricePerUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.stats_inventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblTotalItemsCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(53, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 61);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalItemsCount
            // 
            this.lblTotalItemsCount.AutoSize = true;
            this.lblTotalItemsCount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalItemsCount.Location = new System.Drawing.Point(16, 13);
            this.lblTotalItemsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalItemsCount.Name = "lblTotalItemsCount";
            this.lblTotalItemsCount.Size = new System.Drawing.Size(34, 25);
            this.lblTotalItemsCount.TabIndex = 1;
            this.lblTotalItemsCount.Text = "22";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вкупно артикли";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.lblWarningCount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(666, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 61);
            this.panel2.TabIndex = 2;
            // 
            // lblWarningCount
            // 
            this.lblWarningCount.AutoSize = true;
            this.lblWarningCount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningCount.ForeColor = System.Drawing.Color.White;
            this.lblWarningCount.Location = new System.Drawing.Point(12, 13);
            this.lblWarningCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarningCount.Name = "lblWarningCount";
            this.lblWarningCount.Size = new System.Drawing.Size(23, 25);
            this.lblWarningCount.TabIndex = 3;
            this.lblWarningCount.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Предупредување";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.lblCriticalCount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(954, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 61);
            this.panel3.TabIndex = 3;
            // 
            // lblCriticalCount
            // 
            this.lblCriticalCount.AutoSize = true;
            this.lblCriticalCount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticalCount.ForeColor = System.Drawing.Color.White;
            this.lblCriticalCount.Location = new System.Drawing.Point(22, 13);
            this.lblCriticalCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCriticalCount.Name = "lblCriticalCount";
            this.lblCriticalCount.Size = new System.Drawing.Size(23, 25);
            this.lblCriticalCount.TabIndex = 4;
            this.lblCriticalCount.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Критично";
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.BackColor = System.Drawing.Color.Transparent;
            this.H1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1.ForeColor = System.Drawing.Color.White;
            this.H1.Location = new System.Drawing.Point(24, 7);
            this.H1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(179, 21);
            this.H1.TabIndex = 4;
            this.H1.Text = "📦 Залиха и Набавки";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.lblStableCount);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(371, 45);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 61);
            this.panel4.TabIndex = 5;
            // 
            // lblStableCount
            // 
            this.lblStableCount.AutoSize = true;
            this.lblStableCount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStableCount.ForeColor = System.Drawing.Color.White;
            this.lblStableCount.Location = new System.Drawing.Point(16, 13);
            this.lblStableCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStableCount.Name = "lblStableCount";
            this.lblStableCount.Size = new System.Drawing.Size(34, 25);
            this.lblStableCount.TabIndex = 2;
            this.lblStableCount.Text = "17";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Стабилни";
            // 
            // flpStockList
            // 
            this.flpStockList.AutoScroll = true;
            this.flpStockList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.flpStockList.Location = new System.Drawing.Point(28, 182);
            this.flpStockList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpStockList.Name = "flpStockList";
            this.flpStockList.Size = new System.Drawing.Size(709, 468);
            this.flpStockList.TabIndex = 6;
            // 
            // pnlNewPurchase
            // 
            this.pnlNewPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.pnlNewPurchase.Controls.Add(this.btnSavePurchase);
            this.pnlNewPurchase.Controls.Add(this.label9);
            this.pnlNewPurchase.Controls.Add(this.label8);
            this.pnlNewPurchase.Controls.Add(this.numPricePerUnit);
            this.pnlNewPurchase.Controls.Add(this.label7);
            this.pnlNewPurchase.Controls.Add(this.label6);
            this.pnlNewPurchase.Controls.Add(this.label5);
            this.pnlNewPurchase.Controls.Add(this.lstRecentPurchases);
            this.pnlNewPurchase.Controls.Add(this.numQuantity);
            this.pnlNewPurchase.Controls.Add(this.cmbProducts);
            this.pnlNewPurchase.Controls.Add(this.stats_inventory);
            this.pnlNewPurchase.Location = new System.Drawing.Point(766, 134);
            this.pnlNewPurchase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNewPurchase.Name = "pnlNewPurchase";
            this.pnlNewPurchase.Size = new System.Drawing.Size(407, 516);
            this.pnlNewPurchase.TabIndex = 7;
            // 
            // btnSavePurchase
            // 
            this.btnSavePurchase.BackColor = System.Drawing.Color.Green;
            this.btnSavePurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePurchase.ForeColor = System.Drawing.Color.White;
            this.btnSavePurchase.Location = new System.Drawing.Point(22, 313);
            this.btnSavePurchase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSavePurchase.Name = "btnSavePurchase";
            this.btnSavePurchase.Size = new System.Drawing.Size(361, 35);
            this.btnSavePurchase.TabIndex = 18;
            this.btnSavePurchase.Text = "Зачувај набавка";
            this.btnSavePurchase.UseVisualStyleBackColor = false;
            this.btnSavePurchase.Click += new System.EventHandler(this.btnSavePurchase_Click);
            // 
            // lblTotalPurchasePrice
            // 
            this.lblTotalPurchasePrice.AutoSize = true;
            this.lblTotalPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPurchasePrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPurchasePrice.Location = new System.Drawing.Point(294, 85);
            this.lblTotalPurchasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPurchasePrice.Name = "lblTotalPurchasePrice";
            this.lblTotalPurchasePrice.Size = new System.Drawing.Size(50, 21);
            this.lblTotalPurchasePrice.TabIndex = 16;
            this.lblTotalPurchasePrice.Text = "00,00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(15, 85);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 21);
            this.label16.TabIndex = 15;
            this.label16.Text = "Вкупна цена набавка";
            // 
            // lblNewTotalStockPreview
            // 
            this.lblNewTotalStockPreview.AutoSize = true;
            this.lblNewTotalStockPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTotalStockPreview.ForeColor = System.Drawing.Color.Silver;
            this.lblNewTotalStockPreview.Location = new System.Drawing.Point(304, 47);
            this.lblNewTotalStockPreview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewTotalStockPreview.Name = "lblNewTotalStockPreview";
            this.lblNewTotalStockPreview.Size = new System.Drawing.Size(40, 16);
            this.lblNewTotalStockPreview.TabIndex = 14;
            this.lblNewTotalStockPreview.Text = "0 пак";
            // 
            // lblAddedStockPreview
            // 
            this.lblAddedStockPreview.AutoSize = true;
            this.lblAddedStockPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedStockPreview.ForeColor = System.Drawing.Color.Green;
            this.lblAddedStockPreview.Location = new System.Drawing.Point(291, 29);
            this.lblAddedStockPreview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddedStockPreview.Name = "lblAddedStockPreview";
            this.lblAddedStockPreview.Size = new System.Drawing.Size(50, 16);
            this.lblAddedStockPreview.TabIndex = 13;
            this.lblAddedStockPreview.Text = "+ 0 пак";
            // 
            // lblCurrentStockPreview
            // 
            this.lblCurrentStockPreview.AutoSize = true;
            this.lblCurrentStockPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStockPreview.ForeColor = System.Drawing.Color.Silver;
            this.lblCurrentStockPreview.Location = new System.Drawing.Point(300, 11);
            this.lblCurrentStockPreview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentStockPreview.Name = "lblCurrentStockPreview";
            this.lblCurrentStockPreview.Size = new System.Drawing.Size(40, 16);
            this.lblCurrentStockPreview.TabIndex = 12;
            this.lblCurrentStockPreview.Text = "0 пак";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(16, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Нова вкупна залиха";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(16, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "+ Нова залиха";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(16, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Моментална залиха";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(18, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Нова Набавка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(236, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Цена по единица";
            // 
            // numPricePerUnit
            // 
            this.numPricePerUnit.Location = new System.Drawing.Point(240, 140);
            this.numPricePerUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numPricePerUnit.Name = "numPricePerUnit";
            this.numPricePerUnit.Size = new System.Drawing.Size(143, 20);
            this.numPricePerUnit.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Количина";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Производ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Скорешни Набавки";
            // 
            // lstRecentPurchases
            // 
            this.lstRecentPurchases.FormattingEnabled = true;
            this.lstRecentPurchases.Location = new System.Drawing.Point(2, 393);
            this.lstRecentPurchases.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstRecentPurchases.Name = "lstRecentPurchases";
            this.lstRecentPurchases.Size = new System.Drawing.Size(421, 121);
            this.lstRecentPurchases.TabIndex = 2;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(24, 140);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(154, 20);
            this.numQuantity.TabIndex = 1;
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(24, 78);
            this.cmbProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(358, 21);
            this.cmbProducts.TabIndex = 0;
            // 
            // stats_inventory
            // 
            this.stats_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.stats_inventory.Controls.Add(this.label11);
            this.stats_inventory.Controls.Add(this.label10);
            this.stats_inventory.Controls.Add(this.lblCurrentStockPreview);
            this.stats_inventory.Controls.Add(this.lblAddedStockPreview);
            this.stats_inventory.Controls.Add(this.lblNewTotalStockPreview);
            this.stats_inventory.Controls.Add(this.lblTotalPurchasePrice);
            this.stats_inventory.Controls.Add(this.label12);
            this.stats_inventory.Controls.Add(this.label16);
            this.stats_inventory.Location = new System.Drawing.Point(21, 195);
            this.stats_inventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stats_inventory.Name = "stats_inventory";
            this.stats_inventory.Size = new System.Drawing.Size(361, 114);
            this.stats_inventory.TabIndex = 17;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(24, 124);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(153, 19);
            this.label22.TabIndex = 8;
            this.label22.Text = "Залиха на Суровини";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label23.Location = new System.Drawing.Point(50, 159);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Продукт";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label24.Location = new System.Drawing.Point(232, 159);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Моментална залиха";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label25.Location = new System.Drawing.Point(481, 161);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "Минимум";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label26.Location = new System.Drawing.Point(593, 159);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 12;
            this.label26.Text = "Статус";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pnlNewPurchase);
            this.Controls.Add(this.flpStockList);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.H1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlNewPurchase.ResumeLayout(false);
            this.pnlNewPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPricePerUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.stats_inventory.ResumeLayout(false);
            this.stats_inventory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpStockList;
        private System.Windows.Forms.Panel pnlNewPurchase;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPricePerUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstRecentPurchases;
        private System.Windows.Forms.Panel stats_inventory;
        private System.Windows.Forms.Label lblTotalPurchasePrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblNewTotalStockPreview;
        private System.Windows.Forms.Label lblAddedStockPreview;
        private System.Windows.Forms.Label lblCurrentStockPreview;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalItemsCount;
        private System.Windows.Forms.Label lblWarningCount;
        private System.Windows.Forms.Label lblCriticalCount;
        private System.Windows.Forms.Label lblStableCount;
        private System.Windows.Forms.Button btnSavePurchase;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
    }
}