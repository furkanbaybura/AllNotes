using OOP.Models;
using System.Text;

namespace OOP
{
	#region Bir önceki çalışmalar Program class
	//internal class Program
	//{
	//    public const int Pazartesi = 1;
	//    public const int Sali = 2;
	//    public const int Carsamba = 3;
	//    public const int Persmbe = 4;
	//    public const int Cuma   = 5;
	//    public const int Cumartesi = 6;
	//    public const int Pazar = 0;

	//    static void Main(string[] args)
	//    {
	//        //DateTime dt = DateTime.Now;


	//        //if((int)dt.DayOfWeek == Pazartesi) { }
	//        //if ((int)dt.DayOfWeek == Sali) { }
	//        //if ((int)dt.DayOfWeek == Pazartesi) { }
	//        //if ((int)dt.DayOfWeek == Pazartesi) { }
	//        //if ((int)dt.DayOfWeek == Pazartesi) { }
	//        //if ((int)dt.DayOfWeek == Pazartesi) { }

	//        //if ((int)dt.DayOfWeek == Gunler.)

	//        Ogrenci ogrenci1;

	//        //ogrenci1.Adi = "Kazım";

	//        new Ogrenci();

	//        Ogrenci ogrenci2 = new Ogrenci();

	//        ogrenci2.Adi = "Göksel";

	//        //Console.WriteLine(ogrenci2.Adi);

	//        ogrenci2.Adi = "Kazım";
	//        //Console.WriteLine(ogrenci2.Adi);

	//        ogrenci2.Soyadi = "Kalyoncu";

	//        while (true)
	//        {
	//            Console.Clear();
	//            Console.Write("Doğum tarihi gün : ");
	//            int.TryParse(Console.ReadLine(), out int gun);
	//            Console.Write("Doğum tarihi ay : ");
	//            int.TryParse(Console.ReadLine(), out int ay);
	//            Console.Write("Doğum tarihi yıl : ");
	//            int.TryParse(Console.ReadLine(), out int yil);

	//            try
	//            {
	//                ogrenci2.DogumTarihi = new DateTime(yil, ay, gun);
	//                break;
	//            }
	//            catch (Exception ex)
	//            {
	//                Console.WriteLine(ex.Message);
	//                Thread.Sleep(2000);
	//            }
	//        }



	//        //ogrenci2._adi = "Kazım";
	//        //Console.WriteLine(ogrenci2.Adi);

	//        //Console.WriteLine(ogrenci2.DogumTarihi);
	//        Console.WriteLine(ogrenci2.Adi.ToUpper() + " " + ogrenci2.Soyadi.ToUpper());
	//        Console.WriteLine(ogrenci2.AdSoyad());

	//        ogrenci2.Name = "Kazım";
	//        ogrenci2.Surname = "Kalyoncu";

	//        Console.WriteLine(ogrenci2.FullName());

	//        Console.WriteLine("------------");

	//        ogrenci2.SetAd("Ali");
	//        ogrenci2.SetAd("Veli");
	//        ogrenci2.SetAd("Yusuf");
	//        ogrenci2.SetAd("Hakan");

	//        Console.WriteLine(ogrenci2.Ad);

	//        Console.WriteLine("------------");

	//        Ogrenci ogrenci3 = new Ogrenci("Ali","Veli");

	//        Console.WriteLine(ogrenci3.Ad);
	//        Console.WriteLine(ogrenci3.Soyad);


	//        Console.ReadLine();
	//    }

	//    enum Gunler
	//    {
	//        Pazar,
	//        Pazartesi,
	//        Sali,
	//        Carsamba,
	//        Persembe,
	//        Cuma,
	//        Cumartesi

	//    }
	//} 
	#endregion

	internal class Program
	{
		static Random random = new Random();
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			//RenkliEkran();
			//OOPEncapsulation();
			//OOPInharitance();
			OOPInharitance2();


			Console.ReadLine();

		}

