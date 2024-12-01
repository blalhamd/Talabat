namespace Talabat.DataAccess.Specification
{
    // is responsible to build the query => dbcontext.products.include(x => x.Types).include(x => x.Brands).where(Expression<Func<T,bool>> criteria)
    // so I need context and specifications
    public static class SpecificationEvalutor<T> where T : BaseEntity
    {
        public static IQueryable<T> GetQuery(DbSet<T> context, ISpecification<T> spec)
        {
            var query = context.AsQueryable(); // dbcontext.Products


            if (spec.Includes is not null)
            {
                foreach (var item in spec.Includes)
                {
                    query = query.Include(item);  // dbcontext.Products.Include(x=> x.Types).include(x=> x.Brands)
                }
            }

            if (spec.Criteria is not null)
            {
                query = query.Where(spec.Criteria); // dbcontext.Products.Include(x=> x.Types).include(x=> x.Brands).where(spec.Criteria)
            }

            if (spec.Sorting is not null)
            {
                var sortingString = $"{spec.Sorting.property} {(spec.Sorting.IsAsc ? "asc" : "desc")}";  // "Price desc"
                query = query.OrderBy(sortingString); // Use dynamic OrderBy by install System.Linq.Dynamic.Core Package
            }

            #region another way for sorting
            /*  
            if (spec.Sorting is not null)
            {
                // Dynamically build the OrderBy/OrderByDescending expression
                var parameter = Expression.Parameter(typeof(T), "x");
                var property = Expression.Property(parameter, spec.Sorting.property); // Get the property by name
                var lambda = Expression.Lambda(property, parameter);

                if (spec.Sorting.IsAsc)
                {
                    // Use reflection to call OrderBy
                    query = query.Provider.CreateQuery<T>(
                        Expression.Call(
                            typeof(Queryable),
                            "OrderBy",
                            new Type[] { typeof(T), property.Type },
                            query.Expression,
                            lambda
                        ));
                }
                else
                {
                    // Use reflection to call OrderByDescending
                    query = query.Provider.CreateQuery<T>(
                        Expression.Call(
                            typeof(Queryable),
                            "OrderByDescending",
                            new Type[] { typeof(T), property.Type },
                            query.Expression,
                            lambda
                        ));
                }
            }
            */
            #endregion

            if (spec.Pagination is not null)
            {
                var PageIndex = spec.Pagination.PageIndex;
                var PageSize = spec.Pagination.PageSize;
                var TotalCount = query.Count();

                if(PageSize > 0) // to avoid Exception divide on zero
                {
                    var TotalPages = (int)Math.Ceiling((double)TotalCount / PageSize);

                    if (TotalPages >= PageIndex)
                    {
                        query = query.Skip((PageIndex - 1) * PageSize).Take(PageSize);
                    }
                }
                
            }

            return query;
        }
    }
}
