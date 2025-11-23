using AbstractFactory.Factories;
using AbstractFactory.Factories.Interfaces;

IDocumentToolkit toolkit = new PdfToolkit();

var doc = toolkit.CreateDocument();
var viewer = toolkit.CreateViewer();
var printer = toolkit.CreatePrinter();

Console.WriteLine("Done");
