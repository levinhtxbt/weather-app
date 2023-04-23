using Yarp.ReverseProxy.Transforms;
using Steeltoe.Discovery.Client;
using Gateway.LoadBalancing.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddYamlFile("appsettings.yml", optional: false, reloadOnChange: true);

// Add services to the container.
builder.Services.AddDiscoveryClient();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"))
    .LoadFromDiscoveryService()
    .AddTransforms(builderContext =>
    {
        builderContext.AddRequestTransform(transform =>
        {
            transform.ProxyRequest.Headers.Add("X-CorrelationId", new Guid().ToString("N"));
            return new ValueTask();
        });

    });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapReverseProxy();
app.Run();
