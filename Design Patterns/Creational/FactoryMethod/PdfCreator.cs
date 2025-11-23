namespace FactoryMethod;
public class PdfCreator : IDocumentCreator
{
    public IDocument CreateDocument()
    {
        return new Pdf();
    }
}
