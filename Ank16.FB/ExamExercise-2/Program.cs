using System.Diagnostics.Contracts;
using System.Xml.Schema;

namespace FurkanBayburUygulamaOOP
{
	internal class Program
	{
		static void Main (string[] args)
		{
			KahveSatisIslem kahveSatisIslem = new KahveSatisIslem();

			kahveSatisIslem.MusteriAl();
			kahveSatisIslem.MusteriAl();
			kahveSatisIslem.MusteriAl();
		
		}

		



	}

	public enum Status
	{
		Dolu = 1,
		Bos

	}


}
