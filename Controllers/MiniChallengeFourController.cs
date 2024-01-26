using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne.MiniChallengeFour;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GutierrezFMiniChallengeTwoToFour_EndPoint.Controllers
{
    [Route("[controller]")]
    public class MiniChallengeFourController : Controller
    {
        
        private readonly IMiniChallengeFourServices _MiniChallengeFourServices;

        public MiniChallengeFourController(IMiniChallengeFourServices MiniChallengeFourServices)
        {
            _MiniChallengeFourServices = MiniChallengeFourServices;
        }
        [HttpGet]
        [Route ("GreaterOrLess/{numOne}/{NumTwo}")]
        public string greaterOrLess(string numOne, string NumTwo)
        {
            return _MiniChallengeFourServices.greaterOrLess(numOne, NumTwo);
        }

    }
}