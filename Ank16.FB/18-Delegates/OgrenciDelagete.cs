using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Delegates
{
	public class Ogrenci
	{
		public event EventHandler Olay;
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public int Not1 { get; set; } = -1;
		public int Not2 { get; set; } = -1;
		public int not3 { get; set; } = -1;
		public int Not3
		{
			get
			{
				return not3;

			}
			set
			{
				not3 = value;
				Olay(this,EventArgs.Empty);


			}
		}





	}

}
