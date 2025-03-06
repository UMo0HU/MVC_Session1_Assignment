namespace MVCTask1.Models
{
    public class productBL
    {
        public List<product> products = new List<product> {
            new product
            {
                Id = 1,
                Name = "iPhone 15 Pro",
                Price = 999.99,
                Description = "Apple's latest flagship phone with an A17 Pro chip and titanium design.",
                Img = "IPhone15Pro.jpg"
            },
            new product
            {
                Id = 2,
                Name = "Samsung Galaxy S24 Ultra",
                Price = 1199.99,
                Description = "A high-end Android smartphone with a 200MP camera and S Pen support.",
                Img = "SamsungGalaxyS24Ultra.jpg"
            },
            new product
            {
                Id = 3,
                Name = "MacBook Pro M3",
                Price = 1999.99,
                Description = "Apple's powerful laptop with the M3 Pro chip, ideal for professionals.",
                Img = "MacBookProM3.jpg"
            },
            new product
            {
                Id = 4,
                Name = "Dell XPS 15",
                Price = 1799.99,
                Description = "A premium Windows laptop with a 4K OLED display and Intel Core i9 processor.",
                Img = "DellXPS15.jpg"
            },
            new product
            {
                Id = 5,
                Name = "Sony WH-1000XM5",
                Price = 399.99,
                Description = "High-quality noise-canceling wireless headphones with exceptional sound.",
                Img = "SonyWH-1000XM5.jpg"
            }
        };
        public List<product> GetAll()
        {
            return products;
        }

        public product GetByID(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
