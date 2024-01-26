using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GutierrezFMiniChallengeEightToTen_Endpoints.Services
{
    public class EightBallServices : IEightBallServices
    {
    // [Route("api/magic8ball")]
    // [ApiController]
        public string EightBall(string Responses){

            string[] Resp = {
            "Yes",
            "No",
            "Ask again later",
            "Cannot predict now",
            "Don't count on it",
            "My sources say yes",
            "Outlook not so good",
            "Reply hazy, try again"
        };

        Random random = new Random();
        int index = random.Next(0,Resp.Length);
        return Resp[index]; 
        }
    }
}