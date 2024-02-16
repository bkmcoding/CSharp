using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPRShoesStoreApp
{
    public class Item()
    {
        public long Upc { set; get; }
        public string ItemName { set; get; } = "";
        public long Quantity { set; get; }
        public double ListPrice { set; get; }
        public double RetailPrice { set; get; }

        public Item(long upc, string itemName, long quantity, double listPrice) : this()
        {
            Upc = upc;
            ItemName = itemName;
            Quantity = quantity;
            ListPrice = listPrice;
            this.UpdateRetailPrice();
        }

        public void Update(int quantity)
        {
            Quantity += quantity;
            this.UpdateRetailPrice();
        }

        public string[] GetProperties()
        {
            return [Upc.ToString(), ItemName, Quantity.ToString(), ListPrice.ToString(""), RetailPrice.ToString("C")];
        }

        public void UpdateRetailPrice()
        {
            if (Quantity < 50)
            {
                RetailPrice = ListPrice * 1.5;
            } else if (Quantity < 100)
            {
                RetailPrice = ListPrice * 2;
            } else if (Quantity < 500)
            {
                RetailPrice = ListPrice * 2.25;
            } else if (Quantity < 1000)
            {
                RetailPrice = ListPrice * 3;
            }
            else
            {
                RetailPrice = ListPrice * 5;
            }
        }
    }
}
