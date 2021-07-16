using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ensek.Apis.Controllers
{
    [ApiController]
    public class MeterReadingsController : ControllerBase
    {
        private EnsekContext context;
        public MeterReadingsController(EnsekContext context)
        {
            this.context = context;
        }

        [HttpPost]
        [Route("meter-readings-uploads")]
        public int SubmitMeterReading(IFormFile data)
        {
            return context.Accounts.Count();
        }
    }
}
