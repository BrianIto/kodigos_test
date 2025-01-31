using System.Text.Json.Serialization;

public enum Status {
    Pending,
    Approved,
    Rejected
}

/// <summary>
/// Represents the analysis of values including products and suppliers.
/// </summary>
public class ValueAnalysis 
{
    public int Id { get; set; }
    public List<Product>?  products { get; set;}
    public List<Supplier>? suppliers { get; set;}
    
    /// <summary>
    /// Gets or sets the status of the value analysis.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status status { get; set; }

}