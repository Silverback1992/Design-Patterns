namespace Facade.Interfaces;

public interface IDeviceExplorer
{
    Task<IDevice> GetAsync(Guid deviceId);
}
