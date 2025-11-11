namespace TemplateMethod;
public abstract class ProductExporter
{
    public async Task Export(IEnumerable<Product> products, ProductCategory? filteryBy = null)
    {
        var productsToExport = SortProducts(products);

        if (filteryBy is ProductCategory category)
        {
            productsToExport = FilterProducts(productsToExport, category);
        }

        await ExportToFile(productsToExport);
    }

    private static IEnumerable<Product> SortProducts(IEnumerable<Product> products)
    {
        return products.OrderBy(x => x.Price);
    }

    private static IEnumerable<Product> FilterProducts(IEnumerable<Product> products, ProductCategory category)
    {
        return products.Where(x => x.Category == category);
    }

    protected abstract Task ExportToFile(IEnumerable<Product> products);
}
