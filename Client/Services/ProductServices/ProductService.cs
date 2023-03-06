
using BlazorEcommerce.Shared;
using System.Net.Http.Headers;
using static System.Net.WebRequestMethods;

namespace BlazorEcommerce.Client.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action ProductsChanged;

        public List<Products> products { get ; set ; }
        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task GetProducts(string? CategoryUrl = null)
        {
            var results = CategoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Products>>>("api/Product") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Products>>>($"api/Product/category/{CategoryUrl}");
                ;
            if (results != null && results.Data != null)
            {
                products = results.Data;
            }

            ProductsChanged.Invoke();
        }

        public async Task<ServiceResponse<Products>> GetProduct(int Id)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Products>>($"api/Product/{Id}");

            return result;
        }

       
    }
}
