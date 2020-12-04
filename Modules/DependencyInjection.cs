using AzureDeployTest.Repository;
using AzureDeployTest.Repository.Repository;
using AzureDeployTest.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AzureDeployTest.Modules
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection service)
        {
            service.AddSingleton(typeof(IProdutoRepository), typeof(ProdutoRepository));
            service.AddTransient(typeof(IProdutoService), typeof(ProdutoService));
        }
    }
}