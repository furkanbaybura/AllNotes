
using System;
using System.Diagnostics;
using System.Text;

namespace Diziler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");

			//Diziler1();
			//Diziler2();
			//Diziler3();
			//Diziler4();
			//Diziler5();
			//Diziler6();
			//Diziler7();
			//Diziler8();
			//Diziler9();
			//Diziler10();
			//Diziler11();
			//Diziler12();
			//Diziler12Ek();
			//Diziler13();
			//Diziler14();
			Diziler15();

			Console.ReadKey();
		}

		private static void Diziler15()
		{
			Console.Write("Adınız : ");
			string metin = Console.ReadLine();

			int length = metin.Length;

			for (int i = 0; i < length; i++)
			{
				Console.WriteLine(new string(metin[i], (i + 1)));
			}

			StringBuilder sb = new StringBuilder();
			sb.Append("Merhaba ");
			sb.Append("Dünya ");
			sb.Append("Bugün ");
			sb.Append("çok ");
			sb.Append("Sevimlisin ");
			sb.Append("deseme ");
			sb.Append("inanma ");

			Console.WriteLine(sb.ToString());

		}

		private static void Diziler14()
		{
			int[][] odevler = new int[3][];

			//Console.WriteLine(odevler.Length);

			int size = odevler.Length;

			for (int i = 0; i < size; i++)
			{
				int odevSayisi = new Random().Next(1, 5);

				odevler[i] = new int[odevSayisi];

				for (int j = 0; j < odevSayisi; j++)
				{
					odevler[i][j] = new Random().Next(1, 101);
				}

			}



			for (int i = 0; i < size; i++)
			{
				int odevSayisi = odevler[i].Length;

				for (int j = 0; j < odevSayisi; j++)
				{
					Console.WriteLine("{0}. Öğrencinin {1}. ödev notu = {2}", (i + 1), (j + 1), odevler[i][j]);
				}

			}

		}

		private static void Diziler13()
		{
			int[,] notlar = new int[,] { { 0, 5 }, { 0, 5 } };

			int[,] ucretler = new int[3, 2];

			ucretler[0, 0] = new Random().Next(1, 50);
			ucretler[1, 0] = new Random().Next(1, 50);
			ucretler[2, 0] = new Random().Next(1, 50);

			ucretler[0, 1] = new Random().Next(1, 50);
			ucretler[1, 1] = new Random().Next(1, 50);
			ucretler[2, 1] = new Random().Next(1, 50);

			//Console.WriteLine(ucretler.Length);
			//Console.WriteLine(ucretler.GetLength(0));
			//Console.WriteLine(ucretler.GetLength(1));

			Console.WriteLine("-----------");

			//Console.WriteLine(ucretler.Rank);

			//int[] numbers = new int[3];
			//int[,,] numbers2 = new int[3,5,6];

			//Console.WriteLine(ucretler.Rank);
			//Console.WriteLine(numbers.Rank);
			//Console.WriteLine(numbers2.Rank);

			for (int i = 0; i < ucretler.GetLength(0); i++)
			{
				for (int j = 0; j < ucretler.GetLength(1); j++)
				{
					//Console.WriteLine("{0}. satir {1}. sutun = {2}",i,j, ucretler[i,j]);
					Console.WriteLine("[{0}, {1}] = {2}", i, j, ucretler[i, j]);
				}
			}
		}

		private static void Diziler12Ek()
		{
			int size;
			Console.Write("Array Size : ");
			int.TryParse(Console.ReadLine(), out size);

			int[] numbers = new int[size];

			Console.WriteLine("Gireceğiniz topla sayı miktarı {0}", size);

			for (int i = 0; i < size; i++)
			{
				int random = new Random().Next(1, 11);
				if (i != 0)
				{
					int indexKontrol = Array.IndexOf(numbers, random);
					if (indexKontrol == -1)
					{
						numbers[i] = random;
					}
					while (indexKontrol != -1)
					{
						random = new Random().Next(1, 11);
						indexKontrol = Array.IndexOf(numbers, random);
						if (indexKontrol == -1)
						{
							numbers[i] = random;
							break;
						}

						//Console.WriteLine("{0} değer array de var {1}", random, i);
						//Thread.Sleep(1500);
					}
				}
				else
				{
					numbers[i] = random;
				}
			}

			ReadArray(numbers);
			Console.WriteLine("-----");

			ArraySort(numbers);

			ReadArray(numbers);

		}

		private static void Diziler12()
		{
			int size;
			Console.Write("Array Size : ");
			int.TryParse(Console.ReadLine(), out size);

			int[] numbers = new int[size];

			Console.WriteLine("Gireceğiniz topla sayı miktarı {0}", size);

			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();

			for (int i = 0; i < size; i++)
			{
				int random = new Random().Next(1, 100001);
				if (i != 0)
				{
					int indexKontrol = Array.IndexOf(numbers, random);
					if (indexKontrol == -1)
					{
						numbers[i] = random;
					}
					while (indexKontrol != -1)
					{
						random = new Random().Next(1, 100001);
						indexKontrol = Array.IndexOf(numbers, random);
						if (indexKontrol == -1)
						{
							numbers[i] = random;
							break;
						}

						//Console.WriteLine("{0} değer array de var {1}", random, i);
						//Thread.Sleep(1500);
					}
				}
				else
				{
					numbers[i] = random;
				}
			}


			stopWatch.Stop();

			TimeSpan ts = stopWatch.Elapsed;

			// Format and display the TimeSpan value.
			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
				ts.Hours, ts.Minutes, ts.Seconds,
				ts.Milliseconds / 10);
			Console.WriteLine("RunTime " + elapsedTime);


			//ReadArray(numbers);
			Console.WriteLine("-----");
			//stopWatch = new Stopwatch();
			//stopWatch.Start();

			//Array.Sort(numbers);

			//stopWatch.Stop();

			//ts = stopWatch.Elapsed;

			//// Format and display the TimeSpan value.
			//elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
			//    ts.Hours, ts.Minutes, ts.Seconds,
			//    ts.Milliseconds / 10);
			//Console.WriteLine("RunTime " + elapsedTime);

			////ReadArray(numbers);

			//Console.WriteLine("-----");

			stopWatch = new Stopwatch();
			stopWatch.Start();

			ArraySort(numbers);

			stopWatch.Stop();

			ts = stopWatch.Elapsed;

			// Format and display the TimeSpan value.
			elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
				ts.Hours, ts.Minutes, ts.Seconds,
				ts.Milliseconds / 10);
			Console.WriteLine("RunTime " + elapsedTime);

			//Array.Reverse(numbers);

			//ReadArray(numbers);
		}

		private static void Diziler11()
		{
			int size;
			Console.Write("Array Size : ");
			int.TryParse(Console.ReadLine(), out size);

			int[] numbers = new int[size];

			Console.WriteLine("Gireceğiniz topla sayı miktarı {0}", size);

			for (int i = 0; i < size; i++)
			{
				int random = new Random().Next(1, 11);
				if (i != 0)
				{
					int indexKontrol = Array.IndexOf(numbers, random);
					if (indexKontrol == -1)
					{
						numbers[i] = random;
					}
					while (indexKontrol != -1)
					{
						random = new Random().Next(1, 11);
						indexKontrol = Array.IndexOf(numbers, random);
						if (indexKontrol == -1)
						{
							numbers[i] = random;
							break;
						}

						//Console.WriteLine("{0} değer array de var {1}", random, i);
						//Thread.Sleep(1500);
					}
				}
				else
				{
					numbers[i] = random;
				}
			}

			ReadArray(numbers);
		}

		private static void Diziler10()
		{
			int size;
			Console.Write("Array Size : ");
			int.TryParse(Console.ReadLine(), out size);

			int[] numbers = new int[size];

			Console.WriteLine("Gireceğiniz topla sayı miktarı {0}", size);

			for (int i = 0; i < size; i++)
			{
				numbers[i] = new Random().Next(1, 51);
			}

			int index;
			int tahmin;
			do
			{

				int.TryParse(Console.ReadLine(), out tahmin);

				index = Array.IndexOf(numbers, tahmin);

			} while (index == -1);

			Console.WriteLine("Bulduk array de {0}", tahmin);

			ReadArray(numbers);
		}

		private static void Diziler9()
		{
			int size;
			Console.Write("Array Size : ");
			int.TryParse(Console.ReadLine(), out size);

			int[] numbers = new int[size];

			Console.WriteLine("Gireceğiniz topla sayı miktarı {0}", size);

			for (int i = 0; i < size; i++)
			{
				numbers[i] = new Random().Next(1, 8);
			}

			ReadArray(numbers);

			Console.WriteLine(Array.IndexOf(numbers, 5));
		}

		private static void Diziler8()
		{
			int size;
			Console.Write("Array Size : ");
			int.TryParse(Console.ReadLine(), out size);

			int[] numbers = new int[size];

			Console.WriteLine("Gireceğiniz topla sayı miktarı {0}", size);

			for (int i = 0; i < size; i++)
			{
				numbers[i] = new Random().Next(1, 101);
			}

			ReadArray(numbers);

			Array.Resize(ref numbers, 3);

			Console.WriteLine("-----------");

			ReadArray(numbers);
		}

		private static void Diziler7()
		{
			int size;
			Console.Write("Array Size : ");
			int.TryParse(Console.ReadLine(), out size);

			int[] numbers = new int[size];

			Console.WriteLine("Gireceğiniz topla sayı miktarı {0}", size);

			for (int i = 0; i < size; i++)
			{
				numbers[i] = new Random().Next(1, 101);
			}

			int[] copyNumbers = new int[20];

			numbers.CopyTo(copyNumbers, 3);

			Console.WriteLine("-----");
			ReadArray(numbers);
			Console.WriteLine("-----");
			ReadArray(copyNumbers);
		}

		private static void Diziler6()
		{
			int size;
			Console.Write("Array Size : ");
			int.TryParse(Console.ReadLine(), out size);

			int[] numbers = new int[size];

			Console.WriteLine("Gireceğiniz topla sayı miktarı {0}", size);

			for (int i = 0; i < size; i++)
			{
				numbers[i] = new Random().Next(1, 101);
			}

			int[] refNumbers = numbers;

			int[] newNumbers = new int[size];
			newNumbers = (int[])numbers.Clone();


			Console.WriteLine(numbers.GetHashCode());
			Console.WriteLine(refNumbers.GetHashCode());
			Console.WriteLine(newNumbers.GetHashCode());
			Console.WriteLine("---------");

			Console.WriteLine(numbers[2]);
			Console.WriteLine(newNumbers[2]);
			Console.WriteLine("------");
			newNumbers[2] += 5;

			Console.WriteLine(numbers[2]);
			Console.WriteLine(newNumbers[2]);
		}

		private static void Diziler5()
		{
			int size;
			Console.Write("Array Size : ");
			int.TryParse(Console.ReadLine(), out size);

			int[] numbers = new int[size];

			Console.WriteLine("Gireceğiniz topla sayı miktarı {0}", size);

			for (int i = 0; i < size; i++)
			{
				Console.Write("{0}. indeks için bir tam sayı girininiz : ", (i + 1));
				int.TryParse(Console.ReadLine(), out numbers[i]);
			}

			ReadArrayForEach(numbers);
		}

		private static void ReadArrayForEach(int[] array)
		{
			int size = array.Length;
			//for (int i = 0; i < size; i++)
			foreach (int number in array)
			{
				Console.WriteLine(number);
			}
		}

		private static void Diziler4()
		{
			int size;
			Console.Write("Array Size : ");
			int.TryParse(Console.ReadLine(), out size);

			int[] numbers = new int[size];

			Console.WriteLine("Gireceğiniz topla sayı miktarı {0}", size);

			for (int i = 0; i < size; i++)
			{
				Console.Write("{0}. indeks için bir tam sayı girininiz : ", (i + 1));
				int.TryParse(Console.ReadLine(), out numbers[i]);
			}

			Console.WriteLine("Notlar girildi kanat notu olman ilk hali");
			ReadArray(numbers);
			Console.WriteLine("Kanaat notu için gönderildi.");
			ChangeArray(numbers);
			Console.WriteLine("Kanaat notu eklendi. 15");

			Console.WriteLine("Kanaat notu eklendikten sonraki son hali");
			ReadArray(numbers);
		}

		private static void Diziler3()
		{
			int size;
			Console.Write("Array Size : ");
			int.TryParse(Console.ReadLine(), out size);

			int[] numbers = new int[size];

			Console.WriteLine("Gireceğiniz topla sayı miktarı {0}", size);

			for (int i = 0; i < size; i++)
			{
				Console.Write("{0}. indeks için bir tam sayı girininiz : ", (i + 1));
				int.TryParse(Console.ReadLine(), out numbers[i]);
			}

			ReadArray(numbers);
		}

		private static void Diziler2()
		{
			int[] numbers = new int[10];

			int size = numbers.Length;

			for (int i = 0; i < size; i++)
			{
				numbers[i] = new Random().Next(50, 101);
			}

			for (int i = 0; i < size; i++)
			{
				Console.WriteLine(numbers[i]);
			}
		}

		private static void Diziler1()
		{
			//int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] numbers = new int[10];

			numbers[5] = new Random().Next(50, 101);
			numbers[3] = new Random().Next(50, 101);
			numbers[7] = new Random().Next(50, 101);
			numbers[1] = new Random().Next(50, 101);
			numbers[8] = new Random().Next(50, 101);
			numbers[0] = new Random().Next(50, 101);
			numbers[4] = new Random().Next(50, 101);
			numbers[9] = new Random().Next(50, 101);
			numbers[6] = new Random().Next(50, 101);
			numbers[2] = new Random().Next(50, 101);

			Console.WriteLine(numbers[5]);
			Console.WriteLine(numbers[3]);
			Console.WriteLine(numbers[7]);
			Console.WriteLine(numbers[1]);
			Console.WriteLine(numbers[8]);
			Console.WriteLine(numbers[0]);
			Console.WriteLine(numbers[4]);
			Console.WriteLine(numbers[9]);
			Console.WriteLine(numbers[6]);
			Console.WriteLine(numbers[2]);
		}

		private static void ReadArray(int[] array)
		{
			int size = array.Length;
			for (int i = 0; i < size; i++)
			{
				Console.WriteLine(array[i]);
			}
		}

		private static void ChangeArray(int[] array)
		{
			int size = array.Length;
			for (int i = 0; i < size; i++)
			{
				array[i] += 15;
			}
		}

		private static void ArraySort(int[] array)
		{
			int checkCount = 1;
			int size = array.Length;
			int sayac = 0;

			while (size != checkCount)
			{
				checkCount = 1;

				for (int i = 0; i < size - sayac; i++)
				{
					//int _temp = array[i];
					if (i != 0)
					{
						if (i < size)
						{
							if (array[i - 1] > array[i])
							{
								int _temp = array[i];
								array[i] = array[i - 1];
								array[i - 1] = _temp;
							}
							else
							{
								checkCount++;
							}
						}
					}
				}
				sayac++;
			}
		}

	}
}
