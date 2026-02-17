using Facade.Interfaces;

namespace Facade;

public class YoutubeApp : IApp
{
    public async Task PlayVideoAsync(Guid videoId)
    {
        await Task.Delay(1000);
        Console.WriteLine($"Playing video with id: {videoId}");
    }
}
