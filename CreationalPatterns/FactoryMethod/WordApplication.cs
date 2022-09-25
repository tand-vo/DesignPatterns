public class WordApplication : Application
{
    protected override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}