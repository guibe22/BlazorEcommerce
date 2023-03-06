namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    { 
        Task<ServiceResponse<List<Products>>> GetProductsAsync();
        Task<ServiceResponse<Products>> GetProductAsync(int Id);
        Task<ServiceResponse<List<Products>>> GetProductsByCategory(String CategoryUrl);
    }
}
