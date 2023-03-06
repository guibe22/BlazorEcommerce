using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services.ProductServices
{
    public interface IProductService
    {
        List<Products> products { get; set; }
        Task GetProducts();
        Task<ServiceResponse<Products>> GetProduct(int Id);
    }
}
