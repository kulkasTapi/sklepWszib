﻿using System;
using System.Collections.Generic;
using System.Text;
using Shop.Core.Domain;
using System.Linq;

namespace Shop.Core.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private static readonly ISet<Product> _products = new HashSet<Product>()
        {
            new Product("Laptop", "Electronics", 3500),
            new Product("Jeans", "Trousers", 150),
            new Product("Hummer", "Tools", 50)
        };
        public Product Get(Guid id) => _products.SingleOrDefault(x => x.Id == id);

        public IEnumerable<Product> GetAll() => _products;

        public void Add(Product product) => _products.Add(product);

    }
}
