using System.Collections.Generic;
using System.Linq;
using nothinbutdotnetstore.web.application.model;

namespace nothinbutdotnetstore.web.application.stubs
{
    public class StubProductsRepository : ProductRepository
    {
        
        public IEnumerable<Product> get_products_in(Department parent)
        {
            return Enumerable.Range(1, 100).Select(x => new Product { name = x.ToString("Product 0") });
        }
    }
}