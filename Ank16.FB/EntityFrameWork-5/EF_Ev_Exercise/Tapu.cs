using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ev_Exercise
{
	internal class Tapu
	{
		public int Id { get; set; }
		public string TapuAdi { get; set; }
		public int DaireId { get; set; }
		public Daire Daire { get; set; }
		
	}
}
