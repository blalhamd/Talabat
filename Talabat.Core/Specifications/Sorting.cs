namespace Talabat.Core.Specifications
{
    public class Sorting<T> where T : BaseEntity
    {
        //public Func<T, object> property { get; set; } = (x => "Id");
        public string property { get; set; } = "Id";
        public bool IsAsc { get; set; } = true;
       
    }
}

// dbcontext.products.include(x => x.Types).include(x => x.Brands).where(Expression<Func<T,bool>> criteria)
