using Facade.Interfaces;

namespace Facade;

public class SmartTVDevice : IDevice
{
    public Guid DeviceId { get; set; }

    public SmartTVDevice(Guid deviceId)
    {
        DeviceId = deviceId;
    }

    public async Task<Connection> TurnOnAsync()
    {
        await Task.Delay(1000);
        return new Connection();
    }

    public async Task<Connection> ConnectionAsync(Guid videoId)
    {
        await Task.Delay(1000);
        throw new Exception("TV is turned off");
    }
}
