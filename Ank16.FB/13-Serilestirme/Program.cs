using System.Globalization;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serilestirme
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Serileştirm Class to Binary,Xml,Json
			//Ters Serileştirme Binary,Xml,Json to Class
			//MemoryStreamOrnek();
			//FileStreamOrnek();
			BinarySerilestirme();
			//FileStreamReadWriteOrnek();

			Console.ReadLine();
		}

		private static void BinarySerilestirme()
		{
			Ogrenci o1 = new Ogrenci("Göksel", "KALYONCU", new DateTime(1980, 1, 1));
			Console.WriteLine(o1.Adi);

			using (var ms = new MemoryStream())
			{
				var formatter = new BinaryFormatter();

				formatter.Serialize(ms, o1);

				//ms.ToArray();

				ms.Seek(0, SeekOrigin.Begin);

				Ogrenci o2 = (Ogrenci)(formatter.Deserialize(ms));

				Console.WriteLine(o2.Adi);
			}

			//using (var fs = new FileStream("files/ogrenci.bin", FileMode.CreateNew))
			//{
			//    var formatter = new BinaryFormatter();

			//    formatter.Serialize(fs, o1);

			//    //ms.ToArray();
			//}

			using (var fs = new FileStream("files/ogrenci.bin", FileMode.Open))
			{
				var formatter = new BinaryFormatter();

				Ogrenci o2 = (Ogrenci)formatter.Deserialize(fs);

				//ms.ToArray();
			}

			Console.WriteLine(o1);
		}

		private static void FileStreamOrnek()
		{
			var fs = new FileStream(@"files\Gunler.txt", FileMode.Open);

			for (int i = 0; i < fs.Length; i++)
			{
				Console.WriteLine((char)fs.ReadByte());
			}
		}

		private static void FileStreamReadWriteOrnek()
		{
			string kaynakDosya = @"files\lorem-impus.txt";
			string hedefDosya = @"yeni-dosya.txt";

			var fsOku = new FileStream(kaynakDosya, FileMode.Open);
			var fsYaz = new FileStream(hedefDosya, FileMode.CreateNew);

			fsYaz.SetLength(fsOku.Length);

			byte[] buffer = new byte[100];
			int okuByte = 0;

			while ((okuByte = fsOku.Read(buffer, 0, buffer.Length)) > 0)
			{
				fsYaz.Write(buffer, 0, okuByte);
			}

			fsYaz.Close();

		}

		private static void MemoryStreamOrnek()
		{
			int[] sayilarInt = new int[10];
			byte[] sayilarByte = new byte[10];

			var ms = new MemoryStream(10);

			for (int i = 0; i < ms.Capacity; i++)
			{
				int sayi = new Random().Next(256);

				sayilarInt[i] = sayi;
				sayilarByte[i] = (byte)sayi;

				ms.WriteByte((byte)sayi);
			}

			Console.WriteLine("-------------------");

			ms.Seek(0, SeekOrigin.Begin);

			for (int i = 0; i < ms.Capacity; i++)
			{

				Console.WriteLine(ms.ReadByte());
			}
		}
	}

	[Serializable]
	public class Ogrenci
	{
		private string _adi;
		private string _soyadi;
		private DateTime _dogumTarihi;

		public Ogrenci(string adi, string soyadi, DateTime dogumTarihi)
		{
			_adi = adi;
			_soyadi = soyadi;
			_dogumTarihi = dogumTarihi;
		}

		public string Adi => _adi;
		public string Soyadi => _soyadi;
		public byte Yas => (byte)(DateTime.Now.Year - _dogumTarihi.Year);
		public DateTime DogumTarihi
		{
			get
			{
				return _dogumTarihi;
			}

			set { _dogumTarihi = value; }
		}
	}
}