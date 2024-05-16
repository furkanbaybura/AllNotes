using System.ComponentModel.Design;

namespace FurkanBayburUygulamaOOP
{
	public class KasaCalisani : ICalisan
	{
		public int CalisanId { get; set; }
		public Status Status { get; set; } = Status.Bos;
		public DateTime SiparisAlmaZaman { get; set; }

		public Siparis SiparisAl()
		{
			Siparis siparis = new Siparis();
			Status = Status.Dolu;
			SiparisAlmaZaman = DateTime.Now;
			KahveMenu();
			bool control = true;
			string alınanKahve = Console.ReadLine().ToString();
			while (control)
			{
				switch (alınanKahve)
				{
					case "1":
						{
							Latte latte = new Latte();
							siparis.Kahveler.Add(latte);
							EventMenu();
							control = false;
							break;

						}

					case "2":
						{
							Mocha mocha = new Mocha();
							siparis.Kahveler.Add(mocha);
							EventMenu();
							control = false;
							break;
						}


					case "3":
						{
							TurkKahvesi turkkahvesi = new TurkKahvesi();
							siparis.Kahveler.Add(turkkahvesi);
							EventMenu();
							control = false;
							break;
						}
					case "4":
						{
							Cappucino cappucino = new Cappucino();
							siparis.Kahveler.Add(cappucino);
							EventMenu();
							control = false;
							break;

						}



						
				}

			}



			siparis.FiyatHesaplama();

			return siparis;
		}

		public void KahveMenu()
		{
			Console.WriteLine("Kahve Seçiniz");
			Console.WriteLine("1 :  Maccihato");
			Console.WriteLine("2 :  Latte");
			Console.WriteLine("3 :  Mocha");
			Console.WriteLine("4 :  Türk Kahvesi");

		}
		public void EventMenu()
		{
			Console.WriteLine("Ekstra Eklemek İstediğiniz Ürünü Seçiniz");
			Console.WriteLine("1 : Ekstra Süt ");
			Console.WriteLine("1 : Ekstra Espresso Shot ");
			Console.WriteLine("1 : Ekstra Krema ");
		}
		public void HesapAl(Siparis s)
		{
			Console.WriteLine("Ödemeniz Gereken Toplam Ücret : " + s.ToplamFiyat);

		}
	}


}
