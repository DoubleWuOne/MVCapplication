using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCapplication.Models;

namespace MVCapplication.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product> // T is Category
    {
        void Update(Product obj);
    }
}
