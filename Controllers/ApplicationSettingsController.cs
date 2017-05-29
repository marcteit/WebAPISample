using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebAPISample.Controllers
{
    [Route("[controller]")]
    public class ApplicationSettingsController : Controller
    {
        private readonly ApplicationSettings _ApplicationSettings;

        public ApplicationSettingsController(IOptions<ApplicationSettings> applicationSettings)
        {
            _ApplicationSettings = applicationSettings.Value;
        }

        [HttpGet]
        public ApplicationSettings Get()
        {
            return _ApplicationSettings;
        }
    }
}