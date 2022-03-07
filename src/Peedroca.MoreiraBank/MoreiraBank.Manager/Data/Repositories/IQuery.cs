namespace MoreiraBank.Manager.Data.Repositories
{
    internal interface IQuery<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
