using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyFreeFrom.Database;
using MyFreeFrom.Models;
using MyFreeFrom.Repositories;
using MyFreeFrom.Temp;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyFreeFrom.Controllers
{
    [Route("api/resturants")]
    public class ResturantsController : Controller
    {
        private IResturantRepository _resturantRepository;
        public ResturantsController(IResturantRepository resturantRepository)
        {
            _resturantRepository = resturantRepository;
        }

        [HttpGet()]
        public IActionResult GetResturants(bool includeReviews)
        {
            var resturantEntity = _resturantRepository.GetResturants(includeReviews);

            return Ok(Mapper.Map<IEnumerable<ResturantDTO>>(resturantEntity));
        }

        [HttpGet("{id}")]
        public IActionResult GetResturant(int id, bool includeReviews)
        {
            var resturantEntity = _resturantRepository.GetResturant(id, includeReviews);

            return Ok(Mapper.Map<ResturantDTO>(resturantEntity));
        }
    }
}
