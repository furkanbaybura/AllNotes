using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar.Arabalar
{
	public class Bmw
	{
		private string _model;

		//private short _motorHacmi;
		//private byte _motorGucu;
		//private bool _otomatikVites;
		//private byte _yakitDeposuHacmi;
		//private byte _bagajHacmi;
		//private bool _otomatikAyna;

		private ArabaDonanim _arabaDonanim;

		//public Bmw(string model, short motorHacmi, byte motorGucu, bool otomatikVites, byte yakitDeposuHacmi, bool otomatikAyna)
		//{
		//    _model = model;
		//    _motorHacmi = motorHacmi;
		//    _motorGucu = motorGucu;
		//    _otomatikVites = otomatikVites;
		//    _yakitDeposuHacmi = yakitDeposuHacmi;
		//    _otomatikAyna = otomatikAyna;

		//}

		public Bmw(string model, ArabaDonanim arabaDonanim = null)
		{
			_model = model;
			if (arabaDonanim != null)
				_arabaDonanim = arabaDonanim;
			else
				_arabaDonanim = new ArabaDonanim(2000, 150, true, 50, 500, true);
		}

		public string Model { get { return _model; } }
		public ArabaDonanim ArabaDonanim { get { return _arabaDonanim; } }
	}
}