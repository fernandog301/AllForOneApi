
using Microsoft.AspNetCore.Mvc;

namespace GutierrezFMINIChallenge5_7.Services.OddOrEven
{
    public class OddOrEvenService : IOddOrEvenService
    {
        public string CheckEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return $"{number} is even";
            }
            else
            {
                return $"{number} Is Odd";
            }
        }
    }
}