using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
	internal sealed class XC90 : Volvo
	{
		public XC90()
		{
			Console.WriteLine("Volvo sınıfına ihtiyacım vardı. O oluştu sıra bende...");
		}
		public bool DortCekerMi { get; set; }
	}
}