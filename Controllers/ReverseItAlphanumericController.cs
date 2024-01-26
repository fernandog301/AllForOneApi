
using GutierrezFMINIChallenge5_7.Services.ReverseItAlphanumeric;
using Microsoft.AspNetCore.Mvc;

namespace GutierrezFMINIChallenge5_7.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItAlphanumericController : Controller
{
    private readonly IReverseItAlphanumericService _reverseItAlphanumericService;

    public ReverseItAlphanumericController(IReverseItAlphanumericService reverseItAlphanumericService)
    {
        _reverseItAlphanumericService = reverseItAlphanumericService;
    }
    
    [HttpGet]
    [Route("reverseItAlphanumeric/{input}")]
    public string ReverseIt(string input)
    {
        return _reverseItAlphanumericService.reverseIt(input);
    }


}

// public class CheckEvenOrOdd

