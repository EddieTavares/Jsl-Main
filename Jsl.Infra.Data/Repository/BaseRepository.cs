using Jsl.Domain.Entities;
using Jsl.Domain.Interfaces;
using Jsl.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Jsl.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly Db _Db;

        public BaseRepository(Db Db)
        {
            _Db = Db;
        }

        public void Insert(TEntity obj)
        {
            _Db.Set<TEntity>().Add(obj);
            _Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _Db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _Db.SaveChanges();
        }

        public void Delete(int id)
        {
            _Db.Set<TEntity>().Remove(Select(id));
            _Db.SaveChanges();
        }

        public IList<TEntity> Select() =>
            _Db.Set<TEntity>().ToList();

        public TEntity Select(int id) =>
            _Db.Set<TEntity>().Find(id);

    }
}
