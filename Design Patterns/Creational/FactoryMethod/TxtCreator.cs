namespace FactoryMethod;
public class TxtCreator : IDocumentCreator
{
    public IDocument CreateDocument()
    {
        return new Txt();
    }
}
