using Microsoft.EntityFrameworkCore;
using NimbusPulseAPI.Context;
using NimbusPulseAPI.Infrastructure;
using NimbusPulseAPI.Infrastructure.Seed;
using NimbusPulseAPI.MappingProfile;
using NimbusPulseAPI.Repository;
using NimbusPulseAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddScoped<IDeviceService, DeviceService>();
builder.Services.AddAutoMapper(typeof(UserMappingProfile), typeof(DeviceMappingProfile));




builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//Midleware

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    if (dbContext.Database.EnsureCreated())  // Eðer veritabaný yoksa oluþturuluyor
    {
        DataSeeder.SeedDatabase(dbContext);  // Veritabanýný seed et
    }
}
app.UseCors("AllowAllOrigins");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
