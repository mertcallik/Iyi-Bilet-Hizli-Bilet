using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mert9.hafta.Entities
{

    public class Tur
    {
        public int TurId { get; set; }
        public DateTime HaraktetTime { get; set; }
        public string Destination { get; set; }
        public string DeparturePoint { get; set; }



        public override string ToString()
        {
            return $"* VARIŞ YERİ: {Destination.ToUpper()} | BAŞLANGIÇ: {DeparturePoint.ToUpper()} | HARAKET VAKTİ: {HaraktetTime} * {TurId}";
        }
    }

}
