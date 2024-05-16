using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Kisi
	{
		protected string _tcno;
		protected string _adi;
		protected string _soyadi;
		protected Cinsiyet _cinsiyet;
		protected DateOnly _dogumTarihi;
		protected byte _yas;

		//public Kisi()
		//{
		//    Console.WriteLine("Kişi sınıfır");
		//}

		public Kisi(string adi, string soyadi, string tcno, Cinsiyet cinsiyet = Cinsiyet.Erkek)
		{
			_tcno = tcno;
			if (!TcKimlikDogrulama())
				throw new Exception("Hata Kod:101@TC No uygun değildir.");

			if (3 <= adi.Length && adi.Length <= 25)
				_adi = adi;
			else
				throw new Exception("Hata Kod:102@Ad için en az 3 karakter en fazla 25 karakterli bir değer giriniz.");

			if (3 <= soyadi.Length && soyadi.Length <= 25)
				_soyadi = soyadi;
			else
				throw new Exception("Hata Kod:103@Soyad için en az 3 karakter en fazla 25 karakterli bir değer giriniz.");
			_cinsiyet = cinsiyet;
		}

		public string TcNo  // 11 karakterli ve özel bir algoritması var. Zorunlu
		{
			get
			{
				return _tcno;
			}
		}
		public string Adi // 25 karakter sınırı var zorunlu
		{
			get
			{
				return _adi;
			}
			set
			{
				_adi = value;
			}

		}
		//public string Soyadi => _soyadi; // get { return _soyadi; } 

		public string Soyadi
		{
			get
			{
				return _soyadi;
			}
			set
			{
				_soyadi = value;
			}
		}

		public string AdSoyad => _adi + " " + _soyadi;

		public string Email { get; set; }   // Email format kontrolü içinde @ var mı? gmail.com,yahoo.com,hotmail.com

		public Cinsiyet Cinsiyet
		{
			get
			{
				return _cinsiyet;
			}
			set
			{
				_cinsiyet = value;
			}
		}

		public DateOnly DogumTarihi // Doğum Tarihi bilgisinde yaş olarak 18'e eşit ve büyük 30 dan gün almasın :)
		{
			get
			{
				return this._dogumTarihi;
			}
			set
			{
				this._yas = (byte)(DateTime.Now.Year - value.Year); // Explicit Açık Dönüşüm Bilinçli dönüşüm.
				this._dogumTarihi = value;

				////if((DateTime.Now.Year - value.Year) >= 18  && (DateTime.Now.Year - value.Year) < 30)
				//if (this._yas >= 18 && this._yas < 30)
				//{
				//    this._dogumTarihi = value;
				//}
				//else
				//{
				//    throw new Exception("Hata Kod:104@Öğrenci kaydı için yaşınız uygun değlidir.Yaşınız 18'e eşit veya büyük 30 yaşında küçük olmalısınızdır.");
				//}

			}
		}

		public byte Yas => _yas;       // Doğum Tarihi bilgisinden hesaplanarak doldurulacaktır.

		protected bool TcKimlikDogrulama()
		{
			if (this._tcno.Length != 11)
				return false;

			if (this._tcno[0] != '1' && this._tcno[10] != '9')
				return false;

			return true;

		}
	}
}