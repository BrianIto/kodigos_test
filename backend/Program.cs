using Kodigos.Services;
using System.Reflection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => 
    {
        options.SwaggerDoc("v1", new OpenApiInfo 
        { 
            Version = "v1",
            Title = "Kodigos",
            Description = "Technical Test for Kodigos Job Application.\n Made at 2025-01-31 (YYYY-MM-DD).", 
            Contact = new OpenApiContact {
                Name = "Brian Ito",
                Email = "contact@brianito.com",
                Url = new Uri("https://brianito.com"),
            } 
        });
        
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => 
    {
	builder.AllowAnyOrigin()
	    .AllowAnyMethod()
	    .AllowAnyHeader();
    });
});
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<SupplierService>();
builder.Services.AddScoped<RejectionService>();
builder.Services.AddScoped<ValueAnalysisService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors();
app.MapControllers();

app.Run();
