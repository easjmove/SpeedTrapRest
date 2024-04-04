using Microsoft.AspNetCore.Mvc;
using SpeedTrapRest.Model;
using SpeedTrapRest.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpeedTrapRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeedTrapsController : ControllerBase
    {
        private SpeedTrapsRepository _speedTrapsRepository;

        public SpeedTrapsController(SpeedTrapsRepository speedTrapsRepository)
        {
            _speedTrapsRepository = speedTrapsRepository;
        }

        [HttpGet]
        public IEnumerable<SpeedTrap> Get()
        {
            return _speedTrapsRepository.GetAll();
        }

        // POST api/<SpeedTrapsController>
        [HttpPost]
        public void Post([FromBody] SpeedTrap newSpeedTrap)
        {
            _speedTrapsRepository.Add(newSpeedTrap);
        }
    }
}
