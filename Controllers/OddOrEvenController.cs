
using GutierrezFMINIChallenge5_7.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace GutierrezFMINIChallenge5_7.Controllers;

[ApiController]
[Route("[controller]")]

public class OddOrEvenController : Controller
{
    private readonly IOddOrEvenService _oddOrEvenService;
    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
    [Route("CheckEvenOrOdd/{number}")]
    public string CheckEvenOrOdd(int number)
    {
        return _oddOrEvenService.CheckEvenOrOdd(number);
    }
}