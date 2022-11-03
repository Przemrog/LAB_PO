using Microsoft.AspNetCore.Mvc;
using WebApplication3.Services.LAB3;


namespace WebApplication3.Controllers.LAB3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class RectangleController : ControllerBase
    {
        [HttpGet]
        public int GetArea()
        {
            var rec = new Rectangle(23, 23);
            return rec.GetArea(2);
        }

        [HttpGet]
        public int GetSumArea()
        {
            var rec = new Rectangle(4, 4);
            var rec2 = new Rectangle(3, 3);
            var result = rec + rec2;
            return result.GetArea();
        }

    }
}
