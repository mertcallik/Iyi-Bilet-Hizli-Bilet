using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Mert9.hafta.Entities;
using Mert9.hafta.Models;

namespace Mert9.hafta.Data
{
    public class AppRepository : IAppRepository
    {
        
        public void Add<T>(T entry) where T : class
        {
            using (DataContext context = new DataContext())
            {
                var entity = context.Entry(entry);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }


        }

        public void Delete<T>(T entry) where T : class
        {
            using (DataContext context = new DataContext())
            {
                var entity = context.Entry(entry);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public bool SaveAll()
        {
            using (DataContext context = new DataContext())
            {
                return context.SaveChanges() !=1;
            }
        }

        public void Update<T>(T entry) where T : class
        {
            using (DataContext context = new DataContext())
            {
                var entity = context.Entry(entry);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<T> GetAll<T>() where T : class
        {
            using (DataContext context = new DataContext())
            {
                var dbSet = context.Set<T>();
                return dbSet.ToList();
            }
        }

    }
}
