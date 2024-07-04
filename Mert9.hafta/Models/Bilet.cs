using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mert9.hafta.Entities
{

    public class Bilet
    {
        public override string ToString()
        {
            return TurId + "";
        }

        public int Id { get; set; }
        public string BiletType { get; set; }
        public int BiletPrice { get; set; }
        public int TurId { get; set; }
        public int MusteriId { get; set; }
        public int TasitId { get; set; }

    }
}
