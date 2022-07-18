using System;

namespace Factory_Pattern_Exercise_Two
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> VideoGames = new List<Product>()
        {
            new Product() {Name = "Elder Scrolls", Price = 19.99},
            new Product() {Name = "Doom", Price = 39.99},
            new Product() {Name = "Halo MCC", Price = 39.99},
            new Product() {Name = "Forza", Price = 59.99},
            new Product() {Name = "Dead Space", Price = 59.99}
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("Accessing your static list");
            return VideoGames;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving to your sttatic list...");
        }
    }
}

