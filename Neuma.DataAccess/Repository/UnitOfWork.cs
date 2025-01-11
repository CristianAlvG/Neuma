using Neuma.DataAccess.Data;
using Neuma.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuma.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public ITopFeatureRepository TopFeature { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            TopFeature = new TopFeatureRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
