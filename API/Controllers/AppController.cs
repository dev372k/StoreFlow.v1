using Microsoft.AspNetCore.Mvc;
using Shared.Helpers;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppController : ControllerBase
    {
        private AppConfiguration appSetting;

        public AppController()
        {
            appSetting = new AppConfiguration();
        }
    }
}
