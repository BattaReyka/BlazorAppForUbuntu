namespace PraktikumsAufgabe.Data
{
    public class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Countries.Any())
            {
                return; // DB has been seeded
            }
            AddCountry("US", "United States", context);
            AddCountry("CA", "Canada", context);
            AddCountry("MX", "Mexico", context);
            AddCountry("GB", "United Kingdom", context);
            AddCountry("FR", "France", context);
            AddCountry("DE", "Germany", context);
            AddCountry("JP", "Japan", context);
            AddCountry("CN", "China", context);
            AddCountry("IN", "India", context);
            AddCountry("BR", "Brazil", context);
            context.SaveChanges();
        }

        private static void AddCountry(string id, string name, ApplicationDbContext context)
        {
            if (!context.Countries.Any(c => c.Id == id))
            {
                context.Countries.Add(new Countries { Id = id, Name = name });
            }
        }
    }
}
