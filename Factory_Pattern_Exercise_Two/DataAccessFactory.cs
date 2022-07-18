using System;
namespace Factory_Pattern_Exercise_Two
{
    static class DataAccessFactory
    {
        public static IDataAccess GetDataAccess(string dataType)
        {
            switch (dataType.ToLower())
            {
                case "list":
                    return new ListDataAccess();

                case "mysql":
                case "sql":
                case "my":
                    return new SQLDataAccess();

                case "mongo":
                case "mongodb":
                    return new MongoDataAccess();

                default:
                    return new ListDataAccess();
            }
        }
    }
}

