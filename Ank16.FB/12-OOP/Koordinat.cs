using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithClassLib.Lib
{
	internal struct KoordinatStruct
	{
		public int X;
		public int Y;
	}

	internal class KoordinatClass
	{
		private int _x;
		private int _y;

		public int X;
		public int Y;

		public KoordinatClass()
		{

		}
	}

	internal struct Calisan : ICalisan
	{
		private string _adi;
		private string _soyadi;
		private string _tcno;
		private DateOnly _dogumTarihi;

		public Calisan(string adi, string soyadi, string tcno, DateOnly dogumTarihi)
		{
			_adi = adi;
			_soyadi = soyadi;
			_tcno = tcno;
			_dogumTarihi = dogumTarihi;
		}

		public string Adi => _adi;
		public string Soyadi => _soyadi;
		public string TcNo => _tcno;

		public string AdSoyad() => _adi + " " + _soyadi;

		public bool YasKontrol(int yas)
		{
			return (DateTime.Now.Year - _dogumTarihi.Year) >= yas ? true : false;
		}
	}

	internal struct Memur : ICalisan, IMemur
	{
		private string _adi;
		private string _soyadi;
		private string _tcno;
		private string _sicilNo;
		private byte _mesaiSaati;
		private DateOnly _dogumTarihi;

		public Memur(string adi, string soyadi, string tcno, DateOnly dogumTarihi, string sicilNo, byte mesaiSaati)
		{
			_adi = adi;
			_soyadi = soyadi;
			_tcno = tcno;
			_dogumTarihi = dogumTarihi;
			_sicilNo = sicilNo;
			_mesaiSaati = mesaiSaati;
		}

		public string Adi => _adi;
		public string Soyadi => _soyadi;
		public string TcNo => _tcno;

		public string SicilNo => _sicilNo;

		public byte MesaiSaati => _mesaiSaati;

		public string AdSoyad() => _adi + " " + _soyadi;

		public decimal Maas()
		{
			return _mesaiSaati * 1.75m;
		}

		public bool YasKontrol(int yas)
		{
			return (DateTime.Now.Year - _dogumTarihi.Year) >= yas ? true : false;
		}
	}

	internal interface ICalisan
	{
		public string Adi { get; }
		public string Soyadi { get; }
		public string TcNo { get; }

		string AdSoyad();
		bool YasKontrol(int yas);
	}

	internal interface IMemur
	{
		public string SicilNo { get; }
		public byte MesaiSaati { get; }
		decimal Maas();
	}
}