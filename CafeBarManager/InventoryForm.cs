using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBarManager
{
    public partial class InventoryForm : Form
    {

        private List<Product> _products;

        private List<InventoryLog> _purchaseLogs = new List<InventoryLog>();

        public InventoryForm(List<Product> products)
        {
            InitializeComponent();

            this._products = products;

            

            this.Size = new Size(1200, 700);
            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
            this.MaximizeBox = false;                          

            this.StartPosition = FormStartPosition.CenterParent;

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

            PopulateProductComboBox();

            cmbProducts.SelectedIndexChanged += (s, ev) => UpdateLivePreview();
            numQuantity.ValueChanged += (s, ev) => UpdateLivePreview();
            numPricePerUnit.ValueChanged += (s, ev) => UpdateLivePreview();

            // Прво пресликување на екранот
            RefreshInventoryUI();

        }


        private void PopulateProductComboBox()
        {
            cmbProducts.DataSource = null;
            cmbProducts.DataSource = _products;
            cmbProducts.DisplayMember = "Name";
        }

        private void RefreshInventoryUI()
        {
            CalculateTopCards();
            RenderStockList();
            UpdateLivePreview();
        }

        // 1. Пополнување на горните 4 картички од твоето мени
        private void CalculateTopCards()
        {
            int totalItems = _products.Count;
            int stableCount = _products.Count(p => p.StockStatus == "Стабилно");
            int warningCount = _products.Count(p => p.StockStatus == "Предупредување");
            int criticalCount = _products.Count(p => p.StockStatus == "Критично ниско");

            // ПРОКЕНТИРАЈ ГИ ОВИЕ ИМИЊА СО ИМЕЊАТА НА ТВОИТЕ ЛАБЕЛИ ОД КАРТИЧКИТЕ ВО ДИЗАЈНЕРОТ:
            // Пример: ако лабелата во првата картичка ти се вика lblTotalCount, смени ја тука
            lblTotalItemsCount.Text = totalItems.ToString();
            lblStableCount.Text = stableCount.ToString();
            lblWarningCount.Text = warningCount.ToString();
            lblCriticalCount.Text = criticalCount.ToString();
        }

        // 2. ДИНАМИЧКО ЦРТАЊЕ НА ЛИСТАТА И „LOADING“ ЦРТИТЕ
        private void RenderStockList()
        {
            // flpStockList е името на твојот FlowLayoutPanel лево
            //flpStockList.Controls.Clear();
            //flpStockList.SuspendLayout();

            //foreach (var prod in _products)
            //{
            //    // Главен контејнер за еден ред (картичка за еден производ)
            //    Panel rowPanel = new Panel();
            //    rowPanel.Size = new Size(flpStockList.Width - 25, 55);
            //    rowPanel.BackColor = Color.FromArgb(37, 42, 59); // Посветла темно-сива
            //    rowPanel.Margin = new Padding(0, 0, 0, 6);

            //    // А) Мало индикаторче за бојата на категоријата најлево
            //    Panel categoryColorIcon = new Panel();
            //    categoryColorIcon.Size = new Size(10, 10);
            //    categoryColorIcon.Location = new Point(15, 22);
            //    categoryColorIcon.BackColor = Product.GetCategoryColor(prod.Category);
            //    rowPanel.Controls.Add(categoryColorIcon);

            //    // Б) Име на производ и категорија под него
            //    Label lblName = new Label();
            //    lblName.Text = prod.Name;
            //    lblName.ForeColor = Color.White;
            //    lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            //    lblName.Location = new Point(35, 10);
            //    lblName.AutoSize = true;
            //    rowPanel.Controls.Add(lblName);

            //    Label lblCategory = new Label();
            //    lblCategory.Text = prod.Category.ToString();
            //    lblCategory.ForeColor = Color.Gray;
            //    lblCategory.Font = new Font("Segoe UI", 8);
            //    lblCategory.Location = new Point(35, 30);
            //    lblCategory.AutoSize = true;
            //    rowPanel.Controls.Add(lblCategory);

            //    // В) ТРИК СO ДВА ПАНЕЛИ ЗА LOADING ЦРТАТА
            //    Panel barBackground = new Panel();
            //    barBackground.Size = new Size(120, 6);
            //    barBackground.Location = new Point(200, 25);
            //    barBackground.BackColor = Color.FromArgb(55, 62, 87); // Темна позадина на линијата
            //    rowPanel.Controls.Add(barBackground);

            //    Panel barForeground = new Panel();
            //    barForeground.Height = 6;
            //    barForeground.Location = new Point(0, 0);

            //    // Одредуваме боја според статусот
            //    Color statusColor = Color.FromArgb(46, 204, 113); // Зелена (Стабилно)
            //    if (prod.StockStatus == "Предупредување") statusColor = Color.FromArgb(241, 196, 15); // Жолта
            //    else if (prod.StockStatus == "Критично ниско") statusColor = Color.FromArgb(231, 76, 60); // Црвена

            //    barForeground.BackColor = statusColor;

            //    // Пресметка на исполнетост во однос на капацитет од 300 парчиња макс
            //    double fillPercent = Math.Min((double)prod.Stock / 300.0, 1.0);
            //    barForeground.Width = (int)(barBackground.Width * fillPercent);
            //    barBackground.Controls.Add(barForeground);

            //    // Г) Моментална залиха текстуално
            //    Label lblCurrentStock = new Label();
            //    lblCurrentStock.Text = $"{prod.Stock} {prod.Unit}";
            //    lblCurrentStock.ForeColor = Color.White;
            //    lblCurrentStock.Font = new Font("Segoe UI", 9);
            //    lblCurrentStock.Location = new Point(340, 20);
            //    lblCurrentStock.AutoSize = true;
            //    rowPanel.Controls.Add(lblCurrentStock);

            //    // Д) Минимум лимит
            //    Label lblMinStock = new Label();
            //    lblMinStock.Text = $"{prod.MinStock} {prod.Unit}";
            //    lblMinStock.ForeColor = Color.DarkGray;
            //    lblMinStock.Font = new Font("Segoe UI", 9);
            //    lblMinStock.Location = new Point(450, 20);
            //    lblMinStock.AutoSize = true;
            //    rowPanel.Controls.Add(lblMinStock);

            //    // Ѓ) Статус Беџ со соодветна боја
            //    Label lblStatusBadge = new Label();
            //    lblStatusBadge.Text = $"• {prod.StockStatus}";
            //    lblStatusBadge.ForeColor = statusColor;
            //    lblStatusBadge.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            //    lblStatusBadge.Location = new Point(540, 20);
            //    lblStatusBadge.AutoSize = true;
            //    rowPanel.Controls.Add(lblStatusBadge);

            //    // Го додаваме целиот изрендер за овој производ во листата
            //    flpStockList.Controls.Add(rowPanel);
            //}

            //flpStockList.ResumeLayout();

            flpStockList.Controls.Clear();
            flpStockList.SuspendLayout();

            foreach (var prod in _products)
            {
                // Главен контејнер за еден ред - НАМАЛЕНА ВИСИНА НА 46
                Panel rowPanel = new Panel();
                rowPanel.Size = new Size(flpStockList.Width - 25, 46);
                rowPanel.BackColor = Color.FromArgb(37, 42, 59);
                rowPanel.Margin = new Padding(0, 0, 0, 5); // Малку потесно растојание меѓу нив

                // А) Индикатор за боја на категорија (центриран по висина)
                Panel categoryColorIcon = new Panel();
                categoryColorIcon.Size = new Size(10, 10);
                categoryColorIcon.Location = new Point(15, 18);
                categoryColorIcon.BackColor = Product.GetCategoryColor(prod.Category);
                rowPanel.Controls.Add(categoryColorIcon);

                // Б) Име на производ
                Label lblName = new Label();
                lblName.Text = prod.Name;
                lblName.ForeColor = Color.White;
                lblName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                lblName.Location = new Point(35, 6); // Подигнато погоре
                lblName.AutoSize = true;
                rowPanel.Controls.Add(lblName);

                // Категорија под името
                Label lblCategory = new Label();
                lblCategory.Text = prod.Category.ToString();
                lblCategory.ForeColor = Color.Gray;
                lblCategory.Font = new Font("Segoe UI", 7.5F);
                lblCategory.Location = new Point(35, 25); // Подигнато погоре
                rowPanel.Controls.Add(lblCategory);

                // В) Прогрес бар за залиха (центриран по висина)
                Panel barBackground = new Panel();
                barBackground.Size = new Size(120, 6);
                barBackground.Location = new Point(200, 20);
                barBackground.BackColor = Color.FromArgb(55, 62, 87);
                rowPanel.Controls.Add(barBackground);

                Panel barForeground = new Panel();
                barForeground.Height = 6;
                barForeground.Location = new Point(0, 0);

                Color statusColor = Color.FromArgb(46, 204, 113); // Зелена
                if (prod.StockStatus == "Предупредување") statusColor = Color.FromArgb(241, 196, 15);
                else if (prod.StockStatus == "Критично ниско") statusColor = Color.FromArgb(231, 76, 60);

                barForeground.BackColor = statusColor;

                double fillPercent = Math.Min((double)prod.Stock / 300.0, 1.0);
                barForeground.Width = (int)(barBackground.Width * fillPercent);
                barBackground.Controls.Add(barForeground);

                // Г) Моментална залиха - порамнета на X: 360
                Label lblCurrentStock = new Label();
                lblCurrentStock.Text = $"{prod.Stock} {prod.Unit}";
                lblCurrentStock.ForeColor = Color.White;
                lblCurrentStock.Font = new Font("Segoe UI", 9);
                lblCurrentStock.Location = new Point(360, 14);
                lblCurrentStock.AutoSize = true;
                rowPanel.Controls.Add(lblCurrentStock);

                // Д) Минимум лимит - порамнет на X: 450
                Label lblMinStock = new Label();
                lblMinStock.Text = $"{prod.MinStock} {prod.Unit}";
                lblMinStock.ForeColor = Color.DarkGray;
                lblMinStock.Font = new Font("Segoe UI", 9);
                lblMinStock.Location = new Point(450, 14);
                lblMinStock.AutoSize = true;
                rowPanel.Controls.Add(lblMinStock);

                // Ѓ) Статус Беџ - порамнет на X: 540
                Label lblStatusBadge = new Label();
                lblStatusBadge.Text = $"• {prod.StockStatus}";
                lblStatusBadge.ForeColor = statusColor;
                lblStatusBadge.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblStatusBadge.Location = new Point(540, 14);
                lblStatusBadge.AutoSize = true;
                rowPanel.Controls.Add(lblStatusBadge);

                flpStockList.Controls.Add(rowPanel);
            }

            flpStockList.ResumeLayout();
        }

        // 3. ПРЕСМЕТКА ВО РЕАЛНО ВРЕМЕ НА ДЕСНИОТ ПАНЕЛ
        private void UpdateLivePreview()
        {
            if (cmbProducts.SelectedItem is Product selectedProduct)
            {
                // Поставување на почетна цена во набавната цена на самиот производ ако корисникот нема внесено ништо
                if (numPricePerUnit.Value == 0)
                {
                    numPricePerUnit.Value = selectedProduct.PurchasePrice;
                }

                int quantityToAdd = (int)numQuantity.Value;
                int newTotalStock = selectedProduct.Stock + quantityToAdd;
                decimal totalPrice = quantityToAdd * numPricePerUnit.Value;

                // Освежување на математичкиот блок на десниот панел
                lblCurrentStockPreview.Text = $"{selectedProduct.Stock} {selectedProduct.Unit}";
                lblAddedStockPreview.Text = $"+{quantityToAdd} {selectedProduct.Unit}";
                lblNewTotalStockPreview.Text = $"{newTotalStock} {selectedProduct.Unit}";

                lblTotalPurchasePrice.Text = $"{totalPrice:F2} ден.";
            }
        }

        private void btnSavePurchase_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is Product selectedProduct)
            {
                int quantityToAdd = (int)numQuantity.Value;

                if (quantityToAdd <= 0)
                {
                    MessageBox.Show("Внесете количина поголема од 0 за да направите набавка.", "Информација", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Ажурирање на залихата и набавната цена директно во објектот од твојата листа!
                selectedProduct.Stock += quantityToAdd;
                selectedProduct.PurchasePrice = numPricePerUnit.Value;

                // Креирање лог и полнење на долниот ListBox
                InventoryLog log = new InventoryLog(selectedProduct.Name, quantityToAdd, selectedProduct.PurchasePrice);
                _purchaseLogs.Insert(0, log); // Најновата оди најгоре

                lstRecentPurchases.DataSource = null;
                lstRecentPurchases.DataSource = _purchaseLogs;

                // Ресетирање на полињата за внес
                numQuantity.Value = 0;

                // Комплетно инстант ажурирање на целата форма!
                RefreshInventoryUI();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
