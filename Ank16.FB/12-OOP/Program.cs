using Ank16Kutuphanesi.Araclar;
using Ank16Kutuphanesi.Araclar.Abstract;
using Ank16Kutuphanesi.Matematik;
using Ank16Kutuphanesi.OgrenciYonetimSistemi;
using Ank16Kutuphanesi.OgrenciYonetimSistemi.Abstract;
using OOPWithClassLib.Lib;
using System.Linq;
using System.Linq.Expressions;
using Memur = Ank16Kutuphanesi.OgrenciYonetimSistemi.Memur;
using MemurYapi = OOPWithClassLib.Lib.Memur;

namespace OOPWithClassLib
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Aritmatik aritmatik = new Aritmatik();
			//aritmatik.f

			//OOPKalitimSoyutlama();
			//OOPInterfaceSoyutlama();
			//OOPAbstractSoyutlama();
			//LooselyCoupling();

			//OOPPolymorphzim();

			//StructClassUse();

			EnumMetotlari();


			Console.ReadLine();
		}

		private static void EnumMetotlari()
		{
			string ogrenciTipi = Enum.GetName(typeof(OgrenciTipi), 3);
			string[] ogrenciTipiAdlari = Enum.GetNames(typeof(OgrenciTipi));

			foreach (var item in ogrenciTipiAdlari)
			{

				Console.WriteLine(item + " " + item.GetType());
			}

			string[] ConsoleKeyList = Enum.GetNames(typeof(ConsoleKey));

			string consoleKeyAdi = Enum.GetName(typeof(ConsoleKey), 50);

			//if(Console.ReadKey().Key == ConsoleKey.Enter)
			//{
			//    Console.WriteLine("Entera bastın");
			//}
			//else
			//{
			//    Console.WriteLine("Enter dışında bir tuşa bastın");
			//}

			Array ogrenciTipiDegerleri = Enum.GetValues(typeof(OgrenciTipi));

			foreach (var item in ogrenciTipiDegerleri)
			{

				Console.WriteLine(item + " " + item.GetType());
			}

			bool ogrenciProfmu = Enum.IsDefined(typeof(OgrenciTipi), "Prof");
			bool ogrenciLisansmi = Enum.IsDefined(typeof(OgrenciTipi), "Lisans");

			bool esitmi = Enum.Equals(OgrenciTipi.Lise, MebOgrenciTipi.Lise);
			bool esitmi2 = Enum.Equals(OgrenciTipi.Lisans, OgrenciTipi.Lisans);

		}

		private static void StructClassUse()
		{
			KoordinatStruct koordinats;
			koordinats = new KoordinatStruct();
			koordinats.X = 50;
			koordinats.Y = 25;

			Console.WriteLine(koordinats.X + " " + koordinats.Y);

			KoordinatClass koordinatc;
			koordinatc = new KoordinatClass();
			koordinatc.X = 50;
			koordinatc.Y = 25;

			Console.WriteLine(koordinatc.X + " " + koordinatc.Y);

			Console.WriteLine("----------");

			Calisan calian1 = new Calisan("Göksel", "Kalyoncu", "123456789", new DateOnly(1980, 1, 1));

			Console.WriteLine(calian1.AdSoyad() + " " + calian1.TcNo + " " + calian1.YasKontrol(50));

			MemurYapi memur = new MemurYapi("Göksel", "Kalyoncu", "123456789", new DateOnly(1980, 1, 1), "1111", 8);

			Console.WriteLine(memur.AdSoyad() + " " + memur.TcNo + " " + memur.YasKontrol(50) + " " + memur.Maas());
		}

		private static void OOPPolymorphzim()
		{
			Aritmatik aritmatik = new Aritmatik();
			int sonuc = aritmatik.Topla(5, 3, 4); // Metot aşırı yükleme 3 tane int parametre ile çalışna metotu buldu.
												  //aritmatik.Topla(5, 3.2, 4); // Metot aşırı yükleme 3 tane parametre int, double, int ile çalışna metotu bulamadı.

			Console.WriteLine(sonuc);
			Console.WriteLine("-------");

			Arac ford = new Otomobil("Ford", "Mustang", "1969");
			Arac fordTır = new Tır("Ford", "F-Max", "2010");

			Surucu surucu1 = new Surucu();
			surucu1.Adi = "Göksel";
			surucu1.Soyadi = "Kalyoncu";
			surucu1.EhliyetTipi = 10;
			//surucu1.Kullan(ford);
			surucu1.Kullan(fordTır);

			Surucu surucu2 = new Surucu();
			surucu2.Adi = "Kazım";
			surucu2.Soyadi = "Kalyoncu";
			surucu2.EhliyetTipi = 20;

			var sonucx = surucu1 + surucu2;

			if (surucu1 > surucu2)
			{
				//EhliyetiTipi 20 ve üzeri olan Tır ve Otomobil kullanabilir
				surucu1.Kullan(fordTır);
				surucu2.Kullan(ford);
			}
			else
			{
				//EhliyetiTipi 20 den küçük olan Otomobil kullanabilir
				surucu2.Kullan(fordTır);
				surucu1.Kullan(ford);
			}

		}

		private static void LooselyCoupling()
		{
			Otomobil otomobil = new Otomobil("Ford", "XC90", "2023");
			Tır tir = new Tır("Volvo", "XC90", "2023");
			//otomobil.Calistir();
			//otomobil.Sur();
			//otomobil.Dur();

			Surucu surucu = new Surucu();
			surucu.Adi = "Göksel";
			surucu.Soyadi = "Kalyoncu";

			surucu.Kullan(tir);
			surucu.Kullan(otomobil);
		}

		private static void OOPAbstractSoyutlama()
		{
			Printer p1 = new Printer();

			MudurYardimcisi mudurYardimcisi = new MudurYardimcisi();
			mudurYardimcisi.Ad = "Göksel";
			mudurYardimcisi.Soyad = "Kalyoncu";
			mudurYardimcisi.TcKimlikNo = "4444444";
			mudurYardimcisi.DogumTarihi = new DateOnly(1980, 1, 1);
			mudurYardimcisi.MudurYardimcisiSicilNo = "123456";



			Mudur Mudur = new Mudur();
			Mudur.Ad = "Kazım Göksel";
			Mudur.Soyad = "Kalyoncu";
			Mudur.TcKimlikNo = "888888";
			Mudur.DogumTarihi = new DateOnly(1980, 1, 1);
			Mudur.MudurSicilNo = "99999";

			//p1.Write(mudurYardimcisi);

			Ogrenci ogrenci1 = new Ogrenci();
			ogrenci1.TcKimlikNo = "666666";
			ogrenci1.Ad = "Kazım";
			ogrenci1.Soyad = "Kalyoncu";
			ogrenci1.DogumTarihi = new DateOnly(1980, 1, 1);
			ogrenci1.OgrenciNo = "123";

			Kisi kisiOgrenci = ogrenci1;
			Kisi kisiMudurYardimcisi = mudurYardimcisi;

			mudurYardimcisi.KisiBilgi();
			kisiMudurYardimcisi.KisiBilgi();

			ogrenci1.KisiBilgi();
			kisiOgrenci.KisiBilgi();

			Mudur.KisiBilgi();


			Console.WriteLine(ogrenci1.Maasim());
			Console.WriteLine(kisiOgrenci.Maasim());
			Console.WriteLine(Mudur.Maasim());
			Console.WriteLine(mudurYardimcisi.Maasim());



		}

		private static void OOPInterfaceSoyutlama()
		{
			Printer p1 = new Printer();

			Ogrenci ogrenci1 = new Ogrenci();
			ogrenci1.TcKimlikNo = "123456";
			ogrenci1.Ad = "Göksel";
			ogrenci1.Soyad = "Kalyoncu";
			ogrenci1.DogumTarihi = new DateOnly(1980, 1, 1);
			ogrenci1.OgrenciNo = "123";

			IKisi kisi = ogrenci1;


			//short b = 5;
			//int a = b;

			//object c = a;
			//c = "Test";
			//c = false;


			kisi.Ad = "Kazım Göksel";


			Ogretmen ogretmen = new Ogretmen();
			ogretmen.TcKimlikNo = "654321";
			ogretmen.Ad = "Kazım";
			ogretmen.Soyad = "Kalyoncu";
			ogretmen.DogumTarihi = new DateOnly(1980, 1, 1);


			p1.Write(ogrenci1);
			p1.Write(kisi);
			p1.Write(ogretmen);
			//Console.WriteLine(ogrenci1.BildigiDiller());
			Console.WriteLine(kisi.BildigiDiller());
			Console.WriteLine(((IKisi)ogretmen).BildigiDiller());

			Console.ReadKey();

			Mudur mudur = new Mudur();
			mudur.TcKimlikNo = "654321";
			mudur.Ad = "ali";
			mudur.Soyad = "veli";
			mudur.DogumTarihi = new DateOnly(1980, 1, 1);


			MudurYardimcisi mudurYardimcisi = new MudurYardimcisi();
			mudurYardimcisi.TcKimlikNo = "654321";
			mudurYardimcisi.Ad = "Hasan";
			mudurYardimcisi.Soyad = "Hüseyin";
			mudurYardimcisi.DogumTarihi = new DateOnly(1980, 1, 1);


			p1.Write(ogrenci1);
			p1.Write(ogretmen);
			p1.Write(mudur);
			//p1.Write(mudurYardimcisi);
		}

		private static void OOPKalitimSoyutlama()
		{
			SozlesmeliMemur sm = new SozlesmeliMemur();

			Console.WriteLine("----");

			Ogrenci o1 = new Ogrenci();

			KatGorevlisi katGorevlisi = new KatGorevlisi();
			katGorevlisi.Ad = "Ali";
			katGorevlisi.Soyad = "Veli";
			katGorevlisi.TcKimlikNo = "123456";
			katGorevlisi.DogumTarihi = new DateOnly(1976, 1, 1);

			katGorevlisi.SicilNo = "123456789";

			katGorevlisi.GorevKati = "1. Kat";

			katGorevlisi.MesaiSaati = 8;

			decimal katGorevlisiMaasi = katGorevlisi.Maasim();

			Console.WriteLine($"TC No:{katGorevlisi.TcKimlikNo} Ad:{katGorevlisi.Ad} Soyad:{katGorevlisi.Soyad}");
			Console.WriteLine($"DT:{katGorevlisi.DogumTarihi} Sicil No:{katGorevlisi.SicilNo} Görev Katı:{katGorevlisi.GorevKati}");
			Console.WriteLine($"Maas:{katGorevlisiMaasi} ");

			Memur memur = new Memur();
			memur.Ad = "Hasan";
			memur.Soyad = "Hüseyin";
			memur.TcKimlikNo = "123456";
			memur.DogumTarihi = new DateOnly(1984, 1, 1);

			memur.SorumlulukAlanlari = new string[] { "Personel İşleri", "Öğrenci İşleri" };

			memur.SicilNo = "123456789";

			memur.MesaiSaati = 5;

			decimal memurMaasi = memur.Maasim();

			Console.WriteLine($"TC No:{memur.TcKimlikNo} Ad:{memur.Ad} Soyad:{memur.Soyad}");
			Console.WriteLine($"DT:{memur.DogumTarihi} Sicil No:{memur.SicilNo}");
			Console.WriteLine($"Görev Katı:{string.Join(',', memur.SorumlulukAlanlari)}");
			Console.WriteLine($"Maas:{memurMaasi} ");

			Personel p1 = new Personel();
			//Kisi k1 = new Kisi();
		}
	}

	public class Printer
	{
		//public void Write(Ogrenci kisi)
		//{
		//    Console.WriteLine($"{kisi.TcKimlikNo} {kisi.Ad} {kisi.Soyad}");
		//}

		//public void Write(Ogretmen kisi)
		//{
		//    Console.WriteLine($"{kisi.TcKimlikNo} {kisi.Ad} {kisi.Soyad}");
		//}

		//public void Write(Mudur kisi)
		//{
		//    Console.WriteLine($"{kisi.TcKimlikNo} {kisi.Ad} {kisi.Soyad}");
		//}

		//public void Write(MudurYardimcisi kisi)
		//{
		//    Console.WriteLine($"{kisi.TcKimlikNo} {kisi.Ad} {kisi.Soyad}");
		//}

		public void Write(IKisi kisi)
		{
			Console.WriteLine(kisi.GetType().Name);

			Console.WriteLine($"{kisi.TcKimlikNo} {kisi.Ad} {kisi.Soyad} {kisi.Yas()}");
		}

		//public void Write(Kisi kisi)
		//{
		//    Console.WriteLine(kisi.GetType().Name);

		//    Console.WriteLine($"{kisi.TcKimlikNo} {kisi.Ad} {kisi.Soyad} {kisi.Yas()}");
		//}
	}

	//public class Kumeler : Aritmatik
	//{
	//    public Kumeler()
	//    {
	//        base.f
	//    }
	//}

	public enum OgrenciTipi : byte
	{
		Lise = 2,
		OnLisans,
		Lisans,
		YuksekLisans,
		Doktora
	}

	public enum MebOgrenciTipi : byte
	{
		Lise = 1,
		OnLisans,
		Lisans = 4,
		YuksekLisans,
		Doktora
	}
}