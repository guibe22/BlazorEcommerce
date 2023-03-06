﻿namespace BlazorEcommerce.Server.Services.CategoriesServices
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();

    }
}
