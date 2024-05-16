using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16CodeFirst.Entitites
{
    [Table("People")]
    internal class Kisi
    {
        public int KisiTekilAnahtar { get; set; }
        [Column("Name")]
        public string Ad { get; set; }
        [Column(TypeName = "nvarchar(39)")]
        public string Soyad { get; set; }
        [NotMapped]
        public string SicilNo { get; set; }
        public string Adres {  get; set; }
        public long TcKimlikNo { get; set; }
        public List<Araba> Arabalar { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
