namespace New_Era.Infrastructure.Bases
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;

        public GenericRepo(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task AddRangeAsync(ICollection<T> entities)
        {
            await dbContext.Set<T>().AddRangeAsync(entities);
            await dbContext.SaveChangesAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return dbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            dbContext.Database.CommitTransaction();
        }

        public async Task DeleteAsync(int id)
        {
            var item = await dbContext.Set<T>().FindAsync(id);
            dbContext.Set<T>().Remove(item);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(ICollection<T> entities)
        {
            dbContext.Set<T>().RemoveRange(entities);
            await dbContext.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public IQueryable<T> GetTableAsTracking()
        {
            var items = dbContext.Set<T>().AsQueryable();
            return items;
        }

        public IQueryable<T> GetTableNoTracking()
        {
            var items = dbContext.Set<T>().AsNoTracking().AsQueryable();
            return items;
        }

        public void RollBack()
        {
            dbContext.Database.RollbackTransaction();
        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            dbContext.Set<T>().Update(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(ICollection<T> entities)
        {
            dbContext.Set<T>().UpdateRange(entities);
            await dbContext.SaveChangesAsync();
        }
    }
}
