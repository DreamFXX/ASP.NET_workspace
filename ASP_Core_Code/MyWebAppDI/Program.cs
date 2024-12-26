using MyWebAppDI.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<WelcomeService>();

var app = builder.Build();

app.MapGet("/", (WelcomeService welcomeService) => welcomeService.GetWelcomeMessage());

app.Run();
