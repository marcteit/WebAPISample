using System;
using Microsoft.AspNetCore.Mvc;

namespace WebAPISample.Controllers
{
    [Route("[controller]")]
    public class ExceptionController : Controller
    {
        [HttpGet]
        public void Get()
        {
            throw new Exception("hello world");
        }
    }
}
