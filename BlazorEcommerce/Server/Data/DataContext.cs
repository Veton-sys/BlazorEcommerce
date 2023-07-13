namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Hitchhiker Guide",
                    Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text-based video game, and 2005 feature film.",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Ready player one",
                    Description = "asdasdasdasdasdasdasdaasdasdasdasdasdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                    Price = 19.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Nineteen eighty four",
                    Description = "xzcccccccccccccccccccccccccccccccccccccccccccccccccccccccc",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                    Price = 29.99m
                }
            );
        }
        public DbSet<Product> Products { get; set; }
    }
}
