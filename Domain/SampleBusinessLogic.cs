using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

namespace Domain
{
    public class SampleBusinessLogic
    {
        private readonly ApplicationSettings _ApplicationSettings;

        public SampleBusinessLogic(IOptions<ApplicationSettings> applicationSettings)
        {
            _ApplicationSettings = applicationSettings.Value;
        }

        public IEnumerable<string> Get()
        {
            return new[] { "a", "b", "c", _ApplicationSettings.MyValue };
        }
    }
}
