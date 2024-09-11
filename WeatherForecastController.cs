using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<string> Summaries = new()
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "Mild"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public IActionResult Add(string name)
        {
            Summaries.Add(name);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(int index, string name)
        {
            if(index < 0 || index >= Summaries.Count)
            {
                return BadRequest("Неверный индекс");
            }
            Summaries[index] = name;
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= Summaries.Count)
            {
                return BadRequest("Неверный индекс");
            }
            Summaries.RemoveAt(index);
            return Ok();
        }

        [HttpGet("{index}")]
        public IActionResult GetByIndex(int index)
        {
            if (index < 0 || index >= Summaries.Count)
            {
                return NotFound("Введён индекс за пределами");
            }

            return Ok(Summaries[index]);
        }

        [HttpGet("find-by-name")]
        public IActionResult GetByName(string name)
        {
            var count = Summaries.Count(s => s.Equals(name, StringComparison.OrdinalIgnoreCase));
            return Ok(count);
        }

        [HttpGet]
        public IActionResult GetAll(int ? sortStrategy)
        {
            List<string> sortedSummaries;

            switch (sortStrategy)
            {
                case null:
                    sortedSummaries = Summaries;
                    break;
                case 1:
                    sortedSummaries = Summaries.OrderBy(s => s).ToList();
                    break;
                case -1:
                    sortedSummaries = Summaries.OrderByDescending(s => s).ToList();
                    break;
                default:
                    return BadRequest("Такое значение параметра sortStrategy недопустимо");
                    break;
            }
            return Ok(sortedSummaries);
        }
    }
}