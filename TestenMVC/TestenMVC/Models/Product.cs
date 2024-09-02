namespace TestenMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public decimal? Prijs { get; set; }

        List<Product> products = new List<Product>();

        public List<Product>GetProduct()
            {
            products.Add(new Product { Id = 1, Naam = "Apel", Prijs = 0.50m });
            products.Add(new Product { Id = 1, Naam = "Anggur", Prijs = 1.50m });
            products.Add(new Product { Id = 1, Naam = "Banaan", Prijs = 2.50m });
            products.Add(new Product { Id = 1, Naam = "Peer", Prijs = 3.50m });
            var totaal = products.Sum(x => x.Prijs);
            return products;

        }
    }
}
