using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
	internal class Arac
	{
		public Arac()
		{
			Console.WriteLine("Son notktada ben varım. Araç sınıfı oluşturuluyor...");
		}
		public ushort MotorHacmi { get; set; }
		public ushort MotorGucu { get; set; }
	}
}