using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.ConsoleApp.Data.Entities
{
    [Table("Öğretmenler")]
    public class Teacher
    {
        [Column("No",Order = 1, TypeName = "tinyint")]
        public byte Id { get; set; }

        [Column("Adı", Order = 3, TypeName = "nvarchar(25)")]
        public string Name { get; set; }

        [Column("Soyadı", Order = 4, TypeName = "nvarchar(25)")]
        public string Surname { get; set; }

        [Column("EPosta", Order = 2, TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Column("Doğum Tarihi", Order = 5, TypeName = "date")]
        public DateOnly BirthDate { get; set; }

        [Column("Adres", TypeName = "ntext")]
        public string Address { get; set; }

        [Column("Dersler", Order = 6, TypeName = "ntext")]
        public string Lessons { get; set; }

        [Column("EkBilgi1")]
        [Required]
        public string? EkBilgi1 { get; set; }

        [Column("EkBilgi2")]
        public string? EkBilgi2 { get; set; }

        [Column("EkBilgi3")]
        [Required(AllowEmptyStrings = true)]
        public string EkBilgi3 { get; set; }
    }
}
