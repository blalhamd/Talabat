namespace Talabat.Core.Specifications
{
    public class Pagination
    {
        public int PageIndex { get; set; } = 1;

        private int _PageSize  = 10;
        public int PageSize
        {
            get { return _PageSize; }
            set
            {
                if (PageSize > 10)
                {
                    _PageSize = 10;
                }
                else
                {
                    _PageSize = value;
                }
            }
        }
    }
}

// dbcontext.products.include(x => x.Types).include(x => x.Brands).where(Expression<Func<T,bool>> criteria)
