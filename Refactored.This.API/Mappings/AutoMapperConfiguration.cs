using AutoMapper;
using Refactored.This.Model.Entities;

namespace Refactored.This.API.ViewModels.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<ProductOption, ProductOptionViewModel>();
                cfg.AddProfile<ViewModelToDomain>();
            });
        }
    }
}
