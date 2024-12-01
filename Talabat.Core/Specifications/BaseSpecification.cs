namespace Talabat.Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T> where T : BaseEntity
    {
        public Expression<Func<T, bool>> Criteria { get; set; }
        //public List<Expression<Func<T, object>>> Includes { get; set; } = new List<Expression<Func<T, object>>>();
        public List<string> Includes { get; set; } = new List<string>(); // second overload from Iclude method
        public Sorting<T> Sorting { get; set; }
        public Pagination Pagination { get; set; } 

        public BaseSpecification() // GetAll don't need Criteria
        {
            Pagination  = new Pagination();
        }

        public BaseSpecification(Expression<Func<T,bool>> CriteriaExpression) // GetById need Criteria
        {
            Criteria = CriteriaExpression;
        }

        public BaseSpecification(Sorting<T> sorting)
        {
            Sorting = sorting;
            Pagination = new Pagination();
        }
    }
}

// dbcontext.products.include(x => x.Types).include(x => x.Brands).where(Expression<Func<T,bool>> criteria)

/*
   Note, public List<Expression<Func<T, object>>> Includes { get; set; } = new List<Expression<Func<T, object>>>();
   will help you in seeing that exist and select like that (x=> x.Brand) means did't need to go to entity to see Nav

   while public List<string> Includes { get; set; } = new List<string>();
   will have to go to class to see Nav and put it like that ["Brand","Type"]


 
 */