namespace _15_OOPHastaneSistemi
{
	public class Doktor : Kullanıcı, IDoktor
	{
		public Alan Alan { get ; set ; }
		public DateTime BaslangicTarihi { get ; set ; }
		public List<Randevu> Randevular { get ; set; }
	}





}
