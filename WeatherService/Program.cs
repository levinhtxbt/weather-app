using Refit;
using WeatherService;
using Steeltoe.Discovery.Client;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddYamlFile("appsettings.yml", optional: true, reloadOnChange: true);

// Add services to the container.
builder.Services.AddDiscoveryClient();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRefitClient<IOpenWeatherApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5"));


var app = builder.Build();

// Configure the HTTP request pipeline. 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
