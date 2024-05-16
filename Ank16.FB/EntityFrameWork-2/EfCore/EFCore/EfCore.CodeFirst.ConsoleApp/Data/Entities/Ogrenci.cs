using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.ConsoleApp.Data.Entities
{
    public class Ogrenci
    {

        // id,Id,ID OgrenciID,

        public int Id { get; set; }

        //[Key]
        //public int OgrenciNo { get; set; }

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Eposta { get; set; }
        public string? Telefon { get; set; }

        [NotMapped]
        public string AdSoyad => $"{Adi} {Soyadi}";

        public int Yas { get; set; }
    }
}
