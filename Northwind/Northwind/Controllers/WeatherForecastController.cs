using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Northwind.Models.Model;
using Northwind.Repository;
using Northwind.WEB.Response;
using System;
using System.Collections.Generic;

namespace Northwind.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IRepository<Employee> _repository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRepository<Employee> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            Respuesta Response = new Respuesta();
            try 
            {
                IEnumerable<Employee> employeeRepository = _repository.Get();
                Response.Win = 1;
                Response.Message = "Información recuperada";
                Response.Data = employeeRepository;

            }
            catch (Exception ex)
            {
                Response.Message = ex.Message;
            }
            return Ok(Response);
        }
    }
}
