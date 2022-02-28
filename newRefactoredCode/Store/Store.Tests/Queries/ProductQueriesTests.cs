using System.Collections.Generic;
using System.Linq;
using Store.Domain.Entities;
using Store.Domain.Queries;
using Xunit;

namespace Store.Tests.Queries
{
    public class ProductQueriesTests
    {
        private IList<Product> _products;

        public ProductQueriesTests()
        {
            _products = new List<Product>();
            _products.Add(new Product("Produto 01", 10, true));
            _products.Add(new Product("Produto 02", 20, true));
            _products.Add(new Product("Produto 03", 30, true));
            _products.Add(new Product("Produto 04", 40, false));
            _products.Add(new Product("Produto 05", 50, false));
        }

        [Fact]
        [Trait("Category","Queries")]
        public void Dado_a_consulta_de_produtos_ativos_deve_retornar_3()
        {
            var result = _products.AsQueryable().Where(ProductQueries.GetActiveProducts());
            Assert.Equal(result.Count(), 3);
        }

        [Fact]
        [Trait("Category","Queries")]
        public void Dado_a_consulta_de_produtos_inativos_deve_retornar_2()
        {
            var result = _products.AsQueryable().Where(ProductQueries.GetInactiveProducts());
            Assert.Equal(result.Count(), 2);
        }
    }
}
