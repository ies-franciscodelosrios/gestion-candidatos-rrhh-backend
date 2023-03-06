using Microsoft.EntityFrameworkCore;

namespace IGApi.Repository
{
    public class Repository<T> where T : class
    {

        protected DbSet<T> DbSet { get; }
        protected readonly ApplicationDBContext _dbContext;

        public Repository(ApplicationDBContext applicationDBContext) 
        {
            this.DbSet = applicationDBContext.Set<T>();
            this._dbContext = applicationDBContext;
        }

        public IQueryable<T> AsQueryable()
        {
            return this.DbSet;
        }

        public async Task<T> Get(object id)
        {
            return await this.DbSet.FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await this.DbSet.ToListAsync();
        }

        public async Task<bool> Insert(T x)
        {
            if (await DbSet.AddAsync(x) != null)
            {
                await this._dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(object id)
        {
            if(await DbSet.FindAsync(id) != null)
            {
                DbSet.Remove(await DbSet.FindAsync(id));
                await this._dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> Update(T x)
        {
            DbSet.Update(x);
            this._dbContext.SaveChanges();
            return true;
        }
    }
}
