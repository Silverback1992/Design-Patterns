using Facade;

//Client code
var casting = new CastingFacade(new DeviceExplorer());

casting.CastAsync(Guid.NewGuid(), Guid.NewGuid()).Wait();
