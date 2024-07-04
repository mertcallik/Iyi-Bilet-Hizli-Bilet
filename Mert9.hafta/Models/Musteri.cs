using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mert9.hafta.Entities
{
   public class Musteri
    {
        public int MusteriId { get; set; }
        public string MusteriName { get; set; }
        public string MusteriSurName { get; set; }
        public string MusteriNation { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Pass { get; set; }
    }
}
