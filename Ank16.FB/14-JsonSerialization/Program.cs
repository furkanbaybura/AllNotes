using ServiceLib;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace JsonSerialization
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			//Uygulama sürekli Öğrenci kayıt yapacaktır. +
			//Öğrencinin Adı, Soyadını ve Doğum Tarihini (gg/aa/yyyy) bu formatta ekran isteyeceğiz +
			//İlgili sınıfın kullanımı ile bir örnek nesne oluşturuacağız. +
			//Bu oluşan nesneyi Binary Serializastion yaparak belirtiğimiz klasörde *.bin şeklinde kaydedeceğiz
			//Yeni bir kayıt isteyip istemediğini soracağız
			//Yeni bir kayıt isteği olursa tüm işlemler tekrar edilecektir.
			//İsmediğinde ise programı sonlandıracağız.


			while (true)
			{
				Console.Write("Öğretmen Adı : ");
				string ogrenciAdi = Console.ReadLine();

				Console.Write("Öğretmen Soyadı : ");
				string ogrenciSoyadi = Console.ReadLine();

				Console.Write("Öğretmen Doğum Tarihi : ");
				DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());

				Ogretmen ogretmen = new Ogretmen(ogrenciAdi, ogrenciSoyadi, dogumTarihi);

				string guid = DateTime.Now.ToString("yyyyMMddHHmmss");//20240126100714

				string dosyaAdi = $@"C:\Oys\Service\ogretmen-{guid}.json";

				string ogretmenJson = JsonSerializer.Serialize(ogretmen);

				File.WriteAllText(dosyaAdi, ogretmenJson);

				Console.Write("Devam etmek istiyorsanız ");

				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("ENTER, ");
				Console.ResetColor();

				Console.Write("çıkmak için ");

				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("ESCAPE ");
				Console.ResetColor();

				Console.WriteLine("tuşuna basınız.");

				ConsoleKey tus = Console.ReadKey().Key;

				while (tus != ConsoleKey.Escape && tus != ConsoleKey.Enter)
				{
					tus = Console.ReadKey().Key;
				}

				if (tus == ConsoleKey.Escape)
					break;

				Console.Clear();
			}
		}
	}
}