using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_8_OBS_
{
	internal class Ogrenci : IKisi
	{
		public string Ad { get; set; }
		public string Soyad { get; set ; }
        public string OgrenciNo {get; set; }
		public string OgrenciSifre { get; set; }
    }
}
