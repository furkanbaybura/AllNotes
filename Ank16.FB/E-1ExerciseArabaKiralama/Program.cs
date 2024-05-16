using System.Xml.Schema;

namespace E_1ExerciseArabaKiralama
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IAraba arac1 = new Otomobil("toyota","corolla",2020,YakıtTuru.Dizel);
			Kamyon arac2 = new Kamyon("volvo", "FH16", 2019, YakıtTuru.Dizel);

			arac1.Calistir();
			arac1.GazVer(100);
			arac1.Dur();
            Console.WriteLine("---------");

			arac2.Calistir();
			arac2.YükTasi(5);
			arac2.GazVer(100);
			arac2.Dur();

            Console.WriteLine("---------");
        }
	}
}


public interface IAraba
{
	void Calistir();
	void Dur();
	void GazVer(int hız);
}

public enum YakıtTuru
{
	Benzin,
	Dizel,
	Elektrik
}
public abstract class Arac : IAraba
{
	public string Marka { get; set; }
	public string Model { get; set; }
	public int Yil { get; set; }
	public YakıtTuru Yakit { get; set; }
	public Arac(string marka, string model, int yil, YakıtTuru yakit)
	{
		Marka = marka;
		Model = model;
		Yil = yil;
		Yakit = yakit;
	}
	public abstract void Calistir();
	public abstract void Dur();
	public virtual void GazVer(int hiz)
	{
		Console.WriteLine($"{Marka} {Model} aracı {hiz} km/s hıza ulaştırdın");
	}
	
}
public class Otomobil: Arac
{
	public Otomobil(string marka,string model,int yil,YakıtTuru yakit): base(marka, model, yil, yakit)
	{

	}
	public override void Calistir()
	{
        Console.WriteLine($"{Marka} {Model} otomobil çalıştırıldı" );
    }
	public override void Dur()
	{
        Console.WriteLine($"{Marka} {Model} otomobil durduruldu");
    }
}
public class Kamyon: Arac
{
	public Kamyon (string marka,string model,int yil,YakıtTuru yakit) : base(marka, model, yil, yakit)
	{

	}
	public override void Calistir()
	{
        Console.WriteLine($"{Marka} {Model} kamyon çalıştırıldı");
    }
	public override void Dur()
	{
        Console.WriteLine($"{Marka} {Model} kamyon durduruldu");
    }
	public void YükTasi(int agirlik)
	{
        Console.WriteLine($"{Marka} {Model} kamyon {agirlik} ton yük taşıyor");
    }
}