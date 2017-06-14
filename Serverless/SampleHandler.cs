using System.Collections.Generic;
using DataAccess;
using Domain;
using Microsoft.Extensions.Options;

namespace Serverless
{
    public class SampleHandler
    {
        private readonly IOptions<ApplicationSettings> _OptionsApplicationSettings =  new OptionsWrapper<ApplicationSettings>(new ApplicationSettings());
        private readonly SampleBusinessLogic _SampleBusinessLogic;

        public SampleHandler()
        {
            _SampleBusinessLogic = new SampleBusinessLogic(_OptionsApplicationSettings, new SampleDataAccess(_OptionsApplicationSettings));
        }

        public Dictionary<string, string> Get()
        {
            return _SampleBusinessLogic.Get();
        }
    }
}