namespace Siniflar
{
	internal class Program
	{
		//public static Araba mazda;

		static void Main(string[] args)
		{
			#region Sınıf çalışmaları ilk örnekler
			///*
			// * Bir tam sayı değeri tutan değişken tanımı nasıldır?
			// */

			//int sayi = 10;

			///*
			// * Bir string değeri tutan değişken tanımı nasıldır?
			// */

			//string str = "Hello World";

			///*
			// * Bir öğrenci değeri tutan değişken tanımı nasıldır?
			// * Bir araba değeri tutan değişken tanımı nasıldır?
			// * Bir kitap değeri tutan değişken tanımı nasıldır?
			// */

			////Araba araba = "BMW", 520, 2015, "Dizel";

			//string araba1Marka = "BMW";
			//string araba1Model = "5.20";
			//short araba1Yil = 1995;
			//bool araba1OtomatikMi = true;
			//byte araba1YakitTipi = 1; // 1:Benzin; 2:Dizel; 3:Benzin+Lpg; 4:Hibrit; 5:Eletrikli

			//string araba2Marka = "BMW";
			//string araba2Model = "3.20d";
			//short araba2Yil = 1998;
			//bool araba2OtomatikMi = false;
			//byte araba2YakitTipi = 2; // 1:Benzin; 2:Dizel; 3:Benzin+Lpg; 4:Hibrit; 5:Eletrikli

			//string[] arabaMarka = { "BMW", "BMW" };
			//string[] arabaModel = { "5.20", "3.20" };
			//short[] arabaYil = {1995,1998 };
			//bool[] arabaOtomatikMi = {true,false };
			//byte[] arabaYakitTipi = {1, 2 };

			//string[] araba1 = { "BMW", "5.20", "1995", "true", "1" };
			//string[] araba2 = { "BMW", "3.20", "1998", "false", "0" };

			////Araba araba;
			////Bmw bmw;
			////int i;
			////i = 5;
			////new Araba();

			////araba = new Araba();

			////Console.WriteLine(araba);
			////Console.WriteLine(i);

			////Araba bmw;// = new Araba();

			////bmw.marka = "BMW"; // Örneği (instance) olmayan bir değişken üzerinden bir sınıf üyesine erişimi
			//// sağlayamayız.

			////var mercedes = new Araba();
			////mercedes.yil = 1995;

			//Araba volvo = new Araba();

			//volvo.Marka = "Volvo";

			////volvo.SetMarka("Volvo");

			//volvo.marka = "Volvo";
			//volvo.model = "XC90";
			//volvo.yil = 2024;
			//volvo.otomatikMi = true;
			//volvo.yakitTipi = 1;

			////Console.WriteLine(volvo.marka.ToUpper());
			////Console.WriteLine(volvo.marka);

			////Console.WriteLine(volvo.Marka);

			//////Console.WriteLine(volvo.GetMarka());

			////Console.WriteLine(volvo.model);
			////Console.WriteLine(volvo.yil);
			////Console.WriteLine(volvo.otomatikMi);
			////Console.WriteLine(volvo.yakitTipi);


			//Araba bmw = new Araba();
			//bmw.Marka = "Bmw";
			//bmw.model = "320";
			//bmw.yil = 1999;
			//bmw.yakitTipi = 1;
			//bmw.otomatikMi = true;
			////bmw.Devir = (short)(new Random().Next(1000, 3001));

			//Araba toyota = new Araba();
			//toyota.Marka = "Toyota";
			//toyota.model = "Corolla";
			//toyota.yil = 2014;
			//toyota.yakitTipi = 1;
			//toyota.otomatikMi = true;
			////toyota.Devir = (short)(new Random().Next(1000, 3001));

			//Araba honda = new Araba();
			//honda.Marka = "Honda";
			//honda.model = "Civic";
			//honda.yil = 2020;
			//honda.yakitTipi = 1;
			//honda.otomatikMi = false;
			////honda.Devir = (short)(new Random().Next(1000, 3001));

			//Console.WriteLine(bmw.Devir + " " + bmw.OrtalamaYakitTuketimi());
			//Console.WriteLine(toyota.Devir + " " + toyota.OrtalamaYakitTuketimi());
			//Console.WriteLine(honda.Devir + " " + honda.OrtalamaYakitTuketimi());

			//Araba opel = new Araba("Opel", "Astra", 2001, false, 2);

			//Console.WriteLine(opel);

			//Arabalar();
			//GC.Collect(); 
			#endregion

			//Console.WriteLine(mazda);

			int i = 5;

			Console.WriteLine(i++); //5
			Console.WriteLine(i);   //6
			Console.WriteLine(i--); //6
			Console.WriteLine(i);   //5
			Console.WriteLine(++i); //6
			Console.WriteLine(i);   //6
			Console.WriteLine(--i); //5
			Console.WriteLine(i);   //5


			Console.WriteLine("---------------");
			int j = 6;

			Console.WriteLine(j++ + 2); //8
			Console.WriteLine(j + 2); //9
			Console.WriteLine(j-- + 2); //9
			Console.WriteLine(j + 2); //8
			Console.WriteLine(++j + 2); //9
			Console.WriteLine(j + 2); //9
			Console.WriteLine(--j + 2); //8
			Console.WriteLine(j + 2); //8

			Console.WriteLine("--------------");

			int a = 5;
			int b = 7;
			int c = 9;

			if (a > b && b > c && a > c)
			{

			}
			else if (a > b & b > c & a > c)
			{

			}
			else if (a == b && b >= c && a <= c)
			{

			}
			else
			{

			}

			Console.ReadLine();

			ArabaDonanim bmw320Donanim = new ArabaDonanim(2000, 180, false, 75, 400, false);

			Bmw bmw320 = new Bmw("320", bmw320Donanim);

			Console.WriteLine(bmw320.Model);
			bmw320.ArabaDonanim.GetArabaDonanim();
			Console.WriteLine("-----------");
			string bilgi = bmw320.ArabaDonanim.GetArabaDonanimStr();
			Console.WriteLine(bilgi);

			Console.ReadKey();
		}

		static void Arabalar()
		{
			Araba mazda = new Araba();
		}
	}