public class OracleDBConnection : IDBConnection
{
    public void Open()
    {
        Console.WriteLine("OracleDBConnection is opening.");
    }
}