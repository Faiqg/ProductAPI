using System;

namespace Refactored.This.API.ViewModels
{
    public class ProductOptionViewModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
