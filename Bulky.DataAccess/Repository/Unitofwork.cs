using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class Unitofwork : IUnitofwork
    {
        private readonly ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public Unitofwork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
                
        }
        

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
