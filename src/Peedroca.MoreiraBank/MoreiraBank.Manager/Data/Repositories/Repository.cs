﻿namespace MoreiraBank.Manager.Data.Repositories
{
    internal class Repository<T> : IQuery<T>, ICommand<T>
    {
        private readonly _68_praontemContext context;

        public Repository()
        {
            context = new _68_praontemContext();
        }

        public void Create(T entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
