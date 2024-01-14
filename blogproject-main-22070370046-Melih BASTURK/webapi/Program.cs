
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using webapi;
using webapi.Blog;

var builder = WebApplication.CreateBuilder(args);
var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureHttpJsonOptions( options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.SerializerOptions.WriteIndented = true;
});
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  =>
                      {
                          policy.WithOrigins("http://localhost:4200","https://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                      });
});
/*builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.SerializerOptions.WriteIndented = true;
    //... other options you might want to set.
});*/
Startup.ConfigureServices(builder.Services);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();
BlogMap.AddMap(app);
KredilerMap.AddMap(app);
OkulMap.AddMap(app); // OkulMap sınıfının AddMap metodunu çağırır.
OgrencilerMap.AddMap(app); //OgrencilerMap sınıfının AddMap metodunu çağırır.
SehirlerMap.AddMap(app);//SehirlerMap sınıfının AddMap metodunu çağırır.
SozlukMap.AddMap(app); //SozlukMap sınıfının AddMap metodunu çağırır.
HaberlerMap.AddMap(app); //HaberlerMap sınıfının AddMap metodunu çağırır.
HavaMap.AddMap(app); //HavaMap sınıfının AddMap metodunu çağırır.
TrafikMap.AddMap(app); //TrafikMap sınıfının AddMap metodunu çağırır.

app.UseCors(MyAllowSpecificOrigins);
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
