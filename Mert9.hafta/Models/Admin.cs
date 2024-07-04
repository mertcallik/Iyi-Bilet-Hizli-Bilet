using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mert9.hafta.Entities
{
   public class Admin
    {
        public Admin()
        {
            UserName = Email;
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Pass { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


    }
}
