using AbstractFactory.Domain;
using AbstractFactory.Domain.Interfaces;

namespace AbstractFactory.Factories.Interfaces;
public interface IDocumentToolkit
{
    IDocument CreateDocument();
    IDocumentViewer CreateViewer();
    IDocumentPrinter CreatePrinter();
}
