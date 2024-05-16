using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.ConsoleApp.Data.Entities
{
    public class BookOne
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// IDENTITY (1,1)
        public int BookOneNumber { get; set; } // BookOneNumber int Primary Key Identity

        public string BookOneName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public byte[] RowVersion { get; set; }

        //public int BookTypeId { get; set; }

        public BookTypeOne BookTypeOne { get; set; }
    }
}
