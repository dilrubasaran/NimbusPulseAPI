using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using NimbusPulseAPI.Context;
using NimbusPulseAPI.Mapping;
using NimbusPulseAPI.Models;
using NimbusPulseAPI.Mapping;
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
builder.Services.AddScoped<IRepository<Settings>, Repository<Settings>>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();
builder.Services.AddScoped<IDeviceService, DeviceService>();

builder.Services.AddMapster();
builder.Services.AddSingleton(TypeAdapterConfig.GlobalSettings); // Global konfigürasyonu servislere ekler
builder.Services.AddScoped<IMapper, Mapper>(); // Mapper servisini inject et

//mapping dosyaları ekleme 
var config = TypeAdapterConfig.GlobalSettings;
config.Scan(typeof(DeviceMapping).Assembly);  //Todo:? DeviceMapping ve diğer mappingleri burada register edebilirsin
config.Scan(typeof(UserMapping).Assembly);


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.WithOrigins("http://localhost:3000",     // Flutter web port
                          "http://localhost:5166",      // HTTP port
                          "https://localhost:7185")     // HTTPS port
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();
    });
});


var app = builder.Build();

// Veritabanını oluştur ve seed data'yı ekle
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<AppDbContext>();
        
        // Veritabanı yoksa oluştur
        if (!context.Database.EnsureCreated())
        {
            // Veritabanı zaten varsa migration'ları uygula
            context.Database.Migrate();
        }
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Veritabanı oluşturulurken bir hata oluştu.");
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//Midleware

// using (var scope = app.Services.CreateScope())
// {
//     var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
//     if (dbContext.Database.EnsureCreated())  // E�er veritaban� yoksa olu�turuluyor
//     {
//         DataSeeder.SeedDatabase(dbContext);  // Veritaban�n� seed et
//     }
// }
app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("AllowAllOrigins"); 
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
