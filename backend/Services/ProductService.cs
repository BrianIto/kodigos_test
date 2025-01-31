namespace Kodigos.Services {

public class ProductService {
    public List<Product> GetSomeMock() {
        return new List<Product> {
            new Product { Id = 1, Name = "Product 1", Description = "Description 1", Amount = 100 },
            new Product { Id = 2, Name = "Product 2", Description = "Description 2", Amount = 100 },
            new Product { Id = 3, Name = "Product 3", Description = "Description 3", Amount = 100 },
            new Product { Id = 4, Name = "Product 4", Description = "Description 4", Amount = 100 },
            new Product { Id = 5, Name = "Product 5", Description = "Description 5", Amount = 300 }
        };
    }
}
}