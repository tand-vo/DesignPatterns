public class OracleDBFactory : IDatabaseFactory
{
    public IDBCommand CreateCommandObject()
    {
        return new OracleDBCommand();
    }

    public IDBConnection CreateConnectionObject()
    {
        return new OracleDBConnection();
    }
}