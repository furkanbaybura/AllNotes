using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.ConsoleApp.Data.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Credit { get; set; }
        public DateOnly LessonBeginDate { get; set; }
        public bool IsActive { get; set; }
    }
}
