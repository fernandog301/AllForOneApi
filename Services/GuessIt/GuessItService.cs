
namespace GutierrezFMiniChallengeEightToTen_Endpoints.Services;

public class GuessItService : IGuessItService
{
    Random random = new Random();

    // [HttpGet("easy/{number}")]
    int EasyModeRange = 10;
    int MediumModeRange = 50;
    int HardModeRange = 100;
    public string EasyMode(string number)
    {

        int guessedNumber = random.Next(1, EasyModeRange + 1);
        if (int.TryParse(number, out int num))
        {
            if (num == guessedNumber)
            {
                return "Congratulations! You guessed the number!";
            }
            else if (num < guessedNumber)
            {
                return "Too low! Try again.";
            }
            else
            {
                return "Too high! Try again.";
            }

        }
        else
        {
            return "Invalid Input, please input a number that is 1-10";
        }
    }

    // [HttpGet("medium/{number}")]
    public string MediumMode(string number)
    {
        if (int.TryParse(number, out int num))
        {
            int guessedNumber = random.Next(1, MediumModeRange + 1);

            if (num == guessedNumber)
            {
                return "Congratulations! You guessed the number!";
            }
            else if (num < guessedNumber)
            {
                return "Too low! Try again.";
            }
            else
            {
                return "Too high! Try again.";
            }
        }
        else
        {
            return "Invalid Input, please input a number that is 1-50";
        }
    }

    // [HttpGet("hard/{number}")]
    public string HardMode(string number)
    {
        if (int.TryParse(number, out int num))
        {
            int guessedNumber = random.Next(1, HardModeRange + 1);

            if (num == guessedNumber)
            {
                return "Congratulations! You guessed the number!";
            }
            else if (num < guessedNumber)
            {
                return "Too low! Try again.";
            }
            else
            {
                return "Too high! Try again.";
            }
        }
        else
        {
            return "Invalid Input, please input a number that is 1-100";
        }
    }
}