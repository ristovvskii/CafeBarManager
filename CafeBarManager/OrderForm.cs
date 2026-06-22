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
    public partial class OrderForm : Form
    {

        private Table targetTable;
        private List<Product> menuProducts;
        private ProductCategory? selectedCategory = null;
        private string activeWaiter;

        
        private List<OrderItem> temporaryItems = new List<OrderItem>();
        private Product currentlyDisplayedProduct = null;

        public event EventHandler<Table> TableChanged;

        public OrderForm(Table table, string waiterName)
        {
            InitializeComponent();

            this.targetTable = table;
            this.activeWaiter = waiterName;
            this.menuProducts = Product.CreateMenu();

            
            if (targetTable.CurrentOrder == null)
            {
                targetTable.CurrentOrder = new Order(targetTable.TableNumber, activeWaiter);
            }

            
            foreach (var item in targetTable.CurrentOrder.Items)
            {
                temporaryItems.Add(new OrderItem(item.SelectedProduct, item.Quantity));
            }

            DisplayMenuProducts();
            RefreshOrderList();
            UpdateStatusBadge();

            this.Activated += (s, e) => txtSearchCode.Focus();
            
            txtSearchCode.KeyDown += txtSearchCode_Custom_KeyDown;
            txtSearchCode.TextChanged += txtSearchCode_TextChanged;

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            lblOrderTitle.Text = $"Мени — Маса {targetTable.TableNumber} ({activeWaiter})";

        }

        private void DisplayMenuProducts()
        {
            flpMenuProducts.Controls.Clear();
            foreach (Product p in menuProducts)
            {
                if (selectedCategory == null || p.Category == selectedCategory)
                {
                    MenuProductControl productCard = new MenuProductControl(p);
                    productCard.OnAddClicked += ProductCard_OnAddClicked;
                    flpMenuProducts.Controls.Add(productCard);
                }
            }
        }

        private void ProductCard_OnAddClicked(object sender, EventArgs e)
        {
            MenuProductControl clickedCard = (MenuProductControl)sender;
            Product productToAdd = clickedCard.AssociatedProduct;

            
            var existingItem = temporaryItems.FirstOrDefault(i => i.SelectedProduct.ID == productToAdd.ID);
            if (existingItem != null)
            {
                existingItem.Quantity += 1;
            }
            else
            {
                temporaryItems.Add(new OrderItem(productToAdd, 1));
            }

            RefreshOrderList();
        }

        private void RefreshOrderList()
        {

            flpOrderItems.Controls.Clear();

            foreach (OrderItem item in temporaryItems)
            {
                Product prod = item.SelectedProduct;
                int qty = item.Quantity;

                OrderItemControl orderItemCard = new OrderItemControl(prod, qty);

                orderItemCard.OnIncreaseClicked += (s, e) => {
                    item.Quantity += 1;
                    RefreshOrderList();
                };

                orderItemCard.OnDecreaseClicked += (s, e) => {
                    item.Quantity -= 1;
                    if (item.Quantity <= 0)
                    {
                        temporaryItems.Remove(item);
                    }
                    RefreshOrderList();
                };

                flpOrderItems.Controls.Add(orderItemCard);
            }


            decimal tempNet = 0;
            foreach (OrderItem item in temporaryItems)
            {
                tempNet += item.SelectedProduct.Price * item.Quantity;
            }

            
            decimal tempTotal = 0;
            foreach (OrderItem item in temporaryItems)
            {
                tempTotal += item.SelectedProduct.GetPriceWithVAT(0.18m) * item.Quantity;
            }

            
            decimal tempDDV = tempTotal - tempNet;


            lblNetPrice.Text = $"{tempNet:F2} ден";
            lblDDV.Text = $"{tempDDV:F2} ден";
            lblTotalSum.Text = $"{tempTotal:F2} ден";
            lblOrderSubtitle.Text = $"{temporaryItems.Count} артикли во чекање";
        }

        private void btnMainAction_Click(object sender, EventArgs e)
        {
            // Сценарио А: Масата е слободна (Зелена)
            if (targetTable.Status == TableStatus.Free)
            {
                if (temporaryItems.Count == 0)
                {
                    MessageBox.Show("Не можете да пратите празна нарачка во шанк!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CommitTemporaryChanges();
                targetTable.GuestsSeated(activeWaiter); // Станува ЖОЛТА
                CommitAndClose("Нарачката е испратена во шанк! Масата сега свети ЖОЛТО.");
            }
            // Сценарио Б: Масата е во чекање (Жола)
            else if (targetTable.Status == TableStatus.OccupiedUnserved)
            {
                CommitTemporaryChanges();
                targetTable.OrderServed(); // Станува ЦРВЕНА
                CommitAndClose("Нарачката е успешно испорачана! Масата сега е ЦРВЕНА, тајмерот стопира.");
            }
            // Сценарио В: Масата е веќе услужена (Црвена)
            else if (targetTable.Status == TableStatus.OccupiedServed)
            {
                CommitTemporaryChanges();
                targetTable.NewRoundStarted(); // Се враќа во ЖОЛТО за нова рунда
                CommitAndClose("Новата рунда е зачувана и пратена во шанк!");
            }
        }

       
        private void CommitTemporaryChanges()
        {
            if (targetTable.CurrentOrder == null)
            {
                targetTable.CurrentOrder = new Order(targetTable.TableNumber, activeWaiter);
            }

            targetTable.CurrentOrder.Items.Clear();
            foreach (var item in temporaryItems)
            {
                targetTable.CurrentOrder.Items.Add(item);
            }
        }

        private void CommitAndClose(string successMessage)
        {
            TableChanged?.Invoke(this, targetTable);
            UpdateStatusBadge();
            MessageBox.Show(successMessage, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (this.DialogResult != DialogResult.OK)
            {
                
                if (targetTable.Status == TableStatus.Free)
                {
                    targetTable.CurrentOrder = null;
                }
               
            }
        }

        private void UpdateStatusBadge()
        {
            lblStatusBadge.Text = targetTable.Status switch
            {
                TableStatus.Free => "Слободна",
                TableStatus.OccupiedUnserved => "Неопслужена",
                TableStatus.OccupiedServed => "Опслужена",
                _ => "Непознато"
            };

            lblStatusBadge.BackColor = targetTable.Status switch
            {
                TableStatus.Free => Color.DarkGreen,
                TableStatus.OccupiedUnserved => Color.Orange,
                TableStatus.OccupiedServed => Color.Crimson,
                _ => Color.Gray
            };

            if (targetTable.Status == TableStatus.OccupiedUnserved)
            {
                btnMainAction.Text = "Испорачано";
                btnMainAction.BackColor = Color.Crimson;
                btnMainAction.ForeColor = Color.White;
            }
            else if (targetTable.Status == TableStatus.Free)
            {
                btnMainAction.Text = "Зачувај и прати во шанк";
                btnMainAction.BackColor = Color.DodgerBlue;
                btnMainAction.ForeColor = Color.White;
            }
            else
            {
                btnMainAction.Text = "Зачувај промени";
                btnMainAction.BackColor = Color.LightGray;
                btnMainAction.ForeColor = Color.Black;
            }

            btnMainAction.Enabled = true;
        }

        private void btnCatAll_Click(object sender, EventArgs e)
        {
            selectedCategory = null;
            DisplayMenuProducts();
        }

        private void btnCatCoffee_Click(object sender, EventArgs e)
        {
            selectedCategory = ProductCategory.Coffee;
            DisplayMenuProducts();
        }

        private void btnCatJuices_Click(object sender, EventArgs e)
        {
            selectedCategory = ProductCategory.Juices;
            DisplayMenuProducts();
        }

        private void btnCatWater_Click(object sender, EventArgs e)
        {
            selectedCategory = ProductCategory.Water;
            DisplayMenuProducts();
        }

        private void btnCatAlcohol_Click(object sender, EventArgs e)
        {
            selectedCategory = ProductCategory.Alcohol;
            DisplayMenuProducts();
        }

        private void btnCatDesserts_Click(object sender, EventArgs e)
        {
            selectedCategory = ProductCategory.Desserts;
            DisplayMenuProducts();
        }

        private void btnMarkServed_Click(object sender, EventArgs e)
        {
            if (targetTable.Status != TableStatus.OccupiedUnserved) return;
            targetTable.OrderServed();
            UpdateStatusBadge();
            CommitAndClose("Нарачката е означена како опслужена.");
        }

        private void btnPay_Click(object sender, EventArgs e) 
        {


            if (targetTable.Status == TableStatus.OccupiedUnserved)
            {
                MessageBox.Show("Не можете да издадете сметка за неопслужена маса! Прво кликнете 'Испорачано'.",
                                "Предупредување", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            using (ReceiptForm receiptForm = new ReceiptForm(targetTable))
            {
                DialogResult result = receiptForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    targetTable.Status = TableStatus.Free;
                    targetTable.IsRequestingBill = false;
                    targetTable.CurrentOrder = null; 

                    this.DialogResult = DialogResult.OK;
                    this.Close(); 
                }
            }
        }


     
        

        
        private void txtSearchCode_KeyDown_1(object sender, KeyEventArgs e) { }


        private void txtSearchCode_Custom_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true; 

            string inputCode = txtSearchCode.Text.Trim();

           
            if (string.IsNullOrWhiteSpace(inputCode) || inputCode == "Внеси шифра...")
            {
                currentlyDisplayedProduct = null;
                selectedCategory = null; 
                DisplayMenuProducts();
                return;
            }

            Product foundProduct = menuProducts
                .FirstOrDefault(p => p.ID.ToString() == inputCode);

            if (foundProduct == null)
            {
                MessageBox.Show(
                    $"Не постои производ со шифра '{inputCode}'!",
                    "Грешка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSearchCode.SelectAll();
                txtSearchCode.Focus();
                return;
            }

            
            // Вториот Enter 
            if (currentlyDisplayedProduct != null && currentlyDisplayedProduct.ID == foundProduct.ID)
            {
                var existingItem = temporaryItems
                    .FirstOrDefault(i => i.SelectedProduct.ID == foundProduct.ID);

                if (existingItem != null)
                {
                    existingItem.Quantity++;
                }
                else
                {
                    temporaryItems.Add(new OrderItem(foundProduct, 1));
                }

                RefreshOrderList();

               
                currentlyDisplayedProduct = null;
                DisplayMenuProducts();


                txtSearchCode.SelectAll();
                txtSearchCode.Focus();


                return;
            }

            // Прв Enter
            currentlyDisplayedProduct = foundProduct;

            flpMenuProducts.Controls.Clear();

            MenuProductControl card = new MenuProductControl(foundProduct);
            card.OnAddClicked += ProductCard_OnAddClicked;

            flpMenuProducts.Controls.Add(card);

            txtSearchCode.SelectAll();
            txtSearchCode.Focus();
        }

        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
 