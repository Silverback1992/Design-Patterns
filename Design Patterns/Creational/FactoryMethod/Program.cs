using FactoryMethod;

IDocumentCreator pdfCreator = new PdfCreator();
var pdf = pdfCreator.CreateDocument();

IDocumentCreator txtCreator = new TxtCreator();
var txt = txtCreator.CreateDocument();
