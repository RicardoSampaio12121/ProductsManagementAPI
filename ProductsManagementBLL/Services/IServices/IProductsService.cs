﻿using ProductsManagementDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementBLL.Services.IServices
{
    public interface IProductsService
    {
        Task AddNewProduct(AddProductDto product);
    }
}
