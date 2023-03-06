using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Server.Services.CategoriesServices
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context) {

            _context = context;
        }
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var categories = await _context.categories.ToListAsync();
            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
        }
    }
}
