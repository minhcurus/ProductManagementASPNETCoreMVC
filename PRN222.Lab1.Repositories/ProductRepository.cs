﻿using PRN222.Lab1.Repositories.BusinessObjects;
using PRN222.Lab1.Repositories.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN222.Lab1.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(Product p) => ProductDAO.DeleteProduct(p);

        public Product GetProductById(int id) => ProductDAO.GetProductById(id);

        public List<Product> GetProducts() => ProductDAO.GetProducts();


        public void SaveProduct(Product p) => ProductDAO.SaveProduct(p);


        public void UpdateProduct(Product p) => ProductDAO.UpdateProduct(p);

    }
}
