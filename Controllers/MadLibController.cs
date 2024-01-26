using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GutierrezFMINIChallenge5_7.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace GutierrezFMINIChallenge5_7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly IMadLibService _madLibService;

        public MadLibController(IMadLibService madLibService)
        {
            _madLibService = madLibService;
        }

        [HttpPost]
        [Route("MadLib/{charaOne}/{charaTwo}/{placeOne}/{adjectOne}/{nounOne}/{optionOne}/{colorOne}/{reactionOne}/{expressOne}/{WeatherOne}/{AnswerTwo}/{ReviewOne}")]
    public string MadLib(string charaOne, string charaTwo,string placeOne,string adjectOne,string nounOne,string optionOne,string colorOne,string reactionOne, string expressOne,string WeatherOne,string AnswerTwo,string ReviewOne)
    {
        return _madLibService.MadLib(charaOne, charaTwo, placeOne, adjectOne, nounOne, optionOne, colorOne, reactionOne,  expressOne, WeatherOne, AnswerTwo, ReviewOne);
    }
    }
}