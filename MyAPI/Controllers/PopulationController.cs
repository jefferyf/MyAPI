using Microsoft.AspNetCore.Mvc;
using MyAPI.Models;
using Newtonsoft.Json;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PopulationController : ControllerBase
    {
        private readonly ILogger<PopulationController> _logger;

        public PopulationController(ILogger<PopulationController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetUSPopulations")]
        public async Task<IActionResult> GetUSPopulations()
        {
            using (var client = new HttpClient())
            {
                // API Information:  https://datausa.io/about/api/
                var api = "https://datausa.io/api/data?drilldowns=Nation&measures=Population";
                var response = await client.GetAsync(api);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var serializedContent = JsonConvert.DeserializeObject<PopulationResponse>(content);
                    return Ok(serializedContent);
                }
                else
                {
                    _logger.LogError($"Error: {response.StatusCode}");
                    return BadRequest();
                }
            }
        }
    }
}
