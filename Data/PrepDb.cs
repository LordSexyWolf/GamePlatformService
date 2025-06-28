using GamePlatformService.Models;

namespace GamePlatformService.Data
{
    public class PrepDb
    {
        public static void PrePopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine(" -----> Seeding Data...");
                context.Platforms.AddRange(
                    new Platform() 
                    { 
                        Name="PlayStation 5",
                        Publisher = "Sony",
                        Cost = 599},
                    new Platform()
                    {
                        Name = "Steam Deck",
                        Publisher = "Valve",
                        Cost = 399
                    },
                    new Platform()
                    {
                        Name = "Xbox X",
                        Publisher = "Microsoft",
                        Cost = 599}
                    );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine(" -----> We already have data");
            }
        }
    }
}
