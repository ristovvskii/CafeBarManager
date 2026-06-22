using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBarManager
{
    public class OrderItem
    {
        public Product SelectedProduct { get; private set; }
        public int Quantity { get; set; }
        public OrderItem() { }
        public OrderItem(Product product, int quantity)
        {
            this.SelectedProduct = product ?? throw new ArgumentNullException(nameof(product));
            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Количината мора да е најмалце 1.");
            this.Quantity = quantity;
        }
        
        public decimal SubTotal => SelectedProduct.Price * Quantity;
        public decimal SubTotalWithDDV => SelectedProduct.GetPriceWithVAT() * Quantity;


        public override string ToString()
        {
            return $"{SelectedProduct.Name} x{Quantity} = {SubTotalWithDDV:F2} ден.";
        }
    }
}
