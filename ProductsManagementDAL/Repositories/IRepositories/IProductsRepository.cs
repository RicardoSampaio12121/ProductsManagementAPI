﻿using ProductsManagementDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementDAL.Repositories.IRepositories
{
    public interface IProductsRepository
    {
        Task AddNewProduct(AddProductDto product);
    }
}
