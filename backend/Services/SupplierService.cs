namespace Kodigos.Services {
    
/// <summary>
/// Service for managing suppliers.
/// </summary>
public class SupplierService 
{
    /// <summary>
    /// Gets a list of mock suppliers.
    /// </summary>
    /// <returns>A list of mock suppliers.</returns>
    public List<Supplier> GetSomeMock() {
        return new List<Supplier> {
            new Supplier { Id = 1 },
            new Supplier { Id = 2 },
            new Supplier { Id = 3 },
            new Supplier { Id = 4 },
            new Supplier { Id = 5 }
        };
    }
}}
