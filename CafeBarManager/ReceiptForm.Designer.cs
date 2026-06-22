namespace CafeBarManager
{
    partial class ReceiptForm
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
            this.rtbReceiptView = new System.Windows.Forms.RichTextBox();
            this.gbPaymentMethod = new System.Windows.Forms.GroupBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.gbRecentReceipts = new System.Windows.Forms.GroupBox();
            this.btnFinishPayment = new System.Windows.Forms.Button();
            this.lstRecentReceipts = new System.Windows.Forms.ListBox();
            this.gbPaymentMethod.SuspendLayout();
            this.gbRecentReceipts.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbReceiptView
            // 
            this.rtbReceiptView.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbReceiptView.Location = new System.Drawing.Point(0, 0);
            this.rtbReceiptView.Name = "rtbReceiptView";
            this.rtbReceiptView.Size = new System.Drawing.Size(350, 450);
            this.rtbReceiptView.TabIndex = 0;
            this.rtbReceiptView.Text = "";
            // 
            // gbPaymentMethod
            // 
            this.gbPaymentMethod.Controls.Add(this.btnFinishPayment);
            this.gbPaymentMethod.Controls.Add(this.btnCard);
            this.gbPaymentMethod.Controls.Add(this.btnCash);
            this.gbPaymentMethod.Location = new System.Drawing.Point(356, 12);
            this.gbPaymentMethod.Name = "gbPaymentMethod";
            this.gbPaymentMethod.Size = new System.Drawing.Size(432, 88);
            this.gbPaymentMethod.TabIndex = 1;
            this.gbPaymentMethod.TabStop = false;
            this.gbPaymentMethod.Text = "Начин на плаќање";
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(15, 46);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(115, 23);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "Готовина";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(145, 46);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(105, 23);
            this.btnCard.TabIndex = 1;
            this.btnCard.Text = "Картичка";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // gbRecentReceipts
            // 
            this.gbRecentReceipts.Controls.Add(this.lstRecentReceipts);
            this.gbRecentReceipts.Location = new System.Drawing.Point(356, 116);
            this.gbRecentReceipts.Name = "gbRecentReceipts";
            this.gbRecentReceipts.Size = new System.Drawing.Size(432, 322);
            this.gbRecentReceipts.TabIndex = 2;
            this.gbRecentReceipts.TabStop = false;
            this.gbRecentReceipts.Text = "Последни сметки — денес";
            // 
            // btnFinishPayment
            // 
            this.btnFinishPayment.Enabled = false;
            this.btnFinishPayment.Location = new System.Drawing.Point(279, 46);
            this.btnFinishPayment.Name = "btnFinishPayment";
            this.btnFinishPayment.Size = new System.Drawing.Size(133, 23);
            this.btnFinishPayment.TabIndex = 2;
            this.btnFinishPayment.Text = "Заврши наплата";
            this.btnFinishPayment.UseVisualStyleBackColor = true;
            this.btnFinishPayment.Click += new System.EventHandler(this.btnFinishPayment_Click);
            // 
            // lstRecentReceipts
            // 
            this.lstRecentReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRecentReceipts.FormattingEnabled = true;
            this.lstRecentReceipts.Location = new System.Drawing.Point(3, 16);
            this.lstRecentReceipts.Name = "lstRecentReceipts";
            this.lstRecentReceipts.Size = new System.Drawing.Size(426, 303);
            this.lstRecentReceipts.TabIndex = 0;
            this.lstRecentReceipts.SelectedIndexChanged += new System.EventHandler(this.lstRecentReceipts_SelectedIndexChanged);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRecentReceipts);
            this.Controls.Add(this.gbPaymentMethod);
            this.Controls.Add(this.rtbReceiptView);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.gbPaymentMethod.ResumeLayout(false);
            this.gbRecentReceipts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbReceiptView;
        private System.Windows.Forms.GroupBox gbPaymentMethod;
        private System.Windows.Forms.Button btnFinishPayment;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.GroupBox gbRecentReceipts;
        private System.Windows.Forms.ListBox lstRecentReceipts;
    }
}