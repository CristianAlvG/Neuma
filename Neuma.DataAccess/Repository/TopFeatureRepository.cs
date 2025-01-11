using Neuma.DataAccess.Data;
using Neuma.DataAccess.Repository.IRepository;
using Neuma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuma.DataAccess.Repository
{
    public class TopFeatureRepository: Repository<TopFeature>, ITopFeatureRepository
    {
        public readonly ApplicationDbContext _db;

        public TopFeatureRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(TopFeature topFeature)
        {
            //_db..Update(topFeature);
        }
    }
}
