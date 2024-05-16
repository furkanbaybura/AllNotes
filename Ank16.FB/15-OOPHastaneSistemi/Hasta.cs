namespace _15_OOPHastaneSistemi
{
	public class Hasta : Kullanıcı, IHasta
	{
		public List<IRandevu> Randevular { get; set; } = new();
		public List<IHastalık> Hastaliklar { get ; set ; }
	}





}
