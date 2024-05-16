using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
	internal class Otomobil : KaraAraci
	{
		public Otomobil()
		{
			Console.WriteLine("Kara Aracı sınıfına ihtiyacım vardı. O oluştu sıra bende...");
		}
		public ushort BagajHacmi { get; set; }
	}
}