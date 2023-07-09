using DooHAdvertAPI.Repository.Contract;
using Microsoft.AspNetCore.Mvc;

namespace DooHAdvertAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityAdvertController : ControllerBase
    {
        private readonly ICityRepository _cityRepository;

        public CityAdvertController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [HttpGet("{cityName}")]
        public ActionResult<string> GetAdvertPath(string cityName)
        {
            string advertPath = _cityRepository.GetActiveAdvertPath(cityName);

            if(advertPath == null)
            {
                return NotFound();
            }

            return advertPath;
        }

    }
}
