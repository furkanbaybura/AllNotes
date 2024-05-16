using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar.Arabalar
{
	public class ArabaDonanim
	{
		private short _motorHacmi;
		private byte _motorGucu;
		private bool _otomatikVites;
		private byte _yakitDeposuHacmi;
		private short _bagajHacmi;
		private bool _otomatikAyna;

		public ArabaDonanim(short motorHacmi, byte motorGucu, bool otomatikVites, byte yakitDeposuHacmi, short bagajHacmi, bool otomatikAyna)
		{
			_motorHacmi = motorHacmi;
			_motorGucu = motorGucu;
			_otomatikVites = otomatikVites;
			_yakitDeposuHacmi = yakitDeposuHacmi;
			_bagajHacmi = bagajHacmi;
			_otomatikAyna = otomatikAyna;
		}

		public void GetArabaDonanim()
		{
			string vites = (_otomatikVites) ? "Otomatik" : "Düz";
			string ayna = (_otomatikAyna) ? "Otomatik" : "Değil";

			string donanimBilgi = string.Format(@"Motor Hacmi : {0}
Motor Gücü : {1}
Vites : {2}
Yakıt Deposu Hacmi : {3}
Bagaj Hacmi : {4}
Otomatik Ayna : {5}", _motorHacmi, _motorGucu, vites, _yakitDeposuHacmi, _bagajHacmi, ayna);

			Console.WriteLine(donanimBilgi);
		}

		public string GetArabaDonanimStr()
		{
			string vites = (_otomatikVites) ? "Otomatik" : "Düz";
			string ayna = (_otomatikAyna) ? "Otomatik" : "Değil";

			string donanimBilgi = string.Format(@"Motor Hacmi : {0}
Motor Gücü : {1}
Vites : {2}
Yakıt Deposu Hacmi : {3}
Bagaj Hacmi : {4}
Otomatik Ayna : {5}", _motorHacmi, _motorGucu, vites, _yakitDeposuHacmi, _bagajHacmi, ayna);

			return donanimBilgi;
		}
	}
}