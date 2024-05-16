using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ev_Exercise
{
	internal class Daire
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int KisiId { get; set; }
		public int Floor { get; set; }

		public Kisi Kisi { get; set; }
		public Tapu Tapu { get; set; }
		
	}
}
