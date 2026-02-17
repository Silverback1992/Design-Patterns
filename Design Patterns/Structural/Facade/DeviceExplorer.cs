using Facade.Interfaces;

namespace Facade;

public class DeviceExplorer : IDeviceExplorer
{
    public async Task<IDevice> GetAsync(Guid deviceId)
    {
        await Task.Delay(1000);
        return new SmartTVDevice(deviceId);
    }
}
