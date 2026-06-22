namespace CafeBarManager
{
    partial class Form1
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
            this.pnlSelectedTableCard = new System.Windows.Forms.Panel();
            this.lblServiceTime = new System.Windows.Forms.Label();
            this.btnOpenOrderDialog = new System.Windows.Forms.Button();
            this.btnPayBill = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.lblSelectedTableStatus = new System.Windows.Forms.Label();
            this.lblSelectedTableTitle = new System.Windows.Forms.Label();
            this.pnlRightControl = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSimulatorCard = new System.Windows.Forms.Panel();
            this.lbSimulator = new System.Windows.Forms.Label();
            this.btnSimulateBill = new System.Windows.Forms.Button();
            this.cmbSimulatorTables = new System.Windows.Forms.ComboBox();
            this.pnlStatusCard = new System.Windows.Forms.Panel();
            this.lblStatEarnings = new System.Windows.Forms.Label();
            this.lblStatBillRequested = new System.Windows.Forms.Label();
            this.lblStatServed = new System.Windows.Forms.Label();
            this.lblStatWaiting = new System.Windows.Forms.Label();
            this.lblStatFree = new System.Windows.Forms.Label();
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.cafe = new System.Windows.Forms.Label();
            this.lbSubTitle = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnOpenInventory = new System.Windows.Forms.Button();
            this.pnlHeaderBar = new System.Windows.Forms.Panel();
            this.lblLiveTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlFloorHeader = new System.Windows.Forms.Panel();
            this.cmbWaiter = new System.Windows.Forms.ComboBox();
            this.lblStatusBill = new System.Windows.Forms.Label();
            this.lblStatusServed = new System.Windows.Forms.Label();
            this.lblStatusUnserved = new System.Windows.Forms.Label();
            this.lblStatusFree = new System.Windows.Forms.Label();
            this.pnlTablesFloor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSelectedTableCard.SuspendLayout();
            this.pnlRightControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlSimulatorCard.SuspendLayout();
            this.pnlStatusCard.SuspendLayout();
            this.pnlLeftMenu.SuspendLayout();
            this.pnlHeaderBar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlFloorHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSelectedTableCard
            // 
            this.pnlSelectedTableCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.pnlSelectedTableCard.Controls.Add(this.label2);
            this.pnlSelectedTableCard.Controls.Add(this.lblServiceTime);
            this.pnlSelectedTableCard.Controls.Add(this.btnOpenOrderDialog);
            this.pnlSelectedTableCard.Controls.Add(this.btnPayBill);
            this.pnlSelectedTableCard.Controls.Add(this.lblTotalAmount);
            this.pnlSelectedTableCard.Controls.Add(this.lstOrders);
            this.pnlSelectedTableCard.Controls.Add(this.lblSelectedTableStatus);
            this.pnlSelectedTableCard.Controls.Add(this.lblSelectedTableTitle);
            this.pnlSelectedTableCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectedTableCard.Location = new System.Drawing.Point(10, 10);
            this.pnlSelectedTableCard.Margin = new System.Windows.Forms.Padding(10);
            this.pnlSelectedTableCard.Name = "pnlSelectedTableCard";
            this.pnlSelectedTableCard.Size = new System.Drawing.Size(330, 345);
            this.pnlSelectedTableCard.TabIndex = 0;
            // 
            // lblServiceTime
            // 
            this.lblServiceTime.AutoSize = true;
            this.lblServiceTime.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblServiceTime.Location = new System.Drawing.Point(21, 46);
            this.lblServiceTime.Name = "lblServiceTime";
            this.lblServiceTime.Size = new System.Drawing.Size(34, 13);
            this.lblServiceTime.TabIndex = 6;
            this.lblServiceTime.Text = "00:00";
            // 
            // btnOpenOrderDialog
            // 
            this.btnOpenOrderDialog.Location = new System.Drawing.Point(24, 301);
            this.btnOpenOrderDialog.Name = "btnOpenOrderDialog";
            this.btnOpenOrderDialog.Size = new System.Drawing.Size(286, 30);
            this.btnOpenOrderDialog.TabIndex = 5;
            this.btnOpenOrderDialog.Text = "Додади артикл";
            this.btnOpenOrderDialog.UseVisualStyleBackColor = true;
            this.btnOpenOrderDialog.Click += new System.EventHandler(this.btnOpenOrderDialog_Click);
            // 
            // btnPayBill
            // 
            this.btnPayBill.Location = new System.Drawing.Point(24, 265);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(286, 30);
            this.btnPayBill.TabIndex = 4;
            this.btnPayBill.Text = "Наплати сметка";
            this.btnPayBill.UseVisualStyleBackColor = true;
            this.btnPayBill.Click += new System.EventHandler(this.btnPayBill_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalAmount.Location = new System.Drawing.Point(214, 231);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(68, 21);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "Вкупно";
            // 
            // lstOrders
            // 
            this.lstOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lstOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOrders.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstOrders.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 30;
            this.lstOrders.Location = new System.Drawing.Point(21, 66);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(290, 156);
            this.lstOrders.TabIndex = 2;
            this.lstOrders.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstOrders_DrawItem);
            this.lstOrders.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstOrders_MeasureItem);
            // 
            // lblSelectedTableStatus
            // 
            this.lblSelectedTableStatus.AutoSize = true;
            this.lblSelectedTableStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTableStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSelectedTableStatus.Location = new System.Drawing.Point(215, 23);
            this.lblSelectedTableStatus.Name = "lblSelectedTableStatus";
            this.lblSelectedTableStatus.Size = new System.Drawing.Size(0, 17);
            this.lblSelectedTableStatus.TabIndex = 1;
            // 
            // lblSelectedTableTitle
            // 
            this.lblSelectedTableTitle.AutoSize = true;
            this.lblSelectedTableTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTableTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSelectedTableTitle.Location = new System.Drawing.Point(20, 19);
            this.lblSelectedTableTitle.Name = "lblSelectedTableTitle";
            this.lblSelectedTableTitle.Size = new System.Drawing.Size(108, 21);
            this.lblSelectedTableTitle.TabIndex = 0;
            this.lblSelectedTableTitle.Text = "Маса број: X";
            // 
            // pnlRightControl
            // 
            this.pnlRightControl.Controls.Add(this.tableLayoutPanel1);
            this.pnlRightControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightControl.Location = new System.Drawing.Point(926, 0);
            this.pnlRightControl.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRightControl.Name = "pnlRightControl";
            this.pnlRightControl.Size = new System.Drawing.Size(350, 731);
            this.pnlRightControl.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlSimulatorCard, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlStatusCard, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlSelectedTableCard, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 731);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlSimulatorCard
            // 
            this.pnlSimulatorCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.pnlSimulatorCard.Controls.Add(this.lbSimulator);
            this.pnlSimulatorCard.Controls.Add(this.btnSimulateBill);
            this.pnlSimulatorCard.Controls.Add(this.cmbSimulatorTables);
            this.pnlSimulatorCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSimulatorCard.Location = new System.Drawing.Point(10, 594);
            this.pnlSimulatorCard.Margin = new System.Windows.Forms.Padding(10);
            this.pnlSimulatorCard.Name = "pnlSimulatorCard";
            this.pnlSimulatorCard.Size = new System.Drawing.Size(330, 127);
            this.pnlSimulatorCard.TabIndex = 2;
            // 
            // lbSimulator
            // 
            this.lbSimulator.AutoSize = true;
            this.lbSimulator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimulator.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbSimulator.Location = new System.Drawing.Point(16, 7);
            this.lbSimulator.Name = "lbSimulator";
            this.lbSimulator.Size = new System.Drawing.Size(114, 25);
            this.lbSimulator.TabIndex = 2;
            this.lbSimulator.Text = "Симулатор";
            // 
            // btnSimulateBill
            // 
            this.btnSimulateBill.Location = new System.Drawing.Point(20, 79);
            this.btnSimulateBill.Name = "btnSimulateBill";
            this.btnSimulateBill.Size = new System.Drawing.Size(289, 30);
            this.btnSimulateBill.TabIndex = 1;
            this.btnSimulateBill.Text = "Побарај сметка";
            this.btnSimulateBill.UseVisualStyleBackColor = true;
            this.btnSimulateBill.Click += new System.EventHandler(this.btnSimulateBill_Click);
            // 
            // cmbSimulatorTables
            // 
            this.cmbSimulatorTables.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.cmbSimulatorTables.FormattingEnabled = true;
            this.cmbSimulatorTables.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.cmbSimulatorTables.Location = new System.Drawing.Point(20, 41);
            this.cmbSimulatorTables.Name = "cmbSimulatorTables";
            this.cmbSimulatorTables.Size = new System.Drawing.Size(290, 21);
            this.cmbSimulatorTables.TabIndex = 0;
            this.cmbSimulatorTables.Text = "Избери маса...";
            // 
            // pnlStatusCard
            // 
            this.pnlStatusCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.pnlStatusCard.Controls.Add(this.lblStatEarnings);
            this.pnlStatusCard.Controls.Add(this.lblStatBillRequested);
            this.pnlStatusCard.Controls.Add(this.lblStatServed);
            this.pnlStatusCard.Controls.Add(this.lblStatWaiting);
            this.pnlStatusCard.Controls.Add(this.lblStatFree);
            this.pnlStatusCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatusCard.Location = new System.Drawing.Point(10, 375);
            this.pnlStatusCard.Margin = new System.Windows.Forms.Padding(10);
            this.pnlStatusCard.Name = "pnlStatusCard";
            this.pnlStatusCard.Size = new System.Drawing.Size(330, 199);
            this.pnlStatusCard.TabIndex = 1;
            // 
            // lblStatEarnings
            // 
            this.lblStatEarnings.AutoSize = true;
            this.lblStatEarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatEarnings.ForeColor = System.Drawing.Color.White;
            this.lblStatEarnings.Location = new System.Drawing.Point(16, 163);
            this.lblStatEarnings.Name = "lblStatEarnings";
            this.lblStatEarnings.Size = new System.Drawing.Size(109, 18);
            this.lblStatEarnings.TabIndex = 4;
            this.lblStatEarnings.Text = "Приход денес:";
            // 
            // lblStatBillRequested
            // 
            this.lblStatBillRequested.AutoSize = true;
            this.lblStatBillRequested.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatBillRequested.ForeColor = System.Drawing.Color.White;
            this.lblStatBillRequested.Location = new System.Drawing.Point(16, 124);
            this.lblStatBillRequested.Name = "lblStatBillRequested";
            this.lblStatBillRequested.Size = new System.Drawing.Size(115, 18);
            this.lblStatBillRequested.TabIndex = 3;
            this.lblStatBillRequested.Text = "Бараат сметка:";
            // 
            // lblStatServed
            // 
            this.lblStatServed.AutoSize = true;
            this.lblStatServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatServed.ForeColor = System.Drawing.Color.White;
            this.lblStatServed.Location = new System.Drawing.Point(16, 87);
            this.lblStatServed.Name = "lblStatServed";
            this.lblStatServed.Size = new System.Drawing.Size(91, 18);
            this.lblStatServed.TabIndex = 2;
            this.lblStatServed.Text = "Опслужени:";
            // 
            // lblStatWaiting
            // 
            this.lblStatWaiting.AutoSize = true;
            this.lblStatWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatWaiting.ForeColor = System.Drawing.Color.White;
            this.lblStatWaiting.Location = new System.Drawing.Point(16, 51);
            this.lblStatWaiting.Name = "lblStatWaiting";
            this.lblStatWaiting.Size = new System.Drawing.Size(87, 18);
            this.lblStatWaiting.TabIndex = 1;
            this.lblStatWaiting.Text = "Во чекање:";
            // 
            // lblStatFree
            // 
            this.lblStatFree.AutoSize = true;
            this.lblStatFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatFree.ForeColor = System.Drawing.Color.White;
            this.lblStatFree.Location = new System.Drawing.Point(16, 17);
            this.lblStatFree.Name = "lblStatFree";
            this.lblStatFree.Size = new System.Drawing.Size(88, 18);
            this.lblStatFree.TabIndex = 0;
            this.lblStatFree.Text = "Слободни: ";
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.pnlLeftMenu.Controls.Add(this.label4);
            this.pnlLeftMenu.Controls.Add(this.cafe);
            this.pnlLeftMenu.Controls.Add(this.lbSubTitle);
            this.pnlLeftMenu.Controls.Add(this.lbTitle);
            this.pnlLeftMenu.Controls.Add(this.btnStatistics);
            this.pnlLeftMenu.Controls.Add(this.btnOpenInventory);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(250, 801);
            this.pnlLeftMenu.TabIndex = 2;
            this.pnlLeftMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeftMenu_Paint);
            // 
            // cafe
            // 
            this.cafe.AutoSize = true;
            this.cafe.BackColor = System.Drawing.Color.Transparent;
            this.cafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafe.ForeColor = System.Drawing.Color.White;
            this.cafe.Location = new System.Drawing.Point(15, 23);
            this.cafe.Name = "cafe";
            this.cafe.Size = new System.Drawing.Size(55, 39);
            this.cafe.TabIndex = 3;
            this.cafe.Text = "☕";
            // 
            // lbSubTitle
            // 
            this.lbSubTitle.AutoSize = true;
            this.lbSubTitle.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbSubTitle.Location = new System.Drawing.Point(17, 97);
            this.lbSubTitle.Name = "lbSubTitle";
            this.lbSubTitle.Size = new System.Drawing.Size(186, 27);
            this.lbSubTitle.TabIndex = 2;
            this.lbSubTitle.Text = "Management System";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(10, 63);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(234, 40);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "CAFE BAR FINKI";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(22, 210);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(214, 23);
            this.btnStatistics.TabIndex = 1;
            this.btnStatistics.Text = "Статистика и Извештаи";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnOpenInventory
            // 
            this.btnOpenInventory.Location = new System.Drawing.Point(18, 167);
            this.btnOpenInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenInventory.Name = "btnOpenInventory";
            this.btnOpenInventory.Size = new System.Drawing.Size(218, 26);
            this.btnOpenInventory.TabIndex = 0;
            this.btnOpenInventory.Text = " Залиха и Набавки";
            this.btnOpenInventory.UseVisualStyleBackColor = true;
            this.btnOpenInventory.Click += new System.EventHandler(this.btnOpenInventory_Click);
            // 
            // pnlHeaderBar
            // 
            this.pnlHeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlHeaderBar.Controls.Add(this.label3);
            this.pnlHeaderBar.Controls.Add(this.cmbWaiter);
            this.pnlHeaderBar.Controls.Add(this.lblLiveTime);
            this.pnlHeaderBar.Controls.Add(this.label1);
            this.pnlHeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderBar.Location = new System.Drawing.Point(250, 0);
            this.pnlHeaderBar.Name = "pnlHeaderBar";
            this.pnlHeaderBar.Size = new System.Drawing.Size(1276, 70);
            this.pnlHeaderBar.TabIndex = 3;
            // 
            // lblLiveTime
            // 
            this.lblLiveTime.AutoSize = true;
            this.lblLiveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiveTime.ForeColor = System.Drawing.Color.White;
            this.lblLiveTime.Location = new System.Drawing.Point(1211, 28);
            this.lblLiveTime.Name = "lblLiveTime";
            this.lblLiveTime.Size = new System.Drawing.Size(41, 18);
            this.lblLiveTime.TabIndex = 2;
            this.lblLiveTime.Text = "Time";
            this.lblLiveTime.Click += new System.EventHandler(this.lblLiveTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Распоред на маси";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.pnlMainContent.Controls.Add(this.pnlFloorHeader);
            this.pnlMainContent.Controls.Add(this.pnlTablesFloor);
            this.pnlMainContent.Controls.Add(this.pnlRightControl);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(250, 70);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1276, 731);
            this.pnlMainContent.TabIndex = 4;
            // 
            // pnlFloorHeader
            // 
            this.pnlFloorHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlFloorHeader.Controls.Add(this.lblStatusBill);
            this.pnlFloorHeader.Controls.Add(this.lblStatusServed);
            this.pnlFloorHeader.Controls.Add(this.lblStatusUnserved);
            this.pnlFloorHeader.Controls.Add(this.lblStatusFree);
            this.pnlFloorHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFloorHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFloorHeader.Name = "pnlFloorHeader";
            this.pnlFloorHeader.Size = new System.Drawing.Size(926, 50);
            this.pnlFloorHeader.TabIndex = 0;
            // 
            // cmbWaiter
            // 
            this.cmbWaiter.BackColor = System.Drawing.Color.Gray;
            this.cmbWaiter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWaiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWaiter.FormattingEnabled = true;
            this.cmbWaiter.Items.AddRange(new object[] {
            "Марко Стојанов",
            "Ана Петкова",
            "Петар Петков"});
            this.cmbWaiter.Location = new System.Drawing.Point(1040, 26);
            this.cmbWaiter.Name = "cmbWaiter";
            this.cmbWaiter.Size = new System.Drawing.Size(150, 21);
            this.cmbWaiter.TabIndex = 5;
            // 
            // lblStatusBill
            // 
            this.lblStatusBill.AutoSize = true;
            this.lblStatusBill.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblStatusBill.Location = new System.Drawing.Point(839, 20);
            this.lblStatusBill.Name = "lblStatusBill";
            this.lblStatusBill.Size = new System.Drawing.Size(82, 13);
            this.lblStatusBill.TabIndex = 3;
            this.lblStatusBill.Text = "● Бара сметка";
            // 
            // lblStatusServed
            // 
            this.lblStatusServed.AutoSize = true;
            this.lblStatusServed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblStatusServed.Location = new System.Drawing.Point(759, 20);
            this.lblStatusServed.Name = "lblStatusServed";
            this.lblStatusServed.Size = new System.Drawing.Size(74, 13);
            this.lblStatusServed.TabIndex = 2;
            this.lblStatusServed.Text = "● Опслужена";
            // 
            // lblStatusUnserved
            // 
            this.lblStatusUnserved.AutoSize = true;
            this.lblStatusUnserved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblStatusUnserved.Location = new System.Drawing.Point(667, 20);
            this.lblStatusUnserved.Name = "lblStatusUnserved";
            this.lblStatusUnserved.Size = new System.Drawing.Size(86, 13);
            this.lblStatusUnserved.TabIndex = 1;
            this.lblStatusUnserved.Text = "● Неопслужена";
            // 
            // lblStatusFree
            // 
            this.lblStatusFree.AutoSize = true;
            this.lblStatusFree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblStatusFree.Location = new System.Drawing.Point(595, 20);
            this.lblStatusFree.Name = "lblStatusFree";
            this.lblStatusFree.Size = new System.Drawing.Size(66, 13);
            this.lblStatusFree.TabIndex = 0;
            this.lblStatusFree.Text = "● Слободна";
            // 
            // pnlTablesFloor
            // 
            this.pnlTablesFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.pnlTablesFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTablesFloor.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlTablesFloor.Location = new System.Drawing.Point(0, 0);
            this.pnlTablesFloor.Name = "pnlTablesFloor";
            this.pnlTablesFloor.Size = new System.Drawing.Size(926, 731);
            this.pnlTablesFloor.TabIndex = 0;
            this.pnlTablesFloor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTablesFloor_Paint_1);
            this.pnlTablesFloor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlTablesFloor_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(145, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Промет:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(956, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Келнер:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(9, 765);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Изработил: Антонио Ристовски";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1526, 801);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlHeaderBar);
            this.Controls.Add(this.pnlLeftMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSelectedTableCard.ResumeLayout(false);
            this.pnlSelectedTableCard.PerformLayout();
            this.pnlRightControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlSimulatorCard.ResumeLayout(false);
            this.pnlSimulatorCard.PerformLayout();
            this.pnlStatusCard.ResumeLayout(false);
            this.pnlStatusCard.PerformLayout();
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlLeftMenu.PerformLayout();
            this.pnlHeaderBar.ResumeLayout(false);
            this.pnlHeaderBar.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlFloorHeader.ResumeLayout(false);
            this.pnlFloorHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSelectedTableCard;
        private System.Windows.Forms.Panel pnlRightControl;
        private System.Windows.Forms.Panel pnlStatusCard;
        private System.Windows.Forms.Panel pnlSimulatorCard;
        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Panel pnlHeaderBar;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlTablesFloor;
        private System.Windows.Forms.Panel pnlFloorHeader;
        private System.Windows.Forms.Label lblStatusFree;
        private System.Windows.Forms.Label lblStatusBill;
        private System.Windows.Forms.Label lblStatusServed;
        private System.Windows.Forms.Label lblStatusUnserved;
        private System.Windows.Forms.Label lblSelectedTableTitle;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Label lblSelectedTableStatus;
        private System.Windows.Forms.Label lblStatFree;
        private System.Windows.Forms.Button btnOpenOrderDialog;
        private System.Windows.Forms.Button btnPayBill;
        private System.Windows.Forms.Label lblStatEarnings;
        private System.Windows.Forms.Label lblStatBillRequested;
        private System.Windows.Forms.Label lblStatServed;
        private System.Windows.Forms.Label lblStatWaiting;
        private System.Windows.Forms.Label lbSimulator;
        private System.Windows.Forms.Button btnSimulateBill;
        private System.Windows.Forms.ComboBox cmbSimulatorTables;
        private System.Windows.Forms.ComboBox cmbWaiter;
        private System.Windows.Forms.Label lblServiceTime;
        private System.Windows.Forms.Button btnOpenInventory;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSubTitle;
        private System.Windows.Forms.Label cafe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLiveTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

