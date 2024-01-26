
using GutierrezFMiniChallengeEightToTen_Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace GutierrezFMiniChallengeEightToTen_Endpoints.Controllers;

    [Route("[controller]")]
    public class RestaurantPicker : Controller
    {
    private readonly IRestaurantPickerService _restaurantPickerService;

    public RestaurantPicker(IRestaurantPickerService restaurantPickerService)
    {
        _restaurantPickerService = restaurantPickerService;
    }

    [HttpGet]
    [Route ("restaurantPicker/{playerChoice}")]
        public string GuessIt(string playerChoice)
        {
            return _restaurantPickerService.GuessIt(playerChoice);
        }
    }