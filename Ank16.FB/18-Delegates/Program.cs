using System.Threading.Channels;


namespace _18_Delegates
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//List<string> list = new List<string>();
			//list.Add("3");
			//list.Add("2");
			//list.Add("5");
			//list.Add("8asdasdas");
			//list.Add("1");
			//list.Add("6asdasda");
			//control(list, x => x.Length > 2);


			Ogrenci o1 = new Ogrenci();
			o1.Olay += OgrenciNotGoster;
			o1.Not1 = 70;
			o1.Not2 = 75;
			o1.Not3= 71;


		}

		public static void OgrenciNotGoster(object sender, EventArgs e)
		{
			var ogrenci = sender as Ogrenci;
			if (ogrenci.Not1>0 && ogrenci.Not2 >0 && ogrenci.Not3 > 0)
			{
				var result = (ogrenci.Not1 + ogrenci.Not2 + ogrenci.Not3) / 3.0f;
                Console.WriteLine("ortalama"+result);

            }



		}


		public delegate bool Test(string data);

		public static void control(List<string> data, Test test)
		{

			foreach (var item in data)
			{
				if (test(item))
				{
					Console.WriteLine(item);

				}

			}


		}








	}
}
