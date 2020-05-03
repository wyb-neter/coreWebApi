using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDemo.Controllers
{
    [ApiController]
    [Route("api/Order")]
    public class OrderController : ControllerBase
    {
        [HttpPost("create")]
        [HttpGet("create")]
        public string CreateOrder([FromBody]OrderItem orderItem)//自动匹配参数体
        {
            return $"我使用{orderItem.PayType}方式支付。";//返回string类型的参数
        }
    }
}
