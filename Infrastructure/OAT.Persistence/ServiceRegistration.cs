using Microsoft.Extensions.DependencyInjection;
using OAT.Application.Abstract;
using OAT.Persistence.Concrete;

namespace OAT.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
