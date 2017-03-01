using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace rentcar.EntityFramework.Repositories
{
    public abstract class rentcarRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<rentcarDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected rentcarRepositoryBase(IDbContextProvider<rentcarDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class rentcarRepositoryBase<TEntity> : rentcarRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected rentcarRepositoryBase(IDbContextProvider<rentcarDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
