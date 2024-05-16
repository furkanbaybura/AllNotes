namespace HelloWorld
{

    public class Program
    { 
        static void Main(string[] args)
        {

           // Calismalar1();

            Calismalar2();

            //Calismalar3();

            //Calismalar4();

            Console.ReadKey();
        }

        static void Calismalar1()
        {
            //İki tane tam sayı tipinde değişken tanımlayıp ekrana bunları yazalım.

            int a = 10; // Tanımlama ve atama bir arada

            int b;  // Tanımlama yapıldı.
            b = 20; // Atama yapıldı.

            // A=10 B=20
            //1. yol metin birleştirme operatörü(+) ile yapıldı.
            Console.WriteLine("A=" + a + " B=" + b);

            //2. yol metin formatlamak
            Console.WriteLine("A={0} B={1}", a, b);

            // Alt alta yazmak için yollar
            Console.WriteLine("A={0}\nB={1}", a, b);

            Console.WriteLine("A=\"{0}\"", a);
            Console.WriteLine("B={0}", b);

            Console.WriteLine("A\\B = {0}\\{1}", a, b);

            //Input
            string mesaj = Console.ReadLine();

            //Output
            Console.WriteLine(mesaj);



            Console.WriteLine("Lütfen 1.sayıyı giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2.sayıyı giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam = {0}", (sayi1 + sayi2));

            /*
             * Sayı 1 : 5
             * Sayı 2 : 25
             * Operatör : +
             * 
             * Sonuç : 5 + 25 = 30
             * 
             */

            Console.Write("Sayı 1 :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operatör :");
            string Operator = Console.ReadLine();

            if (Operator == "+")
            {
                int result = (number1 + number2);
                Console.WriteLine("Sonuç : {0} {3} {1} = {2}", number1, number2, result, Operator);
            }
            else if (Operator == "-")
            {
                int result = (number1 - number2);
                Console.WriteLine("Sonuç : {0} {3} {1} = {2}", number1, number2, result, Operator);
            }
            else if (Operator == "*")
            {
                int result = (number1 * number2);
                Console.WriteLine("Sonuç : {0} {3} {1} = {2}", number1, number2, result, Operator);
            }
            else if (Operator == "/")
            {
                int result = (number1 / number2);
                Console.WriteLine("Sonuç : {0} {3} {1} = {2}", number1, number2, result, Operator);
            }
        }
    
        static void Calismalar2()
        {
            string deger = null;

            int sayi3 = int.Parse(deger);

            int sayi4 = Convert.ToInt32(deger);


            Console.WriteLine("Sayı 1:");
            int sayi1 = Convert.ToInt32(Console.ReadLine()); // Türler arası dönüşüm
            Console.WriteLine("Sayı 2:"); 
            int sayi2 = int.Parse(Console.ReadLine()); // String bir değerin ilgi türe parse(dönüşümü)
            
        }

        static void Calismalar3()
        {
            Console.WriteLine("--Tam sayılar--");
            Console.WriteLine("byte Min: {0} - Max: {1} , Default : {2}", byte.MinValue, byte.MaxValue, default(byte));
            Console.WriteLine("sbyte Min: {0} - Max: {1} , Default : {2}", sbyte.MinValue, sbyte.MaxValue, default(sbyte));
            Console.WriteLine("short Min: {0} - Max: {1} , Default : {2}", short.MinValue, short.MaxValue, default(short));
            Console.WriteLine("ushort Min: {0} - Max: {1} , Default : {2}", ushort.MinValue, ushort.MaxValue, default(ushort));
            Console.WriteLine("int Min: {0} - Max: {1} , Default : {2}", int.MinValue, int.MaxValue, default(int));
            Console.WriteLine("uint Min: {0} - Max: {1} , Default : {2}", uint.MinValue, uint.MaxValue, default(uint));
            Console.WriteLine("long Min: {0} - Max: {1} , Default : {2}", long.MinValue, long.MaxValue, default(long));
            Console.WriteLine("ulong Min: {0} - Max: {1} , Default : {2}", ulong.MinValue, ulong.MaxValue, default(ulong));

            Console.WriteLine("--Ondalıklı sayılar--");
            Console.WriteLine("float Min: {0} - Max: {1} , Default : {2}", float.MinValue, float.MaxValue, default(float));
            Console.WriteLine("double Min: {0} - Max: {1} , Default : {2}", double.MinValue, double.MaxValue, default(double));
            Console.WriteLine("decimal Min: {0} - Max: {1} , Default : {2}", decimal.MinValue, decimal.MaxValue, default(decimal));

            Console.WriteLine("-- metinsel mantıksal--");
            Console.WriteLine("string Min:  - Max:  , Default : {0}", default(string)); // ""
            Console.WriteLine("char Min: {0} - Max: {1} , Default : {2}", char.MinValue, char.MaxValue, default(char)); // ''
            Console.WriteLine("bool Min:  - Max:  , Default : {0}", default(bool));

        }

        static void Calismalar4()
        {
            // Ref Type - Value Type
            // Heap - Stack --> Static

            int i = 5;

            int j = i;
            j = j + 1;

            string a = "Test";
            string b = a;
            b = b + " değer";

            int[] sayilar = { 1, 2, 3, 4, 5 };

            int[] numbers = sayilar;

            Console.WriteLine(sayilar[1]);
            Console.WriteLine(numbers[1]);

            numbers[1] = 5;

            Console.WriteLine(sayilar[1]);
            Console.WriteLine(numbers[1]);


        }
    }

}
