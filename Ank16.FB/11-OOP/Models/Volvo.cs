using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
	internal class Volvo : Otomobil
	{
		private bool _engineStatus;

		public Volvo()
		{
			Console.WriteLine("Otomobil sınıfına ihtiyacım vardı. O oluştu sıra bende...");
		}
		public bool Sunroof { get; set; }
		public bool StartStop()
		{
			return _engineStatus ? false : true;
		}
	}
}