using COMP003B.Assignment5.Models;
namespace COMP003B.Assignment5.Data
{
    public class CleaningInventory
    {
        public static List<CleaningBrand> CleaningBrands { get; } = new()
        {
            new CleaningBrand { Id =1, Name = "Clorox", Quantity = 3, Price = 12.99m },
            new CleaningBrand { Id =2, Name = "Windex", Quantity = 1, Price = 2.99m },
            new CleaningBrand { Id =3, Name = "Ajax", Quantity = 4, Price = 5.99m },
            new CleaningBrand { Id =4, Name = "Fabuloso", Quantity = 7, Price = 15.99m },
        };
    }
}