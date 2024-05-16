using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
	internal class KaraAraci : Arac
	{
		public KaraAraci()
		{
			Console.WriteLine("Araç sınıfına ihtiyacım vardı. O oluştu sıra bende...");
		}
		public byte TekerSayisi { get; set; }
	}
}