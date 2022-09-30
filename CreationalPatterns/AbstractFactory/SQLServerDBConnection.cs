public class SQLServerDBConnection : IDBConnection
{
    public void Open()
    {
        Console.WriteLine("SQLServerDBConnection is opening.");
    }
}