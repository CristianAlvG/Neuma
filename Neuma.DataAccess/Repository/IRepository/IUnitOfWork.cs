using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuma.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ITopFeatureRepository TopFeature { get; }


        void Save();
    }
}
