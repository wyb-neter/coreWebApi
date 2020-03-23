using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using DLL;

namespace ApiDemo.Controllers
{
    [ApiController]
    [Route("api/WeatherForecast")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost("insert")]
        [HttpGet("insert")]
        public IEnumerable<User.AddUserR> InsertUser()
        {
            User user = new User();
            user.Name = "wuhaha";
            user.Pwd = "123456";
            User.AddUserR addUserR = UserDao.AddUser(user);
            yield return addUserR;
        }
        [HttpGet("query")]
        public IEnumerable<User> QueryUser(string name)
        {
            User user = new User();
            user = UserDao.queryUser(name);
            yield return user;
        }
    }
}
