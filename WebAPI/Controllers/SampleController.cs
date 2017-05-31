using System;
using System.Collections.Generic;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("[controller]")]
    public class SampleController : Controller
    {
        private readonly SampleBusinessLogic _SampleBusinessLogic;

        public SampleController(SampleBusinessLogic sampleBusinessLogic)
        {
            _SampleBusinessLogic = sampleBusinessLogic;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _SampleBusinessLogic.Get();
        }

        [HttpGet]
        [Route("Exception")]
        public void ThrowException()
        {
            throw new Exception("hello world");
        }
    }
}