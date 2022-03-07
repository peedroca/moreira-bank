namespace MoreiraBank.Manager.Data.Repositories
{
    internal interface ICommand<T>
    {
        void Create(T entity);
        void Update(T entity);
    }
}
