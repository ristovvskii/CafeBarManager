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
    public partial class OrderItemControl : UserControl
    {

        public Product AssociatedProduct { get; set; }
        public int Quantity { get; set; }

        public event EventHandler OnIncreaseClicked;
        public event EventHandler OnDecreaseClicked;

        public OrderItemControl(Product product, int quantity)
        {
            InitializeComponent();

            this.AssociatedProduct = product ?? throw new ArgumentNullException(nameof(product));
            this.Quantity = quantity;

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            lblItemName.Text = AssociatedProduct.Name;
            lblQuantity.Text = Quantity.ToString();

            decimal total = AssociatedProduct.Price * Quantity;
            lblTotalPrice.Text = $"{total:F2} ден";
        }

        public void UpdateQuantity(int newQuantity)
        {
            this.Quantity = newQuantity;
            UpdateLabels();
        }

        private void OrderItemControl_Load(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OnDecreaseClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            OnIncreaseClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
