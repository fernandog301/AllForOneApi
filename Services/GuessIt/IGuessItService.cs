using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GutierrezFMiniChallengeEightToTen_Endpoints.Services;

    public interface IGuessItService
    {
            public string EasyMode(string number);
            public string MediumMode(string number);
            public string HardMode(string number);


    }