using DometrainDebuggingPlayground;
using DometrainDebuggingPlayground.PodcastSource;
using DometrainDebuggingPlayground.PodcastsService;
using DometrainDebuggingPlayground.ThreadDemo;

// [Debugging 3rd-party code]
// - MAKE TYPO IN FILE [launchSettings.json]
//   "ASPNETCORE_ENVIRONMENT": "Developmnt"
// - ADD BREAKPOINT TO THIS LINE
// - DEBUG TO FIND OUT WHY AND WHERE IT FAILS
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddTransient<IPodcastService, PodcastService>();
builder.Services.AddTransient<IPodcastSource, HardcodedPodcastSource>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// [Debugging multi-threaded code]
Threads.Execute();

app.Run();

namespace DometrainDebuggingPlayground
{
    public partial class Program
    {
    }
}