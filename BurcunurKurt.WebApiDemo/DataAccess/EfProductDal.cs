using BurcunurKurt.WebApiDemo.Entities;

namespace BurcunurKurt.WebApiDemo.DataAccess
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {

    }
}
