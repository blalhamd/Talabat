namespace Talabat.Core.Specifications
{
    public class ProductWithSpecifications : BaseSpecification<Product>
    {
        
        public ProductWithSpecifications() :base()
        {
            base.Includes = SetIncludes();
        }

        public ProductWithSpecifications(Expression<Func<Product,bool>> Criteria): base(Criteria)
        {
            base.Includes = SetIncludes();
            base.Criteria = Criteria;
        }

        public ProductWithSpecifications(Sorting<Product> sorting) : base(sorting)
        {
            base.Includes = SetIncludes();
            base.Sorting = sorting;
        }

        private List<string> SetIncludes()
        {
            return ["Brand", "ProductType"];
        }
    }
}
