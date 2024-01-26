using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GutierrezFMiniChallengeEightToTen_Endpoints.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GutierrezFMiniChallengeEightToTen_Endpoints.Controllers;

    [Route("[controller]")]
    public class EightBallController : Controller
    {
    private readonly IEightBallServices _eightBallServices;

    public EightBallController(IEightBallServices eightBallServices)
    {
        _eightBallServices = eightBallServices;
    }

    [HttpGet]
    [Route("Magic/{Responses}")]
        public string EightBall(string Responses){
            return _eightBallServices.EightBall(Responses);
        }

    }
