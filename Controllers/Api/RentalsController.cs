﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRental(RentalDto rentalDto)
        {
            if (rentalDto.MovieIds.Count == 0)
                return BadRequest("No Movie Ids have been given...");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == rentalDto.CustomerId);

            if (customer == null)
                return BadRequest("CustomerId is not valid...");

            var movies = _context.Movies.Where(m => rentalDto.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != rentalDto.MovieIds.Count)
                return BadRequest("One or more Movie Ids are invalid...");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("This movie is out of stock...");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
