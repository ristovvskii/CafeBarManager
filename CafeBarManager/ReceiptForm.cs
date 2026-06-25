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

namespace CafeBarManager
{
    public partial class ReceiptForm : Form
    {

        private Table targetTable;
        private Order currentOrder;
        private string selectedPaymentMethod = "";
        public ReceiptForm(Table table)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.targetTable = table;
            this.currentOrder = table.CurrentOrder;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            if(currentOrder == null)
            {
                MessageBox.Show("Нема активна нарачка за оваа маса!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            rtbReceiptView.Text = currentOrder.GenerateReceipt(targetTable.TableNumber);
            rtbReceiptView.Font = new Font("Courier New", 10, FontStyle.Bold);
            rtbReceiptView.ReadOnly = true;


            btnFinishPayment.Enabled = false;

            LoadRecentReceipts();
        }

        private void LoadRecentReceipts()
        {
            lstRecentReceipts.Items.Clear();

            string folderPath = Path.Combine(Application.StartupPath, "Smetki");

            if (Directory.Exists(folderPath))
            {
                FileInfo[] files = new DirectoryInfo(folderPath).GetFiles("*.txt");

               
                Array.Sort(files, (x, y) => y.CreationTime.CompareTo(x.CreationTime));

                
                int countToDisplay = Math.Min(files.Length, 10);
                
                for (int i = 0; i < countToDisplay; i++)
                {
                    
                    string nameWithoutExt = files[i].Name.Replace(".txt", "");
                    string[] parts = nameWithoutExt.Split('_');

                    if (parts.Length >= 6)
                    {
                        string orderId = parts[1];
                        string tableNum = parts[3];
                        string totalSum = parts[5];

                        string displayName = $"#{orderId} • Маса {tableNum} ➔ {totalSum}.00 ден.";
                        lstRecentReceipts.Items.Add(displayName);
                    }
                    else
                    {
                        // Стара верзија на фајл (за секој случај)
                        string displayName = files[i].Name.Replace("Smetka_", "#").Replace(".txt", "").Replace("_Masa_", " • Маса ");
                        lstRecentReceipts.Items.Add(displayName);
                    }
                }
            }

            if (lstRecentReceipts.Items.Count == 0)
            {
                lstRecentReceipts.Items.Add("Нема претходни сметки за денес.");
            }

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            selectedPaymentMethod = "Готовина";

            btnCash.BackColor = Color.FromArgb(46, 204, 113); 
            btnCash.ForeColor = Color.White;
            btnCard.BackColor = SystemColors.Control;
            btnCard.ForeColor = SystemColors.ControlText;

            
            btnFinishPayment.Enabled = true;
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            selectedPaymentMethod = "Картичка";

            
            btnCard.BackColor = Color.FromArgb(52, 152, 219); 
            btnCard.ForeColor = Color.White;
            btnCash.BackColor = SystemColors.Control;
            btnCash.ForeColor = SystemColors.ControlText;

            
            btnFinishPayment.Enabled = true;
        }

        private void btnFinishPayment_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = Path.Combine(Application.StartupPath, "Smetki");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Го користиме OrderId од твојата класа за име на фајлот
                string fileName = $"Smetka_{currentOrder.OrderId}_Masa_{targetTable.TableNumber}_Cena_{currentOrder.TotalWithDDV:F0}.txt";
                string fullPath = Path.Combine(folderPath, fileName);

                // Додаваме метод на плаќање на крајот на сметката
                StringBuilder finalReceiptText = new StringBuilder();
                finalReceiptText.AppendLine(rtbReceiptView.Text);
                finalReceiptText.AppendLine($"НАЧИН НА ПЛАЌАЊЕ: {selectedPaymentMethod}");
                finalReceiptText.AppendLine("=========================================");

                // Зачувување во .txt фајл
                File.WriteAllText(fullPath, finalReceiptText.ToString(), Encoding.UTF8);

                MessageBox.Show($"Сметката е успешно испечатена во:\n{fileName}", "Успешна наплата", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Грешка при запис: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstRecentReceipts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRecentReceipts.SelectedIndex == -1) return;

            string selectedText = lstRecentReceipts.SelectedItem.ToString();

            
            if (selectedText.Contains("Нема претходни")) return;

            try
            {
                
                string orderId = selectedText.Split('•')[0].Replace("#", "").Trim();

                string folderPath = Path.Combine(Application.StartupPath, "Smetki");
                if (Directory.Exists(folderPath))
                {
                   
                    string[] matchingFiles = Directory.GetFiles(folderPath, $"*{orderId}*.txt");

                    if (matchingFiles.Length > 0)
                    {
                        
                        rtbReceiptView.Text = File.ReadAllText(matchingFiles[0], Encoding.UTF8);

                        
                        btnFinishPayment.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при вчитување на старата сметка: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

