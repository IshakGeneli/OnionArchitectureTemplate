using OAT.Domain.Entities;

namespace OAT.Application.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
