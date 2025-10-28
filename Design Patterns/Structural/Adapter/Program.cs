using Adapter;
using Microsoft.Extensions.DependencyInjection;

//Quick IOC

var services = new ServiceCollection();
services.AddTransient<IExcelMapperService, ExcelMapperService>();

var serviceProvider = services.BuildServiceProvider();

/*
I'm the client here and I want to read an excel file into an IEnumerable of objects to manipulate later on
For my needs it turns out that ExcelMapper is a great nuget
However it is not unit testing friendly and I only want to use a method where I can later use mocking to unit test
Solution: Adapter design pattern or wrapper or wrapping
*/

var myClass = new MyClass(serviceProvider.GetRequiredService<IExcelMapperService>());
await myClass.HandleData();

//Thanks to the Adapter design pattern I can unit test MyClass if I want to becasue I can mock _excelMapperService to return xyz or do nothing
//Instead of actually fetching an excel file

internal class MyClass
{
    private readonly IExcelMapperService _excelMapperService;

    public MyClass(IExcelMapperService excelMapperService)
    {
        _excelMapperService = excelMapperService;
    }

    public async Task HandleData()
    {
        Console.WriteLine("Lots of logic");

        if (false)
        {
            var data = await _excelMapperService.FetchAsync<object>("somePath");
        }

        Console.WriteLine("end");
    }
}



