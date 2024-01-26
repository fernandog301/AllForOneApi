
using GutierrezFMiniChallengeEightToTen_Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace GutierrezFMiniChallengeEightToTen_Endpoints.Controllers
{
    [Route("[controller]")]
    public class GuessIt : Controller
    {
        private readonly IGuessItService _GuessItService;

        public GuessIt(IGuessItService GuessItService)
        {
            _GuessItService = GuessItService;
        }

        [HttpGet]
        [Route("EasyMode/{number}")]
        public string EasyMode(string number)
        {
            return _GuessItService.EasyMode(number);
        }

        [HttpGet]
        [Route("MediumMode/{number}")]
        public string MediumMode(string number)
        {
            return _GuessItService.MediumMode(number);
        }

        [HttpGet]
        [Route("HardMode/{number}")]
        public string HardMode(string number)
        {
            return _GuessItService.HardMode(number);
        }
    }
}