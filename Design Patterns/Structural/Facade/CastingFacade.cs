using Facade.Interfaces;

namespace Facade;

public class CastingFacade
{
    private readonly IDeviceExplorer _deviceExplorer;

    public CastingFacade(IDeviceExplorer deviceExplorer)
    {
        _deviceExplorer = deviceExplorer;
    }

    public async Task CastAsync(Guid deviceId, Guid videoId)
    {
        var device = await _deviceExplorer.GetAsync(deviceId);

        if (device is not SmartTVDevice smartTVDevice)
        {
            throw new Exception("Smart TV not found");
        }

        Connection connection;

        try
        {
            connection = await smartTVDevice.ConnectionAsync(videoId);
        }
        catch (Exception)
        {
            connection = await smartTVDevice.TurnOnAsync();
            await Task.Delay(2000);
        }

        var app = await connection.LaunchAppAsync("com.google.youtube");

        if (app is not YoutubeApp youtubeApp)
        {
            throw new Exception("YouTube app not found");
        }

        await youtubeApp.PlayVideoAsync(videoId);
    }
}
