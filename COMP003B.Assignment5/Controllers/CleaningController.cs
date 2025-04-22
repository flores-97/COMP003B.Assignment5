using COMP003B.Assignment5.Data;
using COMP003B.Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CleaningController : Controller
    {
        [HttpGet]
        public ActionResult<List<CleaningBrand>> GetCleanings()
        {
            return Ok(CleaningInventory.CleaningBrands);
        }

        [HttpGet("{id}")]
        public ActionResult<CleaningInventory> GetCleaning(int id)
        {
            var cleaningBrand = CleaningInventory.CleaningBrands.FirstOrDefault(b => b.Id == id);

            if (cleaningBrand is null)
                return NotFound();

            return Ok(cleaningBrand);
        }
        [HttpPost]
        public ActionResult<CleaningBrand> CreateBrand(CleaningBrand brand)
        {
            brand.Id = CleaningInventory.CleaningBrands.Max(b => b.Id) + 1;
            CleaningInventory.CleaningBrands.Add(brand);
            return CreatedAtAction(nameof(GetCleaning), new { id = brand.Id }, brand);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, CleaningBrand cleaningBrand)
        {
            var existingBrand = CleaningInventory.CleaningBrands.FirstOrDefault(b =>b.Id == id);

            if(existingBrand is null)
                return NotFound();

            existingBrand.Name = cleaningBrand.Name;
            existingBrand.Price = cleaningBrand.Price;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBrand(int id)
        {
            var brand = CleaningInventory.CleaningBrands.FirstOrDefault(b => b.Id == id);

            if (brand is null)
                return NotFound();

            CleaningInventory.CleaningBrands.Remove(brand);

            return NoContent(); 
        }

        [HttpGet("filter")]
        public ActionResult<List<CleaningBrand>> FilterBrands(decimal price)
        {
            var filteredBrands = CleaningInventory.CleaningBrands
                .Where(b => b.Price == price)
                .OrderBy(b => b.Name)
                .ToList();
            return Ok(filteredBrands);
        }

        [HttpGet("names")]
        public ActionResult<List<string>> GetBrandNams()
        {
            var brandNames = CleaningInventory.CleaningBrands
                .OrderBy(b => b.Name)
                .Select(b => b.Name)
                .ToList();

            return Ok(brandNames);
        }
    }

}
