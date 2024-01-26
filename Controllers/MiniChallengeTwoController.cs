using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GutierrezFMiniChallengeTwoToFour_EndPoint.MiniChallengeOne;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GutierrezFMiniChallengeTwoToFour_EndPoint.Controllers
{
    [Route("[controller]")]
    public class MiniChallengeTwoController : Controller
    {
        private readonly IMiniChallengeServer _MiniChallengeOneServer;

        public MiniChallengeTwoController(IMiniChallengeServer MiniChallengeOneServer)
        {
            _MiniChallengeOneServer = MiniChallengeOneServer;
        }
        [HttpGet]
        [Route ("GreaterOrLess/{value}/{NumSec}")]
            public string AddNumbers(string value, string NumSec)
            {
                return _MiniChallengeOneServer.AddNumbers(value, NumSec);
            }

    }
}