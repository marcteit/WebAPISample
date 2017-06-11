using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

namespace Domain
{
    public class SampleBusinessLogic
    {
        private readonly ApplicationSettings _ApplicationSettings;
        private readonly ISampleDataAccess _SampleDataAccess;

        public SampleBusinessLogic(IOptions<ApplicationSettings> applicationSettings, ISampleDataAccess sampleDataAccess)
        {
            _ApplicationSettings = applicationSettings.Value;
            _SampleDataAccess = sampleDataAccess;
        }

        public Dictionary<string, string> Get()
        {
            return new Dictionary<string, string>
            {
                { "Constant Values", "a, b, c" },
                { "ApplicationSettings.MyValue", _ApplicationSettings.MyValue },
                { "From Database", _SampleDataAccess.GetCount().ToString() }
            };
        }
    }
}
