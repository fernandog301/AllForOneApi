using GutierrezFMINIChallenge5_7.Services.MadLib;
using GutierrezFMINIChallenge5_7.Services.OddOrEven;
using GutierrezFMINIChallenge5_7.Services.OddOrEven.MadLib.ReverseItAlphanumeric;
using GutierrezFMINIChallenge5_7.Services.OddOrEven.MadLib.ReverseItAlphanumeric.ReverseItNumbersOnly;
using GutierrezFMINIChallenge5_7.Services.ReverseItAlphanumeric;
using GutierrezFMINIChallenge5_7.Services.ReverseItNumbersOnly;
using GutierrezFMiniChallengeEightToTen_Endpoints.Services;
using GutierrezFMiniChallengeTwoToFour_EndPoint.MiniChallengeOne;
using GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne;
using GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne.MiniChallengeFour;
using GutierrezFMiniChallengeTwoToFour_EndPoint.Servers.MINIChallengeOne.MiniChallengeOne;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Service.AddControllers();
builder.Services.AddCors(option =>{
    option.AddPolicy("CorsPolicy",
                    builder =>{
                        builder.AllowAnyHeader() // Allows any additional info sent with request (cookies)
                        .AllowAnyMethod() // Allows any Http Methods (HttpGet, HttpPut, etc)
                        .AllowAnyOrigin(); // Allows any domain to access your API
                    }
    );
});

builder.Services.AddScoped<IMiniChallengeFourServices, MiniChallengeFourServices>();
builder.Services.AddScoped<IMiniChallengeThreeServices, MiniChallengeThreeService>();
builder.Services.AddScoped<IMiniChallengeServer, MiniChallengeOneServer>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseItAlphanumericService, ReverseItAlphanumericService>();
builder.Services.AddScoped<IReverseItNumbersOnlyService, ReverseItNumbersOnlyService>();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IEightBallServices, EightBallServices>();
builder.Services.AddScoped<IGuessItService, GuessItService>();
builder.Services.AddScoped<IRestaurantPickerService, RestarantPickerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsePolicy");

app.MapControllers();

app.Run();
