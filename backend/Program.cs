using Microsoft.EntityFrameworkCore;
using backend.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Get the connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register the DbContext with Windows Authentication
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add CORS configuration BEFORE building the app
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policyBuilder =>
    {
        policyBuilder.WithOrigins("http://localhost:3000")
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

app.UseCors(); // Enable CORS
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
