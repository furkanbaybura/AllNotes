using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.ConsoleApp.Data.Entities
{
    public class BookTwo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        //public int BookTypeId { get; set; } // BookTypeTwoId

        //[ForeignKey("BookTypeId")]
        //public BookTypeTwo BookTypeTwo { get; set; }

        [ForeignKey("BookTypeTwo")]
        public int BookTypeId { get; set; } // BookTypeTwoId

        public BookTypeTwo BookTypeTwo { get; set; }
    }
}
