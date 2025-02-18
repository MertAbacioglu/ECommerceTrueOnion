﻿using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.ViewModels.Category;
using TrueOnion.APPLICATION.ViewModels.ProductFeature;
using TrueOnion.APPLICATION.ViewModels.ProductSupplier;
using TrueOnion.APPLICATION.ViewModels.Supplier;
using TrueOnion.DOMAIN.Enums;

namespace TrueOnion.APPLICATION.ViewModels.Product
{
    public class ProductVM : IBaseVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public CategoryVM CategoryVM { get; set; }
        public ProductFeatureVM ProductFeatureVM { get; set; }
        public List<ProductSupplierVM> ProductSupplierVMs { get; set; }
    }
}