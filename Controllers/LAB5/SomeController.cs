using Microsoft.AspNetCore.Mvc;
using WebApplication3.Services.LAB4;
using WebApplication3.Services.LAB5;

namespace WebApplication3.Controllers.LAB5
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SomeController : Controller
    {

        [HttpGet]
        public string CallMethod()
        {
            var someInstance = new SomeClass();
            return someInstance.Print(null);
        }

    }
}
