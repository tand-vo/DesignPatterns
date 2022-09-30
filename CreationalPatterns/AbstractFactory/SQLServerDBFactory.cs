public class SQLServerDBFactory : IDatabaseFactory
{
    public IDBCommand CreateCommandObject()
    {
        return new SQLServerDBCommand();
    }

    public IDBConnection CreateConnectionObject()
    {
        return new SQLServerDBConnection();
    }
}