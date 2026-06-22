using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeBarManager
{
    public class Order
    {
        public List<OrderItem> Items { get; set; }
        public string OrderId { get; set; }
        public int TableNumber { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? PaymentTime { get; set; }
        public bool IsPaid { get; set; }

        public string WaiterName { get; set; }


        public Order() 
        {
            this.Items = new List<OrderItem>();
        }

        public Order(int tableNumber, string waiterName)
        {
            this.Items = new List<OrderItem>();
            this.OrderId = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            this.TableNumber = tableNumber;
            this.WaiterName = waiterName;
            this.CreationTime = DateTime.Now;
            this.IsPaid = false;
        }

        public void AddProduct(Product product, int quantity)
        {
            bool found = false;

            
            foreach (OrderItem item in this.Items)
            {
                if (item.SelectedProduct.ID == product.ID)
                {
                    item.Quantity += quantity;
                    found = true;
                    break;
                }
            }

            
            if (found == false)
            {
                OrderItem newItem = new OrderItem(product, quantity);
                this.Items.Add(newItem);
            }

            
            product.RegisterSale(quantity);
        }

        
        public decimal TotalNet
        {
            get
            {
                decimal sum = 0.0m;
                foreach (OrderItem item in this.Items)
                {
                    sum += item.SubTotal;
                }
                return sum;
            }
        }

       
        public decimal TotalDDV
        {
            get
            {
                decimal sum = 0.0m;
                foreach (OrderItem item in this.Items)
                {
                   
                    decimal ddvForLine = item.SelectedProduct.CalculateDDV() * item.Quantity;
                    sum += ddvForLine;
                }
                return sum;
            }
        }

        
        public decimal TotalWithDDV
        {
            get
            {
                decimal sum = 0.0m;
                foreach (OrderItem item in this.Items)
                {
                    sum += item.SubTotalWithDDV;
                }
                return sum;
            }
        }

        
        public void CompletePayment()
        {
            this.IsPaid = true;
            this.PaymentTime = DateTime.Now;
        }

        public string GenerateReceipt(int tableID)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=========================================");
            sb.AppendLine("             CAFE-BAR FINKI           ");
            sb.AppendLine("=========================================");
            sb.AppendLine($"Date/Time: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
            sb.AppendLine($"Table:     # {this.TableNumber}");
            sb.AppendLine($"Waiter:    {this.WaiterName}"); 
            sb.AppendLine($"Order ID:  {this.OrderId}");
            sb.AppendLine("-----------------------------------------");

            foreach (var item in Items)
            {
                string name = item.SelectedProduct.Name.PadRight(22);
                string qty = $"{item.Quantity}x".PadRight(5);
                string price = $"{item.SubTotalWithDDV:F2} den.";
                sb.AppendLine($"{name} {qty} {price}");
            }

            sb.AppendLine("-----------------------------------------");
            sb.AppendLine($"Net Total:        {TotalNet:F2} den.");
            sb.AppendLine($"DDV (18%):        {TotalDDV:F2} den.");
            sb.AppendLine("=========================================");
            sb.AppendLine($"TOTAL TO PAY:     {TotalWithDDV:F2} den.");
            sb.AppendLine("=========================================");
            sb.AppendLine("       Thank you for your visit!         ");
            return sb.ToString();
        }
    }
}

