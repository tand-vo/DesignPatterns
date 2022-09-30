public interface IDatabaseFactory
{
    public IDBCommand CreateCommandObject();
    public IDBConnection CreateConnectionObject();
}