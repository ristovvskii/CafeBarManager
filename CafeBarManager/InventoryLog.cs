using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBarManager
{
    public class InventoryLog
    {
        public string ProductName { get; set; } 
        public int QuantityAdded { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal TotalCost => QuantityAdded * PurchasePrice;
        public DateTime Date { get; set; }

        public InventoryLog(string productName, int quantityAdded, decimal purchasePrice)
        {
            ProductName = productName;
            QuantityAdded = quantityAdded;
            PurchasePrice = purchasePrice;
            Date = DateTime.Now;
        }


        public override string ToString()
        {
            return $"{Date:HH:mm} | {ProductName} (+{QuantityAdded}) - {TotalCost:F2} ден.";
        }

    }
}
