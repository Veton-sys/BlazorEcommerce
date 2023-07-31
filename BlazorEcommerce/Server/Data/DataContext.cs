namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });
            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                                new ProductType { Id = 1, Name = "Default" },
                                new ProductType { Id = 2, Name = "Paperback" },
                                new ProductType { Id = 3, Name = "E-Book" },
                                new ProductType { Id = 4, Name = "Audiobook" },
                                new ProductType { Id = 5, Name = "Stream" },
                                new ProductType { Id = 6, Name = "Blu-ray" },
                                new ProductType { Id = 7, Name = "VHS" },
                                new ProductType { Id = 8, Name = "PC" },
                                new ProductType { Id = 9, Name = "PlayStation" },
                                new ProductType { Id = 10, Name = "Xbox" }
                            );


            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video games",
                    Url = "video-games"
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Hitchhiker Guide",
                    Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text-based video game, and 2005 feature film.",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                    CategoryId = 1,
                    Featured = true
                },
                new Product
                {
                    Id = 2,
                    Title = "Ready player one",
                    Description = "asdasdasdasdasdasdasdaasdasdasdasdasdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                    CategoryId = 1

                },
                new Product
                {
                    Id = 3,
                    Title = "Nineteen eighty four",
                    Description = "xzcccccccccccccccccccccccccccccccccccccccccccccccccccccccc",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                    CategoryId = 1,
                    Featured = true

                },
                new Product
                {
                    Id = 4,
                    Title = "CategoryTest",
                    Description = "xzcccccccccccccccccccccccccccccccccccccccccccccccccccccccc",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                    CategoryId = 2,
                    Featured = true

                },
                new Product
                {
                    Id = 5,
                    Title = "CategoryTest",
                    Description = "xzcccccccccccccccccccccccccccccccccccccccccccccccccccccccc",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
                    CategoryId = 3
                }
            ); ;

            modelBuilder.Entity<ProductVariant>().HasData(
                            new ProductVariant
                            {
                                ProductId = 1,
                                ProductTypeId = 2,
                                Price = 9.99m,
                                OriginalPrice = 19.99m
                            },
                            new ProductVariant
                            {
                                ProductId = 1,
                                ProductTypeId = 3,
                                Price = 7.99m
                            },
                            new ProductVariant
                            {
                                ProductId = 1,
                                ProductTypeId = 4,
                                Price = 19.99m,
                                OriginalPrice = 29.99m
                            },
                            new ProductVariant
                            {
                                ProductId = 2,
                                ProductTypeId = 1,
                                Price = 7.99m,
                                OriginalPrice = 14.99m
                            },
                            new ProductVariant
                            {
                                ProductId = 2,
                                ProductTypeId = 2,
                                Price = 6.99m
                            },
                            new ProductVariant
                            {
                                ProductId = 2,
                                ProductTypeId = 3,
                                Price = 3.99m
                            },
                            new ProductVariant
                            {
                                ProductId = 1,
                                ProductTypeId = 6,
                                Price = 9.99m
                            },
                            new ProductVariant
                            {
                                ProductId = 2,
                                ProductTypeId = 7,
                                Price = 19.99m
                            },
                            new ProductVariant
                            {
                                ProductId = 2,
                                ProductTypeId = 8,
                                Price = 19.99m,
                                OriginalPrice = 29.99m
                            },
                            new ProductVariant
                            {
                                ProductId = 2,
                                ProductTypeId = 9,
                                Price = 69.99m
                            },
                            new ProductVariant
                            {
                                ProductId = 2,
                                ProductTypeId = 10,
                                Price = 49.99m,
                                OriginalPrice = 59.99m
                            },
                            new ProductVariant
                            {
                                ProductId = 3,
                                ProductTypeId = 8,
                                Price = 9.99m,
                                OriginalPrice = 24.99m,
                            }
                        );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
