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
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
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
