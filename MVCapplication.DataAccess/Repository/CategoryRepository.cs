using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCapplication.DataAccess.Data;
using MVCapplication.DataAccess.Repository.IRepository;
using MVCapplication.Models;

namespace MVCapplication.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db) //base robi ze przekazujemy do repository>category> te db
        {
            _db = db;
        }
        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }

    }
}
