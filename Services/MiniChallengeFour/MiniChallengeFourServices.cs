
using GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne.MiniChallengeFour;

namespace GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne;

    public class MiniChallengeFourServices : IMiniChallengeFourServices
    {
        

        public string greaterOrLess(string numOne, string NumTwo)
        {

            int num1;
            int num2;
            bool success = int.TryParse(numOne, out num1);
        if(success){
            bool suc = int.TryParse(NumTwo, out num2);
        if (suc)
        {

            if (int.TryParse(NumTwo, out num2))
            {
                if (num1 > num2)
                {
                    return $"{num1} is greater than {num2}.";
                }
                else if (num1 < num2)
                {
                    return $"{num1} is less than {num2}.";
                }
                else
                {
                    return $"{num1} is equal to {num2}.";
                }
            }
        }
        }return $"{numOne} is not a valid number";
    }
    }
