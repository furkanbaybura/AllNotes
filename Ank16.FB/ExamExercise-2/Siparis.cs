namespace FurkanBayburUygulamaOOP
{
	public class Siparis
	{

		private int totalfiyat;
		public List<IKahve> Kahveler { get; set; } = new List<IKahve>();
		
		public List<IEnvanter> Envanterler { get; set; } = new List<IEnvanter>();

		public int ToplamFiyat { get { return totalfiyat; } }

        

        public void FiyatHesaplama()
		{

			foreach (var item in Kahveler)
			{

				totalfiyat += item.Fiyat; 


			}
			foreach (var item in Envanterler)
			{
				totalfiyat += item.Fiyat;

			}

		}



	}


}
