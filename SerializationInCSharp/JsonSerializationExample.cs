using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Product
{
    [JsonPropertyName("product_name")]
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class JsonSerializationExample
{
    public void Serialize()
    {
        Product p = new Product { Name = "Laptop", Price = 1000.99m };
        string json = JsonSerializer.Serialize(p);
        Console.WriteLine($"Serialized JSON: {json}");
    }

    public void Deserialize()
    {
        string json = "{\"product_name\":\"Laptop\",\"Price\":1000.99}";
        Product p = JsonSerializer.Deserialize<Product>(json);
        Console.WriteLine($"Name: {p.Name}, Price: {p.Price}");
    }
}
