

using System.Reflection.Metadata.Ecma335;
using GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne;
using Microsoft.AspNetCore.Routing.Tree;

namespace GutierrezFMiniChallengeTwoToFour_EndPoint.MiniChallengeOne;

    public interface IMiniChallengeServer
    {
    public string AddNumbers(string value, string NumSec);

    }
