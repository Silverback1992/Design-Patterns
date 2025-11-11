using System.Text.Json;

namespace TemplateMethod;

public class ProductJsonExporter : ProductExporter
{
    protected override async Task ExportToFile(IEnumerable<Product> products)
    {
        var json = JsonSerializer.Serialize(products);
        await File.WriteAllTextAsync("jsonTemplateMethod.json", json);
    }
}
