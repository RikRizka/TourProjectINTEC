namespace SomethingsMVC.Models
{
    public class Product
    {
        //Generate id is guid
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public List<Product> Products;

        public Product() 
        {
            Products = new List<Product>();
        }

        public List<Product> GetProducts()
        {

            Products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 1",  Price = 10 });
            Products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 2",  Price = 20 });
            Products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 3",  Price = 30 });
            Products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 4",  Price = 40 });
            Products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 5",  Price = 50 });
            return Products;

        }
        public decimal Calculate()
        {
            return Products.Sum(p => p.Price);
          
        }
    }
}
