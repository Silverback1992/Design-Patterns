using Facade.Interfaces;

namespace Facade;

public class Connection
{
    public async Task<IApp> LaunchAppAsync(string appId)
    {
        await Task.Delay(1000);
        return new YoutubeApp();
    }
}
