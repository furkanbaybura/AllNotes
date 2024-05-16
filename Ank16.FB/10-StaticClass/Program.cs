
namespace StatikSiniflar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//StaticOrnek1();
			StaticOrnek2();

			Console.ReadLine();
		}

		private static void StaticOrnek2()
		{
			BankMusterisi b1 = new BankMusterisi();
			b1.SiradakiNumara();

			BankMusterisiDegil bd1 = new BankMusterisiDegil();
			bd1.SiradakiNumara();

			BankMusterisi b2 = new BankMusterisi();
			b2.SiradakiNumara();

			BankMusterisiDegil bd2 = new BankMusterisiDegil();
			bd2.SiradakiNumara();

			BankCalisani bc1 = new BankCalisani();
			bc1.SiradakiNumara();

			BankCalisani bc2 = new BankCalisani();
			bc2.SiradakiNumara();

			BankMusterisiDegil bd3 = new BankMusterisiDegil();
			bd3.SiradakiNumara();
		}

		private static void StaticOrnek1()
		{
			Sayac s1 = new Sayac();

			Console.WriteLine(s1.GetHashCode() + " " + s1.SonDurum); // 1

			Sayac s2 = new Sayac();

			Console.WriteLine(s2.GetHashCode() + " " + s2.SonDurum); // 2

			Sayac s3 = new Sayac();

			Console.WriteLine(s3.GetHashCode() + " " + s3.SonDurum); // 3

			Sayac s4 = new Sayac();

			Console.WriteLine(s4.GetHashCode() + " " + s4.SonDurum); // 4

			Console.WriteLine("--------------");

			Sayac.SayacDegistir(15);

			Console.WriteLine(s1.GetHashCode() + " " + s1.SonDurum); // ?
			Console.WriteLine(s2.GetHashCode() + " " + s2.SonDurum); // ?
			Console.WriteLine(s3.GetHashCode() + " " + s3.SonDurum); // ?
			Console.WriteLine(s4.GetHashCode() + " " + s4.SonDurum); // ?
		}
	}

	public class Sayac
	{
		private static int _sayac;

		public Sayac()
		{
			_sayac++;
		}

		public int SonDurum => _sayac;

		public static void SayacDegistir(int d)
		{
			_sayac = d;
		}
	}

	public static class Numarator
	{
		private static int _sayacBankaCalisani = new Random().Next(1, 101);
		private static int _sayacBireyselMusteri = new Random().Next(101, 201);
		private static int _sayacOzelMusteri = new Random().Next(201, 301);
		private static int _sayacBankaMusterisi = new Random().Next(301, 401);
		private static int _sayacBankaMusterisiDegil = new Random().Next(401, 501);

		static Numarator()
		{
			Console.WriteLine("-----------------------");
			Console.WriteLine(_sayacBankaCalisani);
			Console.WriteLine(_sayacBireyselMusteri);
			Console.WriteLine(_sayacOzelMusteri);
			Console.WriteLine(_sayacBankaMusterisi);
			Console.WriteLine(_sayacBankaMusterisiDegil);
			_sayacBankaMusterisi = 100;
			Console.WriteLine(_sayacBankaMusterisi);
			Console.WriteLine("-----------------------");
		}

		public static int YeniSıraNumarasi(MusteriTipi musteriTipi)
		{
			int siraNumarasi = musteriTipi switch
			{

				MusteriTipi.BankaMusterisi => _sayacBankaMusterisi++,
				MusteriTipi.BankaMusterisiDegil => _sayacBankaMusterisiDegil++,
				MusteriTipi.BankaCalisani => _sayacBankaCalisani++,
				MusteriTipi.BireyselMusteri => _sayacBireyselMusteri++,
				MusteriTipi.OzelMusteri => _sayacOzelMusteri++
			};

			return siraNumarasi;
		}

		public enum MusteriTipi
		{
			BankaMusterisi,
			BankaMusterisiDegil,
			BankaCalisani,
			BireyselMusteri,
			OzelMusteri
		}
	}

	public class BankMusterisi
	{
		private int _siraNo;
		public BankMusterisi()
		{
			_siraNo = Numarator.YeniSıraNumarasi(Numarator.MusteriTipi.BankaMusterisi);
		}

		public void SiradakiNumara()
		{
			Console.WriteLine("Banka Müştersi : " + _siraNo);
		}
	}

	public class BankMusterisiDegil
	{
		private int _siraNo;
		public BankMusterisiDegil()
		{
			_siraNo = Numarator.YeniSıraNumarasi(Numarator.MusteriTipi.BankaMusterisiDegil);
		}

		public void SiradakiNumara()
		{
			Console.WriteLine("Banka Müştersi Değil : " + _siraNo);
		}
	}

	public class BankCalisani
	{
		private int _siraNo;
		public BankCalisani()
		{
			_siraNo = Numarator.YeniSıraNumarasi(Numarator.MusteriTipi.BankaCalisani);
		}

		public void SiradakiNumara()
		{
			Console.WriteLine("Banka Çalışanı : " + _siraNo);
		}
	}
}