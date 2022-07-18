using System;
namespace Factory_Pattern_Exercise_Two
{
    public interface IDataAccess
    {
        // Methods for Interface
        List<Product> LoadData();
        void SaveData();
    }
}

