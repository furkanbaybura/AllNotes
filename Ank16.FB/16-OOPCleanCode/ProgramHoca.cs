using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_OOPCleanCode
{
	internal class ProgramHoca
	{
		static void Main(string[] args)
		{
			ÜrünYönetimi ürünYönetimi = new();
			ürünYönetimi.SatisYap();
			ürünYönetimi.DepoyaÜrünEkle();
			
		}

	}
	public interface ILogger
	{
		public List<string> Logs { get; set; }
		public string Cs { get; set; }
		public void AddLog(string data);
		public void ViewAllLog();

	}
	public class SmsLogger : ILogger
	{
		public string Cs { get ; set ; }
		public List<string> Logs { get; set; } = new();

		public void AddLog(string data)
		{
			Console.WriteLine("sms logger => "+data+"bilgisini logladı"); ;
		}

		public void ViewAllLog()
		{
			Logs.ForEach(x => Console.WriteLine(x));
		}
		
	}
	public class DataBaseLogger : ILogger
	{
		public string Cs { get ; set ; }
		public List<string> Logs { get; set; } = new();

		public void AddLog(string data)
		{
			Console.WriteLine("database logger => "+data+"bilgisini logladı"); ;
		}

		public void ViewAllLog()
		{
			Logs.ForEach(x => Console.WriteLine(x));
		}
		
	}
	public class ÜrünYönetimi
	{
		public void SatisYap()
		{
			Console.WriteLine("satış yap metodu");
			var logger = new LogManager(new SmsLogger());
			logger.LogEkle("satis yapildi");
			


		}

		public void DepoyaÜrünEkle()
		{
			Console.WriteLine("depoya ürün ekleme metodu");
			var logger = new LogManager(new DataBaseLogger());
			logger.LogEkle("depoya ürün ekklendi");
		}
	}
	public class LogManager
	{
		public ILogger Logger { get; set; }

		public LogManager(ILogger logger)
		{
			Logger = logger;
		}	
		public void LogEkle(string data)
		{
			Logger.AddLog(data);
		}
		public void Logİzle() => Logger.ViewAllLog();
	}
	public class FileLogger : ILogger
	{
		public string Cs { get; set; }
		public List<string> Logs { get; set; } = new();

		public void AddLog(string data)
		{
			Console.WriteLine("File logger => " + data + "bilgisini logladı"); ;
		}

		public void ViewAllLog()
		{
			Logs.ForEach(x => Console.WriteLine(x));
		}

	}

}
