using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Ogretmen : Kisi
	{
		private string _ogretmenNo;

		public Ogretmen(string adi, string soyadi, string tcno, Cinsiyet cinsiyet = Cinsiyet.Erkek) : base(adi, soyadi, tcno, cinsiyet)
		{
		}

		//public Ogretmen(string adi, string soyadi, string tcno, Cinsiyet cinsiyet = Cinsiyet.Erkek)
		//{
		//    _tcno = tcno;
		//    if (!TcKimlikDogrulama())
		//        throw new Exception("Hata Kod:101@TC No uygun değildir.");

		//    if (3 <= adi.Length && adi.Length <= 25)
		//        _adi = adi;
		//    else
		//        throw new Exception("Hata Kod:102@Ad için en az 3 karakter en fazla 25 karakterli bir değer giriniz.");

		//    if (3 <= soyadi.Length && soyadi.Length <= 25)
		//        _soyadi = soyadi;
		//    else
		//        throw new Exception("Hata Kod:103@Soyad için en az 3 karakter en fazla 25 karakterli bir değer giriniz.");

		//    _ogretmenNo = new Random().Next(100000, 999999).ToString();
		//    _cinsiyet = cinsiyet;
		//}

		public string OgretmenNo => _ogretmenNo;   // Sistem oluşturacak

		public bool SozlesmeliMi { get; set; }  // Varsayılan olarak false
	}
}