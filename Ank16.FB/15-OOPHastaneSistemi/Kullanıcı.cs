namespace _15_OOPHastaneSistemi
{
	public class Kullanıcı
	{
		public Kullanıcı()
		{
			_id = new Random().Next(300, 9999);
		}
		public Kullanıcı(int id)
		{
			_id = id;
		}

		public string _tc;
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public string Tc
		{
			get
			{
				string val = "";
				for (int i = 0; i < _tc.Length; i++)
				{

					if (i >= 7)
					{
						val += "*";

					}
					else
					{
						val += _tc[i];
					}

				}

				return val;
			}


			set

			{
				_tc = value;
			}
		}
		private int _id { get; set; }
		public int Id { get; set; }
		public DateTime DogumTarihi { get; set; }
		public int Boy { get; set; }
		public int Kilo { get; set; }
		public cinsiyet cinsiyet { get; set; }
		public kangrubu kangrubu { get; set; }
	}





}
