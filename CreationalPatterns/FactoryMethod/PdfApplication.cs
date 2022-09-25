public class PdfApplication : Application
{
    protected override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}