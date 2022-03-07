namespace MoreiraBank.Manager.Data.Repositories
{
    internal class Repository<T> : IQuery<T>, ICommand<T> where T : class
    {
        protected readonly _68_praontemContext context;

        public Repository()
        {
            context = new _68_praontemContext();
        }

        public virtual void Create(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            context.Add(entity);
        }

        public virtual T Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAll() => context.Set<T>().ToList();

        public virtual void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges() => context.SaveChanges();
    }
}
