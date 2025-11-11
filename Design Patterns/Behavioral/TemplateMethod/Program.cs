using TemplateMethod;

//Client code
var products = new List<Product>()
{
    new()
    {
        Category = ProductCategory.CategoryA,
        Name = "Boots",
        Price = 50,
    },

    new()
    {
        Category = ProductCategory.CategoryA,
        Name = "Jeans",
        Price = 75,
    },

    new()
    {
        Category = ProductCategory.CategoryA,
        Name = "Coat",
        Price = 30,
    },

    new()
    {
        Category = ProductCategory.CategoryB,
        Name = "Spoon",
        Price = 12,
    },

        new()
    {
        Category = ProductCategory.CategoryB,
        Name = "Knife",
        Price = 42,
    },

    new()
    {
        Category = ProductCategory.CategoryB,
        Name = "Fork",
        Price = 35,
    },

};

var jsonExporter = new ProductJsonExporter();
await jsonExporter.Export(products);

var excelExporter = new ProductExcelExporter();
await excelExporter.Export(products);

Console.WriteLine("Done!");
