namespace Talabat.Core.Specifications
{
    public interface ISpecification<T> where T : BaseEntity
    {
        public Expression<Func<T,bool>> Criteria { get; set; }
        //public List<Expression<Func<T,object>>> Includes { get; set; }
        public List<string> Includes { get; set; }
        public Sorting<T> Sorting { get; set; }
        public Pagination Pagination { get; set; }
    }
}

// dbcontext.products.include(x => x.Types).include(x => x.Brands).where(Expression<Func<T,bool>> criteria)
