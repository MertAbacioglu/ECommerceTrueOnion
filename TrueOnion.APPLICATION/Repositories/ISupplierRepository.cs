﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.DOMAIN.Entities.Concrates;

namespace TrueOnion.APPLICATION.Repositories
{
    public interface ISupplierRepository : IGenericRepository<Supplier>
    {
        public Task<IEnumerable<Supplier>> GetSuppliersWithProducts();
    }
}
