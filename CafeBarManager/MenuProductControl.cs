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
    public partial class MenuProductControl : UserControl  
    {

        public Product AssociatedProduct {  get; private set; }

        public event EventHandler OnAddClicked;
        public MenuProductControl(Product product)
        {
            InitializeComponent();

            this.AssociatedProduct = product ?? throw new ArgumentNullException(nameof(product));
            PopulateControlData();
        }


        private void PopulateControlData()
        {
            lblProductName.Text = AssociatedProduct.Name;

            lblProductCategory.Text = GetMacedonianCategoryName(AssociatedProduct.Category);

            lblProductPrice.Text = $"{AssociatedProduct.Price:F2} ден";
        }

        private string GetMacedonianCategoryName(ProductCategory category)
        {
            switch (category)
            {
                case ProductCategory.Coffee: return "Кафиња";
                case ProductCategory.Juices: return "Сокови";
                case ProductCategory.Water: return "Вода";
                case ProductCategory.Alcohol: return "Алкохол";
                case ProductCategory.Desserts: return "Десерти";
                default: return category.ToString();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            OnAddClicked?.Invoke(this, EventArgs.Empty);
        }

        private void MenuProductControl_Load(object sender, EventArgs e)
        {

        }
    }
}
