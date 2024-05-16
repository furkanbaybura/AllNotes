namespace _15_OOPHastaneSistemi
{

	public class Program
	{

		static void Main(string[] args)
		{
			Kullanıcı kullanıcı = new Kullanıcı();
			kullanıcı.Tc = "12345678915";
			Console.WriteLine(kullanıcı.Tc);

		}


	}

	public enum cinsiyet
	{
		Kadın = 1,
		Erkek


	}
	public enum kangrubu
	{
		Apozitif = 1,
		Anegatif,
		Bpozitif,
		Bnegatif,
		ABpozitif,
		ABnegatif,
		Sıfırpozitif,
		Sıfırnegatif,

	}
	public enum Alan
	{ 
		dahiliye=1,
		kbb,
		nöroloji,
		cildiye

	}
	public enum RandevuStatus
	{
		Yapıldı =1,
		Gelecek =2,
		İptal = 3,
		Ertelendi = 4

	}


	public class Hastane
	{
		private List<Hasta> Hastalar { get; set; } = new();
		private List<Doktor> Doktorlar { get; set; } = new();

		public void HastaKayıt(Hasta hasta)
		{
			Hastalar.Add(hasta);

		}
		public void DoktorEkle(Doktor doktor)
		{
			Doktorlar.Add(doktor);

		}
		public void RandevuAl(int doktorId,int hastaId,DateTime tarih)
		{
			var hastaKontrol = false;
			var doktorKontrol = false;
			var doktor= new Doktor();
			var hasta = new Hasta();
			foreach (var item in Hastalar)
			{
				if (item.Id == hastaId)
				{
					hastaKontrol = true;
					break;

				}

			}

			foreach (var item in Doktorlar)
			{
				if (item.Id == doktorId)
				{
					doktorKontrol = true;
					break;

				}

			}
			if (!(doktorKontrol && hastaKontrol))
			{
				Console.WriteLine("doktor veya hasta bulunamadı");
				return;
			}

			var control = true;
			foreach (var item in doktor.Randevular)
			{
				if (Math.Abs((int)(tarih - item.Date).TotalMinutes)<30)
				{
					control = false;
				}

			}

			doktor.Randevular.Add(new Randevu()
			{
				RandevuStatus = RandevuStatus.Gelecek,
				Date = tarih

			});



		}
		public void DoktorAra(Alan alan ,cinsiyet cinsiyet , int yas)
		{


		}
		public void RandevularımıGoruntule(int id)
		{
			foreach (var hasta in Hastalar)
			{
				if (hasta.Id==id)
				{
					foreach (var item in hasta.Randevular )
					{
						Console.WriteLine(item.Date);
						Console.WriteLine(hasta.Doktor);
						Console.WriteLine(hasta.Doktor.Alan);
						Console.WriteLine(item.RandevuStatus);
					}

				}
				

			}
		}
		public void HastalıkBilgilerim(Kullanıcı id)
		{


		}


	}

}
