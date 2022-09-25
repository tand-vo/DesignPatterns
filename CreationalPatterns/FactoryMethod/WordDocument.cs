public class WordDocument : IDocument
{
    public void Close()
    {
        Console.WriteLine("The WordDocument is closing.");
    }

    public void Open()
    {
        Console.WriteLine("The WordDocument is opening.");
    }

    public void Revert()
    {
        Console.WriteLine("The WordDocument is reverting.");
    }

    public void Save()
    {
        Console.WriteLine("The WordDocument is saving.");
    }
}