using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class Library : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UI.Domain.Customer> _logger;

        public void Customer(ILogger<UI.Domain.Customer> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<UI.Domain.Customer> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new UI.Domain.Customer
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

// Revature Intellectual Property and Resource:
//  Batch -> 2102-feb08-net
//
//  Project1 - Feb 26, 2021 Received Original Specifications
//
//  Project Lead - Revature Corporate Trainor Nick Escalona
//  Project Deliverable - Developer & Author -
//                        Revature Engineering Associate James Weight