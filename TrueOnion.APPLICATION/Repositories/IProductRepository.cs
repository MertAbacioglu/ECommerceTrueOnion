﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<IEnumerable<Product>> GetProductsWithCategory();
        public Task<IEnumerable<Product>> GetProductsByPriceRange(decimal min, decimal max);
    }
}
