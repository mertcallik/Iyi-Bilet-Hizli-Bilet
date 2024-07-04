using Mert9.hafta.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mert9.hafta.Models
{
    public class DataContext : DbContext
    {
        public DataContext():base("name=A3TGroup")
        {
        }

        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Bilet> Biletler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Tasit> Tasitlar { get; set; }
        public DbSet<Tur> Turlar { get; set; }

    }
}
