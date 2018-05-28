﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyFreeFrom.Entities;
using MyFreeFrom.Models;
using MyFreeFrom.Repositories;
using System.Collections.Generic;

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

        [HttpGet("{id}", Name ="GetResturant")]
        public IActionResult GetResturant(int id, bool includeReviews)
        {
            var resturantEntity = _resturantRepository.GetResturant(id, includeReviews);

            return Ok(Mapper.Map<ResturantDTO>(resturantEntity));
        }

        [HttpPost]
        public IActionResult CreateResturant([FromBody] ResturantDTO resturant)
        {
            if (resturant == null)
                return BadRequest();

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var resturantEntity = Mapper.Map<Resturant>(resturant);
            _resturantRepository.AddResturant(resturantEntity);

            if (! _resturantRepository.Save())
            {
                return StatusCode(500, "A problem happened when trying to save the entity.");
            }

            var createdResturant = Mapper.Map<ResturantDTO>(resturantEntity);

            return CreatedAtRoute("GetResturant", new { createdResturant.Id, includeReviews = true },  createdResturant);
        }

    }
}
