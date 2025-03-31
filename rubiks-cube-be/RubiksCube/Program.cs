WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services
.AddControllers()
.AddNewtonsoftJson();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policyBuilder =>
    {
        policyBuilder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowAnyOrigin();
    });
});

WebApplication app = builder.Build();

app.UseCors();

app.UseRouting();

app.MapControllers();

app.Run();
