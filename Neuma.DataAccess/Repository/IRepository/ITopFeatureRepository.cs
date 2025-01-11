using Neuma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuma.DataAccess.Repository.IRepository
{
    public interface ITopFeatureRepository: IRepository<TopFeature>
    {
        void Update(TopFeature objFeature);
    }
}
