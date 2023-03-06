using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services.ProductServices
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Products> products { get; set; }
        Task GetProducts(String? CategoryUrl = null);
        Task<ServiceResponse<Products>> GetProduct(int Id);
    }
}
