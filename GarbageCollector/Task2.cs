using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    public enum StoreType
    {
        Grocery,
        Household,
        Clothing,
        Footwear
    }

    public class Store : IDisposable
    {
        private string? name;
        private string? address;
        private StoreType storeType;
        private List<string> products; 
        private bool disposed = false;
        public Store()
        {
            name = "Unnamed Store";
            address = "Unknown Address";
            storeType = StoreType.Grocery;
            products = new List<string>();
        }

        public Store(string name, string address, StoreType storeType)
        {
            Name = name;
            Address = address;
            StoreType = storeType;
            products = new List<string>();
        }

        public string? Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Назва магазину не може бути пустою");
                }
            }
        }

        public string? Address
        {
            get { return address; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    address = value;
                }
                else
                {
                    throw new ArgumentException("Адреса магазину не може бути пустою");
                }
            }
        }
        public StoreType StoreType
        {
            get { return storeType; }
            set { storeType = value; }
        }

        public List<string> Products
        {
            get { return products; }
            set
            {
                if (value != null)
                {
                    products = value;
                }
                else
                {
                    throw new ArgumentException("Список товарів не може бути null");
                }
            }
        }
        public void AddProduct(string product)
        {
            if (!string.IsNullOrWhiteSpace(product))
            {
                products.Add(product);
            }
            else
            {
                throw new ArgumentException("Назва продукту не може бути пустою");
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Назва магазину: {Name}\nАдреса: {Address}\nТип: {StoreType}\n");
            Console.WriteLine("Товари:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product}");
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    products.Clear();
                }

                disposed = true;
            }
        }


        ~Store()
        {
            Dispose(disposing: false);
            Console.WriteLine($"Магазин '{Name}' видалено з пам'яті.");
        }
    }
}
