using BlazorApp1.DataStructure;
using BlazorApp1.Services;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services
  .AddBlazorise(options =>
  {
	  options.Immediate = true;
  })
  .AddBootstrap5Providers()
  .AddFontAwesomeIcons();

builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<QuestionService>();
builder.Services.AddSingleton<QuestionObjService>();
builder.Services.AddSingleton<ResultsObjService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
