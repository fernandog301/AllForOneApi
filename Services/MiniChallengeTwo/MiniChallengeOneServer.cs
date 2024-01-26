
using GutierrezFMiniChallengeTwoToFour_EndPoint.MiniChallengeOne;

namespace GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne;

public class MiniChallengeOneServer : IMiniChallengeServer
{
    public string AddNumbers(string value, string NumSec)
    {
{
        int Number; 
        int NumbSec;
        bool success = int.TryParse(value, out Number);
        if(success){
            bool suc = int.TryParse(NumSec, out NumbSec);
        if (suc)
        {
            decimal outcome = 0;
        
            // Number = int.Parse(NumberInputTextBox.Text);
            // outcomeLabel.Text = (Number + 1).ToString();
            decimal NumOne = Convert.ToDecimal(Number);
            decimal NumTwo = Convert.ToDecimal(NumbSec);
            outcome = NumOne + NumTwo;
            return $"The sum Is {outcome}";
        }else{
            return $"Not A Number {NumSec}";
        }
            
        }return $"Not A Number {value}";
        }    
        }
}
    