		private static void OOPInharitance2()
		{
			XC90 xC90 = new XC90();

		}

		private static void OOPInharitance()
		{

			Kisi kisi = new Kisi("Göksel", "Kalyoncu", "12345678909");

			Ogrenci ogrenci = new Ogrenci("Göksel", "Kalyoncu", "12345678909");
			//Ogretmen ogretmen = new Ogretmen();

			//ogrenci

			//ogrenci.Adi = "Göksel";
			//ogrenci.Soyadi = "Kalyoncu";
			//ogrenci.BursluMu = true;

			Console.WriteLine(ogrenci.AdSoyad + " " + ogrenci.TcNo + " " + ogrenci.Cinsiyet + " " + ogrenci.OgrenciNo);

		}

		/*
         * Erişim belirleyiciler, kullanım amacı oluşturulan sınıfın içinde ki üyeler belirli koşul altın ya da tamamen erişiminin yasaklanması istenildiğin kullanılan 
         * keywords dir.
         * 
         * 4 + 2  tane erişim belirleyic vardır.
         * 
         * internal, + Class, diğer üyeler
         * public, + Class, diğer üyeler
         * private, üyeler için
         * protected üyeler için
         * 
         * protected internal, üyeler için
         * private protected üyeler için
         * 
         * 
         */

		private static void RenkliEkran()
		{
			Console.SetBufferSize(100, 30);
			Console.SetWindowSize(100, 30);

			while (true)
			{
				Console.BackgroundColor = (ConsoleColor)(random.Next(16));

				Console.SetCursorPosition(random.Next(100), random.Next(30));
				Console.Write(' ');
			}
		}

		private static void OOPEncapsulation()
		{
			string ad = "";
			string soyad = "";
			string tcno = "";
			Ogrenci ogrenci;
			DateTime dt = new DateTime();

			while (true)
			{
				try
				{
					if (ad == "")
					{
						Console.Write("Adınız : ");
						ad = Console.ReadLine();
					}


					if (soyad == "")
					{
						Console.Write("Soyadınız : ");
						soyad = Console.ReadLine();
					}

					if (tcno == "")
					{
						Console.Write("TC No : ");
						tcno = Console.ReadLine();
					}

					ogrenci = new Ogrenci("a", "b", "1");

					// Logic olduğunu düşünelim...
					Console.WriteLine("Cinsiyetiniz (E/K): ");
					ogrenci.Cinsiyet = (Console.ReadKey().Key == ConsoleKey.E) ? Cinsiyet.Erkek : (Console.ReadKey().Key == ConsoleKey.K) ? Cinsiyet.Kadın : Cinsiyet.Erkek;

					if (dt.Year == 1)
					{
						Console.WriteLine("Doğum Tarihi");
						dt = Convert.ToDateTime(Console.ReadLine());
						ogrenci.DogumTarihi = DateOnly.FromDateTime(dt);
					}


					break;
				}
				catch (Exception ex)
				{
					string[] hataMesaji = ex.Message.Split('@');
					string hataMesajiKodu = hataMesaji[0];
					string hataMesajiAciklamasi = hataMesaji[1];

					Console.WriteLine("Girmiş olduğunuz bilgiler");
					Console.WriteLine($"Ad:{ad} Soyad:{soyad} TC No:{tcno}");
					Console.WriteLine(hataMesajiAciklamasi);

					if (hataMesajiKodu == "Hata Kod:101")
						tcno = "";

					if (hataMesajiKodu == "Hata Kod:102")
						ad = "";

					if (hataMesajiKodu == "Hata Kod:103")
						soyad = "";

					if (hataMesajiKodu == "Hata Kod:104")
						dt = new DateTime();
				}
			}


			Console.WriteLine(ogrenci.TcNo + " " + ogrenci.Adi + " " + ogrenci.Soyadi + " " + ogrenci.DogumTarihi + " " + ogrenci.Cinsiyet);
		}
	}
}