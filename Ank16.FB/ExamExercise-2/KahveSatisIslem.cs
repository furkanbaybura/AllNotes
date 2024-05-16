namespace FurkanBayburUygulamaOOP
{
	public class KahveSatisIslem
	{
		private List<KasaCalisani> KasaCalisanList { get; set; }

		public KahveSatisIslem()
		{
			KasaCalisanList = new List<KasaCalisani>();

			KasaCalisanList.Add(new() { CalisanId = 1 });
			KasaCalisanList.Add(new() { CalisanId = 2 });
			KasaCalisanList.Add(new() { CalisanId = 3 });
			KasaCalisanList.Add(new() { CalisanId = 4 });

		}
		public void MusteriAl()
		{
			PersonelKontrol();
			var control = false;
			foreach (var item in KasaCalisanList)
			{
				if (item.Status == Status.Bos)
				{
					Console.WriteLine(item.CalisanId + " Numaralı Personel Siparişinizi Alıyor");
					var result = item.SiparisAl();
					Console.WriteLine("Toplam Tutar : " + result.ToplamFiyat);
					foreach (var kahve in result.Kahveler)
					{
						Console.WriteLine(kahve.KahveTuru + " ");
					}
					Console.WriteLine();
					foreach (var envanter in result.Envanterler)
					{

						Console.WriteLine(envanter.EkstraEnvanterler + " ");
					}
					Console.WriteLine();
					OdemeAl(result);
					break;
				}

			}

			if (control)
			{
                Console.WriteLine("Kasalar Dolu Sıranızı Bekleyiniz");

            }


		}
		private void OdemeAl(Siparis s)
		{
			foreach (var item in KasaCalisanList)
			{

				item.HesapAl(s);


			}

		}

		private void PersonelKontrol()
		{
			foreach (var item in KasaCalisanList)
			{
				if (item.Status == Status.Dolu && DateTime.Now.AddMinutes(-2) > item.SiparisAlmaZaman)
				{


					item.Status = Status.Bos;
					item.SiparisAlmaZaman = DateTime.Now.AddHours(-5);

				}

			}


		}


	}


}
