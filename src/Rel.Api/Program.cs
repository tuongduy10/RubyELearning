var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .MinimumLevel.Debug()
    .MinimumLevel.Error()
    .WriteTo.Console()
    .CreateLogger();
builder.Logging
    .ClearProviders()
    .AddSerilog(logger);
builder.Host.UseSerilog();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCarterConfiguraion();
builder.Services.AddSwaggerConfiguration();
builder.Services.AddTransient<ExceptionHandlingMiddleware>();

var app = builder.Build();

// Configure exception handling
app.UseMiddleware<ExceptionHandlingMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UserCarter();

app.Run();
