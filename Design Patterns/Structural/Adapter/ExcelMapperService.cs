using Ganss.Excel;

namespace Adapter;
public class ExcelMapperService : IExcelMapperService
{
    public async Task<IEnumerable<T>> FetchAsync<T>(string file)
    {
        return await new ExcelMapper().FetchAsync<T>(file);
    }
}
