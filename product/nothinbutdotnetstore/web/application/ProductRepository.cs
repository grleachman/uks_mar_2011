


using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.web.application.model;


namespace nothinbutdotnetstore.web.application
{
    public interface ProductRepository
    {
        IEnumerable<Product> get_products_in(Department department);
    }
}