
using Factory_Pattern_Exercise_Two;

Console.WriteLine("What database do you want to access?");
Console.WriteLine("For List Enter: list");
Console.WriteLine("For sql enter: sql");
Console.WriteLine("For Mongo enter: mongo");
string response = Console.ReadLine();


IDataAccess factData = DataAccessFactory.GetDataAccess(response);
List<Product> products = factData.LoadData();
factData.SaveData();

foreach (var product in products)
{
    Console.WriteLine($"Game Name : {product.Name} | Game Price: {product.Price}");
}