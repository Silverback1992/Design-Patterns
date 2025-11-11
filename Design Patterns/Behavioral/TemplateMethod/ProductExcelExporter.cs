using Ganss.Excel;

namespace TemplateMethod;

public class ProductExcelExporter : ProductExporter
{
    protected override async Task ExportToFile(IEnumerable<Product> products)
    {
        await new ExcelMapper().SaveAsync("excelTemplateMethod.xlsx", products);
    }
}
