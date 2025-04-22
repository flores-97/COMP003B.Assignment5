using COMP003B.Assignment5.Models;
namespace COMP003B.Assignment5.Data
{
    public class CleaningInventory
    {
        public static List<CleaningBrand> CleaningBrands { get; } = new()
        {
            new CleaningBrand { Id =1, Name = "Clorox", Quantity = 3, Price = 12.99m },
            new CleaningBrand { Id =1, Name = "Windex", Quantity = 3, Price = 12.99m },
            new CleaningBrand { Id =1, Name = "Ajax", Quantity = 3, Price = 12.99m },
            new CleaningBrand { Id =1, Name = "Fabuloso", Quantity = 3, Price = 12.99m },
        };
    }
}