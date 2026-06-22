using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBarManager
{

    public enum ProductCategory
    {
        Coffee = 0,
        Juices = 1,
        Water = 2,
        Alcohol = 3,
        Desserts = 4
    }
    public class Product
    {
        private string _name;
        private decimal _price;
        private int _stock;
        private decimal _purchasePrice;
        public string ID { get; private set; }
        public ProductCategory Category { get; set; }

        public int DailySalesCount { get; private set; }
        public int TotalSalesCount { get; private set; }

        public int MinStock { get; set; }

        

        public Product(string id, string name, decimal price, decimal purchasePrice, ProductCategory category, int stock = 99, int minStock = 30)
        {
            if(string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Product ID cannot be empty.", nameof(id));

            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be positive.");

            this.ID = id;
            this._name = name ?? throw new ArgumentNullException(nameof(name));
            this._price = price;
            this.Category = category;
            this._stock = stock;
            this._purchasePrice = purchasePrice;
            this.MinStock = minStock;

            this.DailySalesCount = 0;
            this.TotalSalesCount = 0;

        }


        public string Name
        {
            get => _name;
            set => _name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Product name cannot be empty.");
        }

        public decimal Price
        {
            get => _price;
            set => _price = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(Price), "Price must be positive.");
        }

        public int Stock
        {
            get => _stock;
            set => _stock = value >= 0 ? value : 0;
        }


        public decimal PurchasePrice
        {
            get => _purchasePrice;
            set => _purchasePrice = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(PurchasePrice), "Purchase price must be positive.");
        }


        public string Unit => Category == ProductCategory.Coffee ? "шол." : "ком.";

        public string StockStatus
        {
            get
            {
                
                if (_stock <= MinStock * 0.3)
                    return "Критично ниско";

                
                if (_stock <= MinStock)
                    return "Предупредување";

                
                return "Стабилно";
            }
        }


        public decimal CalculateDDV(decimal rate = 0.18m) => Math.Round(_price * rate, 2);

        public decimal GetPriceWithVAT(decimal rate = 0.18m) => Math.Round(_price * (1 + rate), 2);

        public void ResetDailySales() => DailySalesCount = 0;


        public void RegisterSale(int quantity = 1)
        {
            if (quantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be greater than zero.");
            if (_stock < quantity)
                throw new InvalidOperationException($"Insufficient stock for '{_name}'. Available: {_stock}.");

            _stock -= quantity;
            DailySalesCount += quantity;
            TotalSalesCount += quantity;
        }


        public override string ToString() => $"[{Category}] {_name} – {_price:F2} ден.";

        public static List<Product> CreateMenu()
        {
            return new List<Product>
            {
                // -- COFFEE
                new Product("1", "Еспресо",            60m,  15m,  ProductCategory.Coffee,   180, 40),
                new Product("2", "Двоен Еспресо",      90m,  25m,  ProductCategory.Coffee,   200, 40),
                // КРИТИЧНО НИСКО (Залиха: 5, Минимум: 30 -> 5 е помалку од 30 * 0.3 = 9)
                new Product("3", "Капучино",           110m, 30m,  ProductCategory.Coffee,   5,   30),
                new Product("4", "Кафе Лате",          120m, 35m,  ProductCategory.Coffee,   150, 30),
                new Product("5", "Американо",          80m,  20m,  ProductCategory.Coffee,   150, 30),
                new Product("6", "Мокачино",           130m, 40m,  ProductCategory.Coffee,   100, 25),
                new Product("7", "Турско Кафе",        70m,  12m,  ProductCategory.Coffee,   200, 40),

                // -- JUICES
                new Product("10", "Портокал (цеден)",   150m, 50m,  ProductCategory.Juices,   45,  20),
                // ПРЕДУПРЕДУВАЊЕ (Залиха: 18, Минимум: 20 -> под минимумот е, ама над критичната граница 6)
                new Product("11", "Лимонада",           130m, 30m,  ProductCategory.Juices,   18,  20),
                new Product("12", "Коктел Тропик",      180m, 60m,  ProductCategory.Juices,   60,  15),
                new Product("13", "Густ Сок",           120m, 45m,  ProductCategory.Juices,   100, 25),
                new Product("14", "Ледено Кафе",        160m, 40m,  ProductCategory.Juices,   100, 25),
                new Product("15", "Фрапе",              140m, 35m,  ProductCategory.Juices,   100, 25),

                // -- WATER
                new Product("20", "Вода (0.5л)",        50m,  15m,  ProductCategory.Water,    300, 60),
             // ПРЕДУПРЕДУВАЊЕ (Залиха: 42, Минимум: 40 -> многу блиску до лимит)
                new Product("21", "Вода (1.5л)",        80m,  25m,  ProductCategory.Water,    42,  40),
                new Product("22", "Газирана Вода",      60m,  18m,  ProductCategory.Water,    200, 40),

                // -- ALCOHOL
                new Product("30", "Пиво Скопско 0.5л",  130m, 60m,  ProductCategory.Alcohol,  120, 30),
                new Product("31", "Пиво Хајнекен 0.33л", 150m, 75m,  ProductCategory.Alcohol,  100, 25),
                new Product("32", "Бело Вино (чаша)",   160m, 50m,  ProductCategory.Alcohol,  80,  20),
                new Product("33", "Црвено Вино (чаша)",  160m, 50m,  ProductCategory.Alcohol,  80,  20),
                new Product("34", "Ракија Лоза 0.03л",  90m,  25m,  ProductCategory.Alcohol,  100, 25),
                // КРИТИЧНО НИСКО (Залиха: 2, Минимум: 15)
                new Product("35", "Виски 0.04л",         250m, 90m,  ProductCategory.Alcohol,  2,   15),
                new Product("36", "Џин Тоник",          280m, 80m,  ProductCategory.Alcohol,  60,  15),

                // -- DESSERTS
                // КРИТИЧНО НИСКО (Залиха: 3, Минимум: 15 -> 3 е помалку од 15 * 0.3 = 4.5)
                new Product("40", "Кроасан",            120m, 40m,  ProductCategory.Desserts, 3,   15),
                new Product("41", "Крофна",             90m,  30m,  ProductCategory.Desserts, 40,  15),
                new Product("42", "Сладолед топка",     150m, 35m,  ProductCategory.Desserts, 60,  20),
                new Product("43", "Тирамису",           200m, 70m,  ProductCategory.Desserts, 30,  10),
                new Product("44", "Чоколадна Торта",    180m, 60m,  ProductCategory.Desserts, 30,  10)
            };
        }


        public static Color GetCategoryColor(ProductCategory category)
        {
            switch (category)
            {
                case ProductCategory.Coffee:
                    return Color.FromArgb(180, 100, 40);
                case ProductCategory.Juices:
                    return Color.FromArgb(255, 140, 0);
                case ProductCategory.Water:
                    return Color.FromArgb(30, 144, 255);
                case ProductCategory.Alcohol:
                    return Color.FromArgb(178, 34, 34);
                case ProductCategory.Desserts:
                    return Color.FromArgb(219, 112, 147);
                default:
                    return Color.Gray;
            }
        }


    }
}
