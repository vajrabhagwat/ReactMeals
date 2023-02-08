using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactMeals.Models;

namespace ReactMeals.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : Controller
    {
        private readonly ReactMealsContext _context;
        public CatalogController(ReactMealsContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("/Catalog")]
        public IEnumerable<Catalog> GetCatalog()
        {
            return _context.Catalogs.ToList();
            
        }
    }
}
