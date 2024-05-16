using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	#region Önceki Öğrenci 
	//internal class Ogrenci
	//{
	//    private string _adi;

	//    private string _name;
	//    private string _surname;

	//    private string _ad;
	//    private string _soyad;

	//    private DateTime _dogumTarihi;

	//    public Ogrenci()
	//    { }

	//    public Ogrenci(string ad, string soyad)
	//    {
	//        this._adi = ad;
	//        this._soyad = soyad;
	//    }

	//    public void SetAd(string ad)
	//    {
	//        _ad = ad;
	//    }

	//    public void SetSoyad(string soyad)
	//    {
	//        _soyad = soyad;
	//    }

	//    public string Adi
	//    {
	//        get
	//        {
	//            return _adi;
	//        }
	//        set
	//        {
	//            if (_adi == null)
	//                _adi = value;
	//        }
	//    }

	//    //public string Adi { get; set; }
	//    public string Soyadi { get; set; }

	//    public string Name //Write-only
	//    {
	//        set
	//        {
	//            _name = value;
	//        }
	//    }
	//    public string Surname //Write-only
	//    {
	//        set
	//        {
	//            _surname = value;
	//        }
	//    }

	//    public string Ad // Read-only
	//    {
	//        get
	//        {
	//            return _ad;
	//        }
	//    }
	//    public string Soyad // Read-only
	//    {
	//        get
	//        {
	//            return _soyad;
	//        }
	//    }

	//    public string OgrenciNo { get; set; }
	//    public string Email { get; set; }

	//    /// <summary>
	//    /// Doğum tarihi kontrolü vardır. Giriş değeri olarak 18 ile 30 yaşında olması gerekir
	//    /// </summary>
	//    /// <exception cref="Exception"></exception>
	//    public DateTime DogumTarihi
	//    {
	//        get
	//        {
	//            return _dogumTarihi;
	//        }
	//        set
	//        {
	//            if (DateTime.Now.Year - value.Year >= 18 && DateTime.Now.Year - value.Year < 30)
	//                _dogumTarihi = value;
	//            else
	//                throw new Exception("Doğum tarihi için girilen değer yanlıştır.");
	//        }
	//    }

	//    public Cinsiyet Cinsiyet { get; set; }

	//    public string AdSoyad()
	//    {
	//        return this._adi.ToUpper() + " " + this.Soyadi.ToUpper();
	//    }

	//    public string FullName()
	//    {
	//        return this._name.ToUpper() + " " + this._surname.ToUpper();
	//    }

	//} 
	#endregion

	internal class Ogrenci : Kisi
	{
		private string _ogrenciNo;

		//public Ogrenci()
		//{
		//    Console.WriteLine("Öğrenci Sınıfı");
		//}

		public Ogrenci(string adi, string soyadi, string tcno, Cinsiyet cinsiyet = Cinsiyet.Erkek) : base(adi, soyadi, tcno, cinsiyet)
		{
			_ogrenciNo = new Random().Next(100000, 999999).ToString();
		}

		public string OgrenciNo => _ogrenciNo;   // Sistem oluşturacak

		public bool BursluMu { get; set; }  // Varsayılan olarak false
	}
}