

internal class Program
{
    private static void Main(string[] args)
    {
        Application wordApp = new WordApplication();
        wordApp.OpenDocument();
        wordApp.RevertDocument();
        wordApp.SaveDocument();
        wordApp.CloseDocument();

        Application pdfApp = new PdfApplication();
        pdfApp.OpenDocument();
        pdfApp.RevertDocument();
        pdfApp.SaveDocument();
        pdfApp.CloseDocument();
    }
}