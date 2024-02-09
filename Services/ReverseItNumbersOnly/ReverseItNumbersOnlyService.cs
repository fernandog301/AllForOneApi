
using GutierrezFMINIChallenge5_7.Services.ReverseItNumbersOnly;
using Microsoft.AspNetCore.Mvc;

namespace GutierrezFMINIChallenge5_7.Services.OddOrEven.MadLib.ReverseItAlphanumeric.ReverseItNumbersOnly;

public class ReverseItNumbersOnlyService : IReverseItNumbersOnlyService
{
    public string reverseIt(string value)
    {
        int number;

        bool success = int.TryParse(value, out number);
        if (success)
        {
            string number1 = "";
            for (int i = value.Length; i > 0; i--)
            {
                number1 += value[i - 1];

            }
            return $"Converted '{number}' to {number1}.";
        }
        else
        {
            return $"{value} is not a number.... Please Enter a Number.";
        }
    }
}