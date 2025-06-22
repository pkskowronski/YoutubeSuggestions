var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS support for React app
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policy =>
        {
            policy.WithOrigins("http://localhost:3000", "https://localhost:3000")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Enable CORS
app.UseCors("AllowReactApp");

// Sample YouTube video suggestions
var youtubeSuggestions = new[]
{
    new { id = 1, title = "How to Build a React App", channel = "CodeMaster", views = "1.2M", thumbnail = "https://via.placeholder.com/120x90" },
    new { id = 2, title = "C# Web API Tutorial", channel = "DotNetGuru", views = "856K", thumbnail = "https://via.placeholder.com/120x90" },
    new { id = 3, title = "TypeScript Best Practices", channel = "TechTips", views = "2.1M", thumbnail = "https://via.placeholder.com/120x90" },
    new { id = 4, title = "Full Stack Development Guide", channel = "DevAcademy", views = "3.4M", thumbnail = "https://via.placeholder.com/120x90" },
    new { id = 5, title = "API Design Patterns", channel = "SoftwareArch", views = "567K", thumbnail = "https://via.placeholder.com/120x90" }
};

app.MapGet("/api/suggestions", () =>
{
    return Results.Ok(youtubeSuggestions);
})
.WithName("GetYouTubeSuggestions")
.WithOpenApi();

app.MapGet("/api/suggestions/{id}", (int id) =>
{
    var suggestion = youtubeSuggestions.FirstOrDefault(s => s.id == id);
    if (suggestion == null)
        return Results.NotFound();
    
    return Results.Ok(suggestion);
})
.WithName("GetYouTubeSuggestionById")
.WithOpenApi();

app.Run();
