using GutierrezFMINIChallenge5_7.Services.ReverseItAlphanumeric;
using Microsoft.AspNetCore.Mvc;

namespace GutierrezFMINIChallenge5_7.Services.OddOrEven.MadLib.ReverseItAlphanumeric;

public class ReverseItAlphanumericService : IReverseItAlphanumericService
{

    public string reverseIt(string input)
    {
        string word1 = "";

        for (int i = input.Length -1; i >= 0; i--)
        {
            word1 += input[i];
        }
        return $"the reversed string is {word1}";
    }
}