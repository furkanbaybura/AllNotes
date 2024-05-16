using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.ExampleApp.Context.Entities
{
    public class EmployeeInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateOnly BirthDate { get; set; }

        //public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
