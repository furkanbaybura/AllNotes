namespace _2_OperatorsAndConversion
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//SayHello();

			//AritmatikIslemler();

			//MantiksalIslemler();

			//ConvertIslemler();

			//CastIslemler();

			BoxingUnboxing();

			//ConvertToEvetHayir("Evet");

			Console.ReadLine();
		}

		private static void BoxingUnboxing()
		{
			int a = 5;
			string b = "5";
			//b = 5;

			object c = a;

			Console.WriteLine(c.GetType().Name);

			c = true;

			Console.WriteLine(c.GetType().Name);

			c = b;

			Console.WriteLine(c.GetType().Name);

			object d;

			d = 5;

			Console.WriteLine(d.GetType().Name);


			var sayi = false;


			Console.WriteLine(c.GetType().Name);

			double x = (double)((int)c) + 5.0;

			Console.WriteLine(x);

		}

		private static void CastIslemler()
		{
			int sayi1 = 100;
			int sayi2 = sayi1;

			double sayi3 = sayi2; //Implicit Bilinçsiz dönüşüm.

			short sayi4 = (short)sayi3; //Explicit Bilinçli dönüşüm;

			int sayi5 = 27956 * 2;

			short sayi6 = (short)sayi5;

			Console.WriteLine(sayi5);
			Console.WriteLine(sayi6);

			Console.WriteLine(sayi5 - short.MaxValue);
			Console.WriteLine(short.MinValue + (sayi5 - short.MaxValue));
		}

		private static void ConvertIslemler()
		{
			string sayiStr = "5";
			string doubleStr = "5.1";

			int sayiInt = Convert.ToInt32(sayiStr);
			int sayi2Int = int.Parse(sayiStr);

			double sayiDouble1 = Convert.ToDouble(doubleStr);
			double sayiDouble2 = Convert.ToDouble(sayiInt);

			Console.WriteLine(sayiStr + " Type :" + sayiStr.GetType().Name);
			Console.WriteLine(sayiInt + " Type :" + sayiInt.GetType().Name);
			Console.WriteLine(sayi2Int + " Type :" + sayi2Int.GetType().Name);
			Console.WriteLine(sayiDouble1 + " Type :" + sayiDouble1.GetType().Name);
			Console.WriteLine(sayiDouble2 + " Type :" + sayiDouble2.GetType().Name);

			Console.WriteLine(sayiDouble1 / 2);
			Console.WriteLine(Convert.ToDouble(sayiInt) / 2);

			Ayrac();

			DateTime dt = Convert.ToDateTime("04.01.2024");

			Console.WriteLine(dt.ToString("MMMM"));
			Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture);

			if (System.Globalization.CultureInfo.CurrentCulture.ToString() == "tr-TR")
			{
				// Türkçe diline uygun formatlamalar çalışır.
			}

			Ayrac();

			int ogrenciNo = 123456;

			string ogrNo = Convert.ToString(ogrenciNo);
			ogrNo = ogrenciNo.ToString();

			bool check = true;
			string kontrol = check.ToString();

			Console.WriteLine("Örenic No: " + ogrenciNo);

		}

		private static void MantiksalIslemler()
		{
			//Karşılaştırma operatörleri

			int x = 10;
			int y = 23;

			// >, <, !=, <=, >=, !
			// 

			bool kontrol1 = (x > y);    // false
			bool kontrol2 = (x < y);    // true
			bool kontrol3 = (x != y);   // true
			bool kontrol4 = (x <= y);   // true
			bool kontrol5 = (x >= y);   // false

			Console.WriteLine(kontrol1);
			Console.WriteLine(kontrol2);
			Console.WriteLine(kontrol3);
			Console.WriteLine(kontrol4);
			Console.WriteLine(kontrol5);

			Ayrac();

			bool kontrol6 = (x % 2 == 0);       //true
			bool kontrol7 = (y % 2 == 0);       //false
			bool kontrol8 = (!(y % 2 == 0));    //true

			Console.WriteLine(kontrol6);
			Console.WriteLine(kontrol7);
			Console.WriteLine(kontrol8);

			Ayrac();

			int a = 125;
			int b = 374;

			bool kontrol9 = (a > 100 && b < 275);   // T && F => F
			bool kontrol10 = (a > 300 || b < 575);  // F || T => T

			Ayrac();


			bool kontrol11 = (a > 150 && b < 375 && checkA(a) && b < 275);
			bool kontrol12 = (a > 150 & b < 375 & checkA(a) & b < 275);



		}

		private static bool checkA(int sayi)
		{
			return sayi > 100;
		}

		private static void AritmatikIslemler()
		{
			int sayi1 = 15;
			int sayi2 = 8;

			double sonuc = (sayi1 * 1.1 / sayi2);

			Console.WriteLine("---Aritmatik İşlemler---");
			Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, (sayi1 + sayi2));
			Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, (sayi1 - sayi2));
			Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, (sayi1 * sayi2));
			Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, (sayi1 / sayi2));
			Console.WriteLine("{0} / {1} = {2}", sayi1 * 1.1, sayi2, sonuc);
			Console.WriteLine("{0} % {1} = {2}", sayi1, sayi2, (sayi1 % sayi2));


			Ayrac();

			int a = 5;
			int b = 6;

			b += a; //b = b + a;
			b -= a; //b = b - a;
			b *= a; //b = b * a;
			b /= a; //b = b / a;
			b %= a; //b = b % a;
			Console.WriteLine(b);

			Ayrac();

			int c = 7;
			int d = 7;
			int e = 7;

			//c = c + 1; or c += 1; or not c++;

			c = c + 1; // 8
			d += 1; // 8

			Console.WriteLine(c);
			Console.WriteLine(d);
			Console.WriteLine("en'n degeri" + e++); // Değişken ardında gelen e++ işlemi önce değişkenin e'in değerini yazar(o an ki işlemi yapar) sonra değerini bir aratırır.
			Console.WriteLine("en'n degeri" + ++e); // Değişken önce gelen ++e işlemi önce değişkenin e'in değerini değerini bir aratırır sonra değerini yazar(o an ki işlemi yapar)
			Console.WriteLine("en'n degeri" + e);

			Ayrac();

			e = 7;

			int x = e++; // 7
			int y = e;   // 8
			int z = ++e; // 9 
			int q = e;   // 9

			Console.WriteLine(x);
			Console.WriteLine(y);
			Console.WriteLine(z);
			Console.WriteLine(q);

			Ayrac();

			x = e--; // 9
			y = e;   // 8
			z = --e; // 7 
			q = e;   // 7

			Console.WriteLine(x);
			Console.WriteLine(y);
			Console.WriteLine(z);
			Console.WriteLine(q);
		}

		static void SayHello()
		{
			Console.WriteLine("hello");
		}

		static void Ayrac()
		{
			int karaktersayi = 15;
			string ayrac = new String('-', karaktersayi);// birinci parametre tekrar edilecek karakteri char tipinde, ikinic parametre tekrar miktarnın int tipinde

			Console.WriteLine(ayrac);
		}

		static bool ConvertToEvetHayir(string answer)
		{
			if (answer == "Evet" || answer == "EVET")
				return true;
			else if (answer == "Hayır" || answer == "HAYIR")
				return false;
			else
			{
				throw new Exception("Lütfen Evet ya da Hayır giriniz");
			}
		}
	}
}
