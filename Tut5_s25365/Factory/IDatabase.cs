namespace Tut5_s25365.Factory
{
    public interface IDatabase
    {
        void Connect();
        void ExecuteQuery(string query);
    }

}
