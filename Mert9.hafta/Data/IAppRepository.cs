using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mert9.hafta.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T:class;
        void Delete<T>(T entity) where T:class;
        bool SaveAll();
        void Update<T>(T entity) where T : class;
    }
}
