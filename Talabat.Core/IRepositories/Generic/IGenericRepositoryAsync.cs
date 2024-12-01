namespace Talabat.Core.IRepositories.Generic
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {
        Task<IList<T>> GetAllAsync(string[] Includes = null!);
        Task<IList<T>> GetAllWithSpecAsync(ISpecification<T> secification);
        Task<T> GetByIdAsync(object id);
        Task<T> GetByIdWithSpecAsync(ISpecification<T> specification);
        Task<T> FirstOrDefaultAsync(Expression<Func<T,bool>> expression, string[] Includes = null!);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(object id);
        Task DeleteAsync(T entity);
    }
}


/*
 * 
 * Note, I used BaseEntity to enable access Id from it, and use this accessed Id in some methods that take 
 * Predicit like FirstOrDefault
 * 
 * 
 * if I have another data store will make talabat.DataAccess2, this talabat.DataAccess2 will have another GenericRepo2 
 * and this GenericRepo2 will deal with another context that belong that another data store with condition 
 * it's must implement IGenericRepositoryAsync
 * 
 * 
 * 
 * Task<IList<T>> GetAllWithoutSpecAsync(Expression<Func<T,bool>> criteria, string[] Includes = null!);
 * I want to say (ISpecification<T> spec) is alternative to (Expression<Func<T,bool>> criteria, string[] Includes = null!)
 * 
 */
