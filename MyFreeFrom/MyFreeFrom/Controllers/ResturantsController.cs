using Microsoft.AspNetCore.Mvc;
using MyFreeFrom.Database;
using MyFreeFrom.Temp;
using System.Linq;

namespace MyFreeFrom.Controllers
{
    [Route("api/resturants")]
    public class ResturantsController : Controller
    {
        private ResturantContext _context;
        public ResturantsController(ResturantContext context)
        {
            _context = context;
        }
        [HttpGet()]
        public IActionResult GetResturants()
        {
            return Ok(ResturantsDataStore.Current.Resturants);
        }

        [HttpGet("{id}")]
        public IActionResult GetResturant(int id)
        {
            var resturant = ResturantsDataStore.Current.Resturants.Where(x => x.Id == id);

            if (resturant == null)
            {
                return NotFound();
            }

            return Ok(resturant);
        }
    }
}
