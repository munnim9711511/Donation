using Microsoft.AspNetCore.Mvc;

namespace DonationApp.Controllers {

    [Route ("api/[controller]")]

    public class WebApiController : Controller {

        [HttpGet]
        public IActionResult Get () {
            return Ok ("ok data");
        }

        [HttpGet ("{id}")]
        public IActionResult Get ([FromRoute] int id) {
            return Ok (new { id });
        }

        [HttpPost]
        public IActionResult Post ([FromBody] object x) {
            return Ok ("data posted");
        }

        [HttpPut ("{id}")]
        public IActionResult Put ([FromBody] object f) {
            return Ok ();
        }

        [HttpDelete ("{id}")]
        public IActionResult Dele ([FromRoute] int id) {
            return Ok (new { id });
        }

    }
}