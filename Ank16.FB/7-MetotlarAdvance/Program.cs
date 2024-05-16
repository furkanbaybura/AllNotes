namespace _7_MetotlarAdvance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Params Örneği için çalışma
			//try
			//{
			//    if (args[0] != "--u" && args[1] != null)
			//    {
			//        throw new ArgumentNullException("--u parametresi zorunludur.");
			//    }

			//    if (args[2] != "--p" && args[3] != null)
			//    {
			//        throw new ArgumentNullException("--p parametresi zorunludur.");
			//    }

			//    if(args[1] != "admin" || args[3] != "123456")
			//    {
			//        throw new UserOrPasswordWrongException("Kullanıcı veya adınız yanlıştır.");
			//    }

			//}
			//catch (Exception e)
			//{
			//    Console.WriteLine(e.Message);
			//}


			//Console.WriteLine("Hello, World!");

			//for (int i = 0; i < args.Length; i++)
			//{
			//    Console.WriteLine(args[i]);
			//} 
			#endregion


			/*
             * Değer Döndüren Metotlar ve Void
             * Parametreli ve Parametresiz Metotlar
             * 
             * Varsayılan Değerli ve Opsiyonel Parametreler
             */

			//int i = 'a';
			//char c = (char)65;

			#region İlk Örnek
			//short i = 5;
			//int j = 6;
			//double d = 7;

			//try
			//{
			//    int sonuc = Toplama(i, "a");

			//    Console.WriteLine(sonuc);
			//}
			//catch(Exception ex)
			//{

			//}

			//Array.IndexOf(new string[] { "a", "b", "c", }, "c");
			//Array.IndexOf(new int[] { 1, 2, 3 }, "b"); 
			#endregion

			#region İkinci Örnek
			//int[] numbers = new int[] { 1, 2, 3,4,5,6,7,8,9,10 };

			//int a = DiziElemanSay(numbers,3);
			//int b = DiziElemanTopla(numbers,3);

			//Hesapla(5, 6, 7);

			//Console.WriteLine(a);
			//Console.WriteLine(b); 
			#endregion


			//Params, ref ve out

			//Params

			// Kullanıcıdan gireceği sayıların toplamını ve ortalamasını veren bir metot yazılmasını istesem

			/*
             * 1
             * 5
             * 6
             * 9
             * 10
             * 25
             * 6
             * 
             * Toplam : 45 , Ortalama : 5
             * 
             */

			/*
             * 1 5 6 8 10 12 24
             * 
             * string ifade ' ' split edip. Tüm değerlerin Digiti olma kontrolu char.IsDigit() daha sonrada
             * gerekli matematiksel işlemleri yaparız.
             * 
             */

			/*
             * 
             * Metot(1,5,6)
             * Metot(1,2)
             * Metot(5,6,9,12,45)
             * 
             * 
             */

			#region Üçüncü Örnek
			//int[] sayilar = {1,2, 3};

			//string sonuc = ToplamVeOrtlamaWithOutParams(sayilar);
			//Console.WriteLine(sonuc);

			//Console.WriteLine("----");

			//sonuc = ToplamVeOrtlamaWithOutParams(new int[]{ 1, 2, 35, 6, 5, 12, 23});
			//Console.WriteLine(sonuc);

			//sonuc = ToplamVeOrtlama(1, 2, 35, 6, 5, 12, 23);
			//Console.WriteLine(sonuc);

			//Console.WriteLine("----");

			//sonuc = ToplamVeOrtlama(1,5,6);
			//Console.WriteLine(sonuc);

			//sonuc = ToplamVeOrtlama(1,2);
			//Console.WriteLine(sonuc);

			//sonuc = ToplamVeOrtlama(5,6,9,12,45);
			//Console.WriteLine(sonuc); 
			#endregion

			//string sonuc = ToplamVeOrtlama(5, 6, 9, 12, 45);
			//Console.WriteLine(sonuc); 

			#region ref ve out Örnekleri
			//string tekmiCiftmi;
			//TekMiCiftMi(20,out tekmiCiftmi); //Tanım yapılacak, ilk değer atama zorunluluğu metot içinde


			//string haftaningunu = "";
			//HaftaSonuMuHaftaIcimMi(DateTime.Now,ref haftaningunu); // Tanım yapılacak, ilk değer atama zorunlu

			//Console.WriteLine(tekmiCiftmi);
			//Console.WriteLine(haftaningunu);

			//haftaningunu = "";
			//HaftaSonuMuHaftaIcimMi(new DateTime(2024,1,13), ref haftaningunu);
			//Console.WriteLine(haftaningunu);

			//double ustelsonuc;
			//UstAlma(2, 3, out ustelsonuc);

			//Console.WriteLine(ustelsonuc); 
			#endregion

			#region Metot İmzası ve Metot Overloadin
			//Metot imzası ilgili metotdun ismi, varsa parametreleri ve sayısı ve bu parametrelerinin tipleri ile işaretlemesine metot izması denir.

			//object vize1 = 50;
			//object vize2 = 100;
			//object final = 75;


			//if (vize1.GetType() == typeof(int) && 
			//    vize2.GetType() == typeof(int) && 
			//    final.GetType() == typeof(int))
			//{
			//    NotHesaplaInt((int)vize1, (int)vize2, (int)final);
			//}

			//if (vize1.GetType() == typeof(long) &&
			//    vize2.GetType() == typeof(long) &&
			//    final.GetType() == typeof(long))
			//{
			//    NotHesaplaLong((long)vize1, (long)vize2, (long)final);
			//}

			//if (vize1.GetType() == typeof(double) &&
			//    vize2.GetType() == typeof(double) &&
			//    final.GetType() == typeof(double))
			//{
			//    NotHesaplaDouble((double)vize1, (double)vize2, (double)final);
			//}

			//object vize1 = 50;
			//object vize2 = 100;
			//object final = 75;

			//NotHesapla((int)vize1, (int)vize2, (int)final);
			//NotHesapla((long)vize1, (long)vize2, (long)final);
			//NotHesapla((double)vize1, (double)vize2, (double)final); 
			#endregion

			Console.WriteLine(Faktoriyel(5));
			Console.WriteLine(FaktoriyelRec(5));


			Console.ReadKey();

		}


		/// <summary>
		/// Girilen iki sayının toplamın veren bir fonksiyondur.
		/// </summary>
		/// <param name="n1">Girilen ilk değer int tipindedir.</param>
		/// <param name="n2">Girilen ikinci değer object tipindedir.</param>
		/// <returns>n1 ve n2 değerlerinin toplamını int tipinde geri döndürür.</returns>
		/// <exception cref="ArgumentException"></exception>
		static int Toplama(int n1, object n2)
		{
			//1. Yol işlem güvenliği için
			//int i;
			//int.TryParse(n2.ToString(), out i);


			//var sonuc = n1 + i;
			//return sonuc;

			//2.Yol işlem güvenliği için

			//if (n2.GetType() != typeof(int)) // System.Int32 // Int32
			//{
			//    Console.WriteLine("Girilen ikinci değer bir sayıla değer değildir. İşlem burada iptal edilmiştir.");
			//    return -1;
			//}

			if (n2.GetType() != typeof(int)) // System.Int32 // Int32
			{
				throw new ArgumentException("Uygun tipte veri gönderilmedi.");
				//return -1;
			}

			var sonuc = n1 + (int)n2;
			return sonuc;
		}

		static int DiziElemanSay(int[] array, int index = default(int))
		{

			int sayac = 0;
			int j = 0;

			foreach (int i in array)
			{
				if (j >= index)
				{
					sayac++;
				}

				j++;
			}

			return sayac;
		}

		static int DiziElemanTopla(int[] array, int index = default(int))
		{

			int sayac = 0;
			int j = 0;

			foreach (int i in array)
			{
				if (j >= index)
				{
					sayac += i;
				}

				j++;
			}

			return sayac;
		}

		static int Hesapla(int a, int c, int d, int b = 0)
		{
			return 0;
		}

		static string ToplamVeOrtlamaWithOutParams(int[] sayilar)
		{
			int countNumbers = sayilar.Length;
			int sumNumbers = 0;

			foreach (int i in sayilar)
				sumNumbers += i;


			return "Toplam : " + sumNumbers + " Ortalama : " + (sumNumbers / countNumbers);

		}

		static string ToplamVeOrtlama(params int[] numbers)
		{

			int countNumbers = numbers.Length;
			int sumNumbers = 0;

			foreach (int i in numbers)
				sumNumbers += i;


			return "Toplam : " + sumNumbers + " Ortalama : " + (sumNumbers / countNumbers);
		}

		static void TekMiCiftMi(int number, out string sonuc)
		{
			//if (number % 2 == 0)
			//    sonuc = "Çift";
			//else
			//    sonuc = "Tek";

			//sonuc = "Tek";
			//if (number % 2 == 0)
			//    sonuc = "Çift";

			sonuc = (number % 2 == 0) ? "Çift" : "Tek";

		}

		static void HaftaSonuMuHaftaIcimMi(DateTime dt, ref string sonuc)
		{

			switch (dt.DayOfWeek)
			{
				case DayOfWeek.Monday:
				case DayOfWeek.Tuesday:
				case DayOfWeek.Wednesday:
				case DayOfWeek.Thursday:
				case DayOfWeek.Friday:
					sonuc = "Hafta içi";
					break;
				case DayOfWeek.Saturday:
				case DayOfWeek.Sunday:
					sonuc = "Hafta sonu";
					break;
				default:
					sonuc = "Bilinmiyor";
					break;
			}
		}

		static void UstAlma(int taban, int ust, out double sonuc)
		{
			//sonuc = Math.Pow(taban,ust);

			sonuc = 1;

			for (int i = 0; i < ust; i++)
			{
				sonuc *= taban;
			}
		}

		static double NotHesaplaInt(int vize1, int vize2, int final)
		{
			int vort = (vize1 + vize2) / 2; // iki tam sayının bölümü tam sayı sonuç verir. 5/2 = 2 dir
											// iki sayıdan biri ondalıklı ise bölümü ondalıklıdır.
											// Örnek 5.1/2 = 2.55 dir

			double sonuc = (vort * 0.3) + (final * 0.7);

			return sonuc;
		}

		static double NotHesaplaLong(long vize1, long vize2, long final)
		{
			long vort = (vize1 + vize2) / 2;

			double sonuc = (vort * 0.3) + (final * 0.7);

			return sonuc;
		}

		static double NotHesaplaDouble(double vize1, double vize2, double final)
		{
			double vort = (vize1 + vize2) / 2;

			double sonuc = (vort * 0.3) + (final * 0.7);

			return sonuc;
		}

		static double NotHesapla(int vize1, int vize2, int final)
		{
			int vort = (vize1 + vize2) / 2; // iki tam sayının bölümü tam sayı sonuç verir. 5/2 = 2 dir
											// iki sayıdan biri ondalıklı ise bölümü ondalıklıdır.
											// Örnek 5.1/2 = 2.55 dir

			double sonuc = (vort * 0.3) + (final * 0.7);

			return sonuc;
		}

		static double NotHesapla(long vize1, long vize2, long final)
		{
			long vort = (vize1 + vize2) / 2;

			double sonuc = (vort * 0.3) + (final * 0.7);

			return sonuc;
		}

		static double NotHesapla(double vize1, double vize2, double final)
		{
			double vort = (vize1 + vize2) / 2;

			double sonuc = (vort * 0.3) + (final * 0.7);

			return sonuc;
		}

		static int Faktoriyel(int number)
		{
			int faktoriyel = 1;

			for (int i = 1; i <= number; i++)
			{
				faktoriyel *= i;
			}

			return faktoriyel;
		}

		static int FaktoriyelRec(int number)
		{
			if (number == 0 || number == 1)
				return 1;

			return number * FaktoriyelRec(number + 1); // 5! = 5*4! = 5*4*3! = 5*4*3*2!
		}
	}

	internal class UserOrPasswordWrongException : Exception
	{
		public UserOrPasswordWrongException()
		{ }

		public UserOrPasswordWrongException(string message) : base(message)
		{

		}
	}
}
