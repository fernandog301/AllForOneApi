
namespace GutierrezFMiniChallengeEightToTen_Endpoints.Services
{
    public class RestarantPickerService : IRestaurantPickerService
    {
        public string GuessIt(string playerChoice)
    {

    
    string[] FastFood = {"Wendy's", "Burger king", "McDonalds", "Jack in the box", "Carlos Junior", "Taco bell", "Winner", "In-N-out", "KFC", "Panda Express" };
    string[] MexFood = {"El Tortio", "El Comal", "Nenas", "Susy's", "Irma's", "Casa Flores", "Don luis", "Tio pepe's", "Hilda's", "Maria's Cafe"};
    string[] AsianFood = {"Thai me up", "China village", "Tasty pot", "Loose chicken bowl", "johnny walker", "Dave Wongs", "Pho island", "Pho Lucky", "Dragon palse", "wok n roll"};

        Random randomClass = new Random();
        int randomNumber = randomClass.Next(0, 10);


        if(playerChoice == "a")
        {

            return FastFood[randomNumber];

        }else if (playerChoice == "b")
        {

            return MexFood[randomNumber];

        }else if (playerChoice == "c"){

            return AsianFood[randomNumber];

        }else {

            return "Sorry didn't get that? what category would you like!! (a = Fast Food), (b= Mexian Food), Lastly (c = Asain Food) ";
        } 
    }
    }
}