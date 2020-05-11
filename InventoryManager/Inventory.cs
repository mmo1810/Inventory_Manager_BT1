using System;
using System.Collections.Generic;
using System.Linq;


namespace InventoryManager
{
    //Declare variables for product
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
    //inventory function module
    public static class Inventory
    {
        //Array declaration for the product
        public static List<Product> products;
        //configuration for product array
        public static List<Product> Products
        {
            get {return products;}
            set { products = value;}
        }
        //remove product from memory
        static Inventory()
        {
            Products = new List<Product>();
        }
        public static void RemoveProduct(int productId)
        {
            Inventory.Products.RemoveAll(x => x.Id == productId);
        }
        //add product and save to memory
        public static void Add(Product product)
        {
            Products.Add(product);
        }
        //automatical generate product id
        public static int GetNewId()
        {
            int id;
            if (Inventory.Products.Count == 0)
                id = 1;
            else
            {
                id = Inventory.Products.Last().Id + 1;
            }
            return id;
        }
        //Count the number of products stored to memory
        public static int GetProductCount()
        {
            return Inventory.Products.Count();
        }
        //Count the product units stored to memory
        public static int GetUnitCount()
        {
            return Inventory.Products.Select(x => x.Quantity).Sum();
        }
        //Calculate the total value of products stored in memory
        public static decimal GetInventoryValue()
        {
            return Inventory.Products.Select(x => (x.Price * x.Quantity)).Sum();
        }
    }
}