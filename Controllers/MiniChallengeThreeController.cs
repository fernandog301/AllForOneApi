using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne.MiniChallengeOne;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GutierrezFMiniChallengeTwoToFour_EndPoint.Controllers
{
    [Route("[controller]")]
    public class MiniChallengeThreeController : Controller
    {
        private readonly IMiniChallengeThreeServices _MiniChallengeThree;

        public MiniChallengeThreeController(IMiniChallengeThreeServices MiniChallengeThree)
        {
            _MiniChallengeThree = MiniChallengeThree;
        }
        [HttpGet]
        [Route ("Sentence/{Name}/{WakeUpTime}")]
        public string Sentence(string Name, string WakeUpTime)
        {
            return _MiniChallengeThree.Sentence(Name, WakeUpTime);
        }

    }
}