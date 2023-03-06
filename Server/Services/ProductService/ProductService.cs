namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Products>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Products>>()
            {
                Data = await _context.products.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Products>> GetProductAsync(int Id)
        {
            var response = new ServiceResponse<Products>();
            var products = await _context.products.FindAsync(Id);
            if(products== null)
            {
                response.Success= false;
                response.Message = "este producto no existe";
            }
            else
            {
                response.Data = products;
            }

            return response;
        }
    }
}
