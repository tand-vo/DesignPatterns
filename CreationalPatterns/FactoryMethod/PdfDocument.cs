public class PdfDocument : IDocument
{
    public void Close()
    {
        Console.WriteLine("The PdfDocument is closing.");
    }

    public void Open()
    {
        Console.WriteLine("The PdfDocument is opening.");
    }

    public void Revert()
    {
        Console.WriteLine("The PdfDocument is reverting.");
    }

    public void Save()
    {
        Console.WriteLine("The PdfDocument is saving.");
    }
}
