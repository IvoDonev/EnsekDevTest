using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ensek.Apis.Controllers
{
    [ApiController]
    public class MeterReadingsController : ControllerBase
    {
        public MeterReadingsController()
        {
        }

        [HttpPost]
        [Route("meter-readings-uploads")]
        public int SubmitMeterReading(IFormFile data)
        {
        }
    }
}
