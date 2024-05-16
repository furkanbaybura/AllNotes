using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16CodeFirst.Entitites
{   
    internal class Muhendis
    {
        [Key]
        public int MühendisTekilAnahtar { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public List<Araba> Arabalar { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
