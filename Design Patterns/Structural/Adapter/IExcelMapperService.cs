
namespace Adapter;
public interface IExcelMapperService
{
    Task<IEnumerable<T>> FetchAsync<T>(string file);
}
