using AutoMapper;
using Refactored.This.Model.Entities;

namespace Refactored.This.API.ViewModels.Mappings
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductOption, ProductOptionViewModel>();
        }
    }
}
