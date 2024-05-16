using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ev_Exercise
{
	internal class Kisi
	{
		public int Id { get; set; }
		public string KisiAdi { get; set; }

		
		public ICollection<Daire> Daireler { get; set; }

	}
}
