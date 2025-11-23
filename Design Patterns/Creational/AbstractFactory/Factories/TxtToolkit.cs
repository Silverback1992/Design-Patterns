using AbstractFactory.Domain;
using AbstractFactory.Domain.Interfaces;
using AbstractFactory.Factories.Interfaces;

namespace AbstractFactory.Factories;
public class TxtToolkit : IDocumentToolkit
{
    public IDocument CreateDocument()
    {
        return new TxtDocument();
    }

    public IDocumentPrinter CreatePrinter()
    {
        return new TxtPrinter();
    }

    public IDocumentViewer CreateViewer()
    {
        return new TxtViewer();
    }
}
