using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16CodeFirst.Entitites
{
	[Index("Numarasi", IsUnique = true)]
	internal class Plaka
    {
        public int Id { get; set; }
        
        public string Numarasi { get; set; }

        public Araba Araba { get; set; }

        public override string ToString()
        {
            return Numarasi;
        }


    }
}
