using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16CodeFirst.Entitites
{
    internal class Araba
    {
        public int Id { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }
        
        public int PLNo { get; set; }

        public Plaka Plaka { get; set; }

        public int PersonNo { get; set; }
        public  Kisi Kisi { get; set; }

        public List<Muhendis> Muhendisler { get; set; }

        public override string ToString()
        {
            return Marka + " " + Model + " " +Plaka.Numarasi;
        }

    }

}