using System;

namespace Factory_Pattern_Exercise_Two
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
        }

        public List<Product> LoadData()
        {
            Console.WriteLine("Accessing Mongo saved data...");
            return new List<Product>()
            {
            new Product() {Name = "Elder Scrolls", Price = 19.99},
            new Product() {Name = "Doom", Price = 39.99},
            new Product() {Name = "Halo MCC", Price = 39.99},
            new Product() {Name = "Forza", Price = 59.99},
            new Product() {Name = "Dead Space", Price = 59.99}
            };
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to Mongo...");
        }
    }
}

