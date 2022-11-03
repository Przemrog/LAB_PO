using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using WebApplication3.Services.LAB4;

namespace WebApplication3.Controllers.LAB4
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LanguageController : ControllerBase
    {
        [HttpGet]
        public string GetLang()
        {
            var lang = new Polish("POLSKA GUROM");

            return lang.getLang();
        }
    }
}