using BlazorApp1.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NVazirController : ControllerBase
    {
        private NVazirService _nVazirService;

        [HttpPost]
        public IActionResult NVazir([FromBody] int n)
        {

            _nVazirService = new NVazirService(n);
            _nVazirService.Queens(0);
            var answers = _nVazirService.answers;

            int i = 1;
            List<List<int>> answersJsonObject = new List<List<int>>();
            while (i * n <= answers.Count)
            {
                var reshte = answers.Skip((i - 1) * n).Take(n).ToList();
                answersJsonObject.Add(reshte);
                i++;
            }
            return Ok(answersJsonObject);
        }

    }
}
