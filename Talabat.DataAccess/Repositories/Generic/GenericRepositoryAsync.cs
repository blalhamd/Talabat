namespace Talabat.DataAccess.Repositories.Generic
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        private readonly AppDbContext _dbcontext;
        private DbSet<T> _entity;

        public GenericRepositoryAsync(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            _entity = _dbcontext.Set<T>();
        }
        
        public DbSet<T> Entity { get => _entity; set => _entity = value; }

        public async Task<IList<T>> GetAllAsync(string[] Includes = null!)
        {
            var data = Entity.AsQueryable();

            if(Includes is not null)
            {
                foreach (var Nav in Includes)
                {
                    data = data.Include(Nav);
                }
            }

            return await data.ToListAsync();
        }
        public async Task<T> GetByIdAsync(object id)
        {
            return await Entity.FirstOrDefaultAsync(x => x.Id == (int)id);
        }


        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression, string[] Includes = null!)
        {
            var query = Entity.AsQueryable();

            if (Includes is not null)
            {
                foreach (var nav in Includes)
                {

                    query = query.Include(nav);
                }
            }
            return query.FirstOrDefaultAsync(expression);
        }

        public async Task AddAsync(T entity)
        {
            await Entity.AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() =>
            {
                Entity.Update(entity);
            });
        }

        public async Task DeleteAsync(object id)
        {
            var entity = await GetByIdAsync(id);

            await Task.Run(() =>
            {
                Entity.Remove(entity);
            });
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() =>
            {
                Entity.Remove(entity);
            });
        }

        public async Task<IList<T>> GetAllWithSpecAsync(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).ToListAsync();
        }

        public async Task<T> GetByIdWithSpecAsync(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).FirstOrDefaultAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> specification)
        {
            return SpecificationEvalutor<T>.GetQuery(Entity, specification);
        }
    }
}
