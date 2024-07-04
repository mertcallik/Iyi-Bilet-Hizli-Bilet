using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mert9.hafta.Entities
{
    public class Personel
    {
        public Personel()
        {
            JoinDate=DateTime.Now;
        }
        public int PersonelId { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
        public int PersonelSalary { get; set; }
        public DateTime PersonelBirthDate { get; set; }
        public DateTime JoinDate { get; set; }

    }
}
