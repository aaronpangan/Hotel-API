using System.Threading.Tasks;
using Hotel_API.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hotel_API.Controllers
{
    [Route("api/country")]
    public class CountryController : Controller
    {
        readonly IUnitOfWork _unitOfWork;
        readonly ILogger _logger;

        public CountryController(IUnitOfWork unitOfWork, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Content("Hello");
        }
    }
}