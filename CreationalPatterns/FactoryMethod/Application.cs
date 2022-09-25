public abstract class Application
{
    private readonly IDocument _doc;

    public Application()
    {
        _doc = CreateDocument();
    }

    protected abstract IDocument CreateDocument();

    public void OpenDocument()
    {
        _doc.Open();
    }

    public void CloseDocument()
    {
        _doc.Close();
    }

    public void RevertDocument()
    {
        _doc.Revert();
    }

    public void SaveDocument()
    {
        _doc.Save();
    }
}