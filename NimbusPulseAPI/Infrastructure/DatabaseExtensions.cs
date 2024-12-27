//using NimbusPulseAPI.Context;
//using NimbusPulseAPI.Infrastructure.Seed;

//namespace NimbusPulseAPI.Infrastructure
//{
//    public static class DatabaseExtensions
//    {
//        public static void SeedDatabase(this IServiceProvider serviceProvider)
//        {
//            using (var scope = serviceProvider.CreateScope())
//            {
//                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

//                if (dbContext.Database.EnsureCreated())
//                {
//                    DataSeeder.SeedDatabase(dbContext);
//                }
//            }
//        }
//    }

//}
