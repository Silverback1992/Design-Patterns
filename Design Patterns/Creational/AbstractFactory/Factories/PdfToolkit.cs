using AbstractFactory.Domain;
using AbstractFactory.Domain.Interfaces;
using AbstractFactory.Factories.Interfaces;

namespace AbstractFactory.Factories;
public class PdfToolkit : IDocumentToolkit
{
    public IDocument CreateDocument()
    {
        return new PdfDocument();
    }

    public IDocumentPrinter CreatePrinter()
    {
        return new PdfPrinter();
    }

    public IDocumentViewer CreateViewer()
    {
        return new PdfViewer();
    }
}
