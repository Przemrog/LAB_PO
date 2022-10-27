using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.lab_3;

namespace WebApplication1.Controllers.lab_3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class RectangleController : ControllerBase
    {
        [HttpGet]
        public int GetArea()
        {
            var rec = new Rectangle(23, 23);
            return rec.GetArea();
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
