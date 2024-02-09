
using GutierrezFMINIChallenge5_7.Services.OddOrEven.MadLib.ReverseItAlphanumeric.ReverseItNumbersOnly;
using GutierrezFMINIChallenge5_7.Services.ReverseItNumbersOnly;
using Microsoft.AspNetCore.Mvc;

namespace GutierrezFMINIChallenge5_7.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumbersOnlyController : Controller
    {
        private readonly IReverseItNumbersOnlyService _reverseItNumbersOnlyService;

        public ReverseItNumbersOnlyController(IReverseItNumbersOnlyService reverseItNumbersOnlyService)
        {
            _reverseItNumbersOnlyService = reverseItNumbersOnlyService;
        }

        [HttpGet]
        [Route("ReverseIt/{value}")]
        public string reverseIt(string value)
        {
            return _reverseItNumbersOnlyService.reverseIt(value);
        }


}