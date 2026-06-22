namespace CafeBarManager
{
    partial class OrderForm
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
            this.pnlOrderRight = new System.Windows.Forms.Panel();
            this.flpOrderItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOrderFooter = new System.Windows.Forms.Panel();
            this.btnMainAction = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.lblDDV = new System.Windows.Forms.Label();
            this.lblNetPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOrderHeader = new System.Windows.Forms.Panel();
            this.lblStatusBadge = new System.Windows.Forms.Label();
            this.lblOrderSubtitle = new System.Windows.Forms.Label();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.pnlMenuLeft = new System.Windows.Forms.Panel();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCatAll = new System.Windows.Forms.Button();
            this.btnCatCoffee = new System.Windows.Forms.Button();
            this.btnCatJuices = new System.Windows.Forms.Button();
            this.btnCatWater = new System.Windows.Forms.Button();
            this.btnCatAlcohol = new System.Windows.Forms.Button();
            this.btnCatDesserts = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescMenu = new System.Windows.Forms.Label();
            this.lblSelectedTableName = new System.Windows.Forms.Label();
            this.flpMenuProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.pnlOrderRight.SuspendLayout();
            this.pnlOrderFooter.SuspendLayout();
            this.pnlOrderHeader.SuspendLayout();
            this.pnlMenuLeft.SuspendLayout();
            this.flpCategories.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrderRight
            // 
            this.pnlOrderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlOrderRight.Controls.Add(this.flpOrderItems);
            this.pnlOrderRight.Controls.Add(this.pnlOrderFooter);
            this.pnlOrderRight.Controls.Add(this.pnlOrderHeader);
            this.pnlOrderRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderRight.Location = new System.Drawing.Point(640, 0);
            this.pnlOrderRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOrderRight.Name = "pnlOrderRight";
            this.pnlOrderRight.Size = new System.Drawing.Size(672, 814);
            this.pnlOrderRight.TabIndex = 1;
            // 
            // flpOrderItems
            // 
            this.flpOrderItems.AutoScroll = true;
            this.flpOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOrderItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOrderItems.Location = new System.Drawing.Point(0, 111);
            this.flpOrderItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpOrderItems.Name = "flpOrderItems";
            this.flpOrderItems.Size = new System.Drawing.Size(672, 481);
            this.flpOrderItems.TabIndex = 2;
            this.flpOrderItems.WrapContents = false;
            // 
            // pnlOrderFooter
            // 
            this.pnlOrderFooter.Controls.Add(this.btnMainAction);
            this.pnlOrderFooter.Controls.Add(this.btnPay);
            this.pnlOrderFooter.Controls.Add(this.lblTotalSum);
            this.pnlOrderFooter.Controls.Add(this.lblDDV);
            this.pnlOrderFooter.Controls.Add(this.lblNetPrice);
            this.pnlOrderFooter.Controls.Add(this.label3);
            this.pnlOrderFooter.Controls.Add(this.label2);
            this.pnlOrderFooter.Controls.Add(this.label1);
            this.pnlOrderFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOrderFooter.Location = new System.Drawing.Point(0, 592);
            this.pnlOrderFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOrderFooter.Name = "pnlOrderFooter";
            this.pnlOrderFooter.Size = new System.Drawing.Size(672, 222);
            this.pnlOrderFooter.TabIndex = 1;
            // 
            // btnMainAction
            // 
            this.btnMainAction.Location = new System.Drawing.Point(361, 160);
            this.btnMainAction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMainAction.Name = "btnMainAction";
            this.btnMainAction.Size = new System.Drawing.Size(256, 32);
            this.btnMainAction.TabIndex = 7;
            this.btnMainAction.Text = "Зачувај нарачка";
            this.btnMainAction.UseVisualStyleBackColor = true;
            this.btnMainAction.Click += new System.EventHandler(this.btnMainAction_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(35, 160);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(293, 32);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Наплати";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSum.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalSum.Location = new System.Drawing.Point(519, 110);
            this.lblTotalSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(94, 28);
            this.lblTotalSum.TabIndex = 5;
            this.lblTotalSum.Text = "00,0 ден";
            // 
            // lblDDV
            // 
            this.lblDDV.AutoSize = true;
            this.lblDDV.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDDV.Location = new System.Drawing.Point(552, 79);
            this.lblDDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDDV.Name = "lblDDV";
            this.lblDDV.Size = new System.Drawing.Size(58, 16);
            this.lblDDV.TabIndex = 4;
            this.lblDDV.Text = "00,0 ден";
            // 
            // lblNetPrice
            // 
            this.lblNetPrice.AutoSize = true;
            this.lblNetPrice.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNetPrice.Location = new System.Drawing.Point(552, 46);
            this.lblNetPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetPrice.Name = "lblNetPrice";
            this.lblNetPrice.Size = new System.Drawing.Size(58, 16);
            this.lblNetPrice.TabIndex = 3;
            this.lblNetPrice.Text = "00.0 ден";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вкупно";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ДДВ (18%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нето Износ";
            // 
            // pnlOrderHeader
            // 
            this.pnlOrderHeader.Controls.Add(this.lblStatusBadge);
            this.pnlOrderHeader.Controls.Add(this.lblOrderSubtitle);
            this.pnlOrderHeader.Controls.Add(this.lblOrderTitle);
            this.pnlOrderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOrderHeader.Name = "pnlOrderHeader";
            this.pnlOrderHeader.Size = new System.Drawing.Size(672, 111);
            this.pnlOrderHeader.TabIndex = 0;
            // 
            // lblStatusBadge
            // 
            this.lblStatusBadge.AutoSize = true;
            this.lblStatusBadge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBadge.ForeColor = System.Drawing.Color.White;
            this.lblStatusBadge.Location = new System.Drawing.Point(436, 32);
            this.lblStatusBadge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusBadge.Name = "lblStatusBadge";
            this.lblStatusBadge.Size = new System.Drawing.Size(107, 28);
            this.lblStatusBadge.TabIndex = 2;
            this.lblStatusBadge.Text = "Слободна";
            // 
            // lblOrderSubtitle
            // 
            this.lblOrderSubtitle.AutoSize = true;
            this.lblOrderSubtitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblOrderSubtitle.Location = new System.Drawing.Point(33, 63);
            this.lblOrderSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderSubtitle.Name = "lblOrderSubtitle";
            this.lblOrderSubtitle.Size = new System.Drawing.Size(183, 16);
            this.lblOrderSubtitle.TabIndex = 1;
            this.lblOrderSubtitle.Text = "0 артикли : 00:00 во чекање";
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTitle.ForeColor = System.Drawing.Color.White;
            this.lblOrderTitle.Location = new System.Drawing.Point(31, 27);
            this.lblOrderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(212, 32);
            this.lblOrderTitle.TabIndex = 0;
            this.lblOrderTitle.Text = "Тековна нарачка";
            // 
            // pnlMenuLeft
            // 
            this.pnlMenuLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenuLeft.Controls.Add(this.flpCategories);
            this.pnlMenuLeft.Controls.Add(this.panel1);
            this.pnlMenuLeft.Controls.Add(this.flpMenuProducts);
            this.pnlMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenuLeft.Name = "pnlMenuLeft";
            this.pnlMenuLeft.Size = new System.Drawing.Size(640, 814);
            this.pnlMenuLeft.TabIndex = 0;
            // 
            // flpCategories
            // 
            this.flpCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.flpCategories.Controls.Add(this.btnCatAll);
            this.flpCategories.Controls.Add(this.btnCatCoffee);
            this.flpCategories.Controls.Add(this.btnCatJuices);
            this.flpCategories.Controls.Add(this.btnCatWater);
            this.flpCategories.Controls.Add(this.btnCatAlcohol);
            this.flpCategories.Controls.Add(this.btnCatDesserts);
            this.flpCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCategories.Location = new System.Drawing.Point(0, 129);
            this.flpCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Padding = new System.Windows.Forms.Padding(40, 12, 0, 0);
            this.flpCategories.Size = new System.Drawing.Size(640, 100);
            this.flpCategories.TabIndex = 1;
            // 
            // btnCatAll
            // 
            this.btnCatAll.Location = new System.Drawing.Point(44, 16);
            this.btnCatAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCatAll.Name = "btnCatAll";
            this.btnCatAll.Size = new System.Drawing.Size(100, 28);
            this.btnCatAll.TabIndex = 0;
            this.btnCatAll.Text = "Сите";
            this.btnCatAll.UseVisualStyleBackColor = true;
            this.btnCatAll.Click += new System.EventHandler(this.btnCatAll_Click);
            // 
            // btnCatCoffee
            // 
            this.btnCatCoffee.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCatCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatCoffee.ForeColor = System.Drawing.Color.White;
            this.btnCatCoffee.Location = new System.Drawing.Point(152, 16);
            this.btnCatCoffee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCatCoffee.Name = "btnCatCoffee";
            this.btnCatCoffee.Size = new System.Drawing.Size(100, 28);
            this.btnCatCoffee.TabIndex = 1;
            this.btnCatCoffee.Text = "Кафиња";
            this.btnCatCoffee.UseVisualStyleBackColor = false;
            this.btnCatCoffee.Click += new System.EventHandler(this.btnCatCoffee_Click);
            // 
            // btnCatJuices
            // 
            this.btnCatJuices.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCatJuices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatJuices.ForeColor = System.Drawing.Color.White;
            this.btnCatJuices.Location = new System.Drawing.Point(260, 16);
            this.btnCatJuices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCatJuices.Name = "btnCatJuices";
            this.btnCatJuices.Size = new System.Drawing.Size(100, 28);
            this.btnCatJuices.TabIndex = 2;
            this.btnCatJuices.Text = "Сокови";
            this.btnCatJuices.UseVisualStyleBackColor = false;
            this.btnCatJuices.Click += new System.EventHandler(this.btnCatJuices_Click);
            // 
            // btnCatWater
            // 
            this.btnCatWater.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCatWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatWater.ForeColor = System.Drawing.Color.White;
            this.btnCatWater.Location = new System.Drawing.Point(368, 16);
            this.btnCatWater.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCatWater.Name = "btnCatWater";
            this.btnCatWater.Size = new System.Drawing.Size(100, 28);
            this.btnCatWater.TabIndex = 3;
            this.btnCatWater.Text = "Вода";
            this.btnCatWater.UseVisualStyleBackColor = false;
            this.btnCatWater.Click += new System.EventHandler(this.btnCatWater_Click);
            // 
            // btnCatAlcohol
            // 
            this.btnCatAlcohol.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCatAlcohol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatAlcohol.ForeColor = System.Drawing.Color.White;
            this.btnCatAlcohol.Location = new System.Drawing.Point(476, 16);
            this.btnCatAlcohol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCatAlcohol.Name = "btnCatAlcohol";
            this.btnCatAlcohol.Size = new System.Drawing.Size(100, 28);
            this.btnCatAlcohol.TabIndex = 4;
            this.btnCatAlcohol.Text = "Алкохол";
            this.btnCatAlcohol.UseVisualStyleBackColor = false;
            this.btnCatAlcohol.Click += new System.EventHandler(this.btnCatAlcohol_Click);
            // 
            // btnCatDesserts
            // 
            this.btnCatDesserts.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCatDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatDesserts.ForeColor = System.Drawing.Color.White;
            this.btnCatDesserts.Location = new System.Drawing.Point(44, 52);
            this.btnCatDesserts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCatDesserts.Name = "btnCatDesserts";
            this.btnCatDesserts.Size = new System.Drawing.Size(100, 28);
            this.btnCatDesserts.TabIndex = 5;
            this.btnCatDesserts.Text = "Десерти";
            this.btnCatDesserts.UseVisualStyleBackColor = false;
            this.btnCatDesserts.Click += new System.EventHandler(this.btnCatDesserts_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.txtSearchCode);
            this.panel1.Controls.Add(this.lblDescMenu);
            this.panel1.Controls.Add(this.lblSelectedTableName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 129);
            this.panel1.TabIndex = 2;
            // 
            // lblDescMenu
            // 
            this.lblDescMenu.AutoSize = true;
            this.lblDescMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescMenu.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDescMenu.Location = new System.Drawing.Point(41, 58);
            this.lblDescMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescMenu.Name = "lblDescMenu";
            this.lblDescMenu.Size = new System.Drawing.Size(243, 23);
            this.lblDescMenu.TabIndex = 1;
            this.lblDescMenu.Text = "Избери артикли за додавање";
            // 
            // lblSelectedTableName
            // 
            this.lblSelectedTableName.AutoSize = true;
            this.lblSelectedTableName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTableName.ForeColor = System.Drawing.Color.White;
            this.lblSelectedTableName.Location = new System.Drawing.Point(39, 21);
            this.lblSelectedTableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedTableName.Name = "lblSelectedTableName";
            this.lblSelectedTableName.Size = new System.Drawing.Size(220, 37);
            this.lblSelectedTableName.TabIndex = 0;
            this.lblSelectedTableName.Text = "Мени -- Маса 0";
            // 
            // flpMenuProducts
            // 
            this.flpMenuProducts.AutoScroll = true;
            this.flpMenuProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.flpMenuProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenuProducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenuProducts.Location = new System.Drawing.Point(0, 0);
            this.flpMenuProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpMenuProducts.Name = "flpMenuProducts";
            this.flpMenuProducts.Padding = new System.Windows.Forms.Padding(13, 240, 0, 10);
            this.flpMenuProducts.Size = new System.Drawing.Size(640, 814);
            this.flpMenuProducts.TabIndex = 0;
            this.flpMenuProducts.WrapContents = false;
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCode.Location = new System.Drawing.Point(45, 88);
            this.txtSearchCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(300, 30);
            this.txtSearchCode.TabIndex = 0;
            this.txtSearchCode.Text = "Внеси шифра...";
            this.txtSearchCode.TextChanged += new System.EventHandler(this.txtSearchCode_TextChanged);
            this.txtSearchCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchCode_KeyDown_1);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 814);
            this.Controls.Add(this.pnlOrderRight);
            this.Controls.Add(this.pnlMenuLeft);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.pnlOrderRight.ResumeLayout(false);
            this.pnlOrderFooter.ResumeLayout(false);
            this.pnlOrderFooter.PerformLayout();
            this.pnlOrderHeader.ResumeLayout(false);
            this.pnlOrderHeader.PerformLayout();
            this.pnlMenuLeft.ResumeLayout(false);
            this.flpCategories.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderRight;
        private System.Windows.Forms.Panel pnlMenuLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescMenu;
        private System.Windows.Forms.Label lblSelectedTableName;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private System.Windows.Forms.Button btnCatAll;
        private System.Windows.Forms.Button btnCatCoffee;
        private System.Windows.Forms.Button btnCatJuices;
        private System.Windows.Forms.Button btnCatWater;
        private System.Windows.Forms.Button btnCatAlcohol;
        private System.Windows.Forms.Button btnCatDesserts;
        private System.Windows.Forms.FlowLayoutPanel flpMenuProducts;
        private System.Windows.Forms.Panel pnlOrderHeader;
        private System.Windows.Forms.Panel pnlOrderFooter;
        private System.Windows.Forms.Label lblOrderSubtitle;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Button btnMainAction;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.Label lblDDV;
        private System.Windows.Forms.Label lblNetPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpOrderItems;
        private System.Windows.Forms.Label lblStatusBadge;
        private System.Windows.Forms.TextBox txtSearchCode;
    }
}