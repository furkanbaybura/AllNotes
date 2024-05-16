
namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Dongu1();
            //Dongu2();
            //Dongu3();
            //Dongu3Ek();

            //Dongu4();

            //Dongu5();

            //Dongu6();

            //Dongu6ek();

            //Dongu7();

            //Dongu8();

            //Dongu9();

            //Dongu10();

            //Dongu11();

            //Dongu12();

            //Dongu13();

            //int deger = Dongu14();
            //if(deger == 0)
            //{
            //    Console.WriteLine("Sonuç bulunamadı");
            //}
            //else
            //{
            //    Console.WriteLine("Sonuç bulundu {0}", deger);
            //}

            //Dongu15();

            //Dongu16();

            Dongu17();

            Console.ReadLine();
        }

        private static void Dongu17()
        {
            int sayac = 1;
            int tahmin;
            int sayi = new Random().Next(1,51);

            //while (sonuc != tahmin)
            while(true)
            {
                Console.Write("{0}. tahmin : ", sayac);
                int.TryParse(Console.ReadLine(), out tahmin);  

                if(sayi == tahmin )
                {
                    Console.WriteLine("Tebrikler {0}. tahminde buldunuz. Sayı:{1}, Tahmin:{2}", sayac, sayi, tahmin);
                    break;
                }

                sayac++;
            }
        }

        private static void Dongu16()
        {
            int i;
            int sayac = 1;
            do
            {
                i = new Random().Next(1, 101);
                Console.WriteLine("{0}. tahmin değeri {1}", sayac, i);
                sayac++;
            } while (i != 59);
        }

        private static void Dongu15()
        {
            char yildiz = '*';

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(yildiz);
                }
                Console.WriteLine("");
            }

            //Console.WriteLine("--");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 9; j > i; j--)
                {
                    Console.Write(yildiz);
                }
                Console.WriteLine("");
            }

            //Console.WriteLine("--");

            //for (int i = 0; i < 20; i++)
            //{
            //    int j;
            //    for (j = 0; j < i; j++)
            //    {
            //        Console.Write(yildiz);
            //    }
            //    for (int k = 20; k > 0; k--)
            //    {
            //        Console.Write(yildiz);
            //    }
            //    Console.WriteLine("");
            //}

        }

        private static int Dongu14()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int sonuc = i * j;
                    if (sonuc % 56 == 4)
                        return sonuc;

                }
            }

            return 0;
        }

        private static void Dongu13()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("---{0}. çarpım tablosu---", i);
                for (int j = 1; j <= 10; j++)
                {
                    int sonuc = i * j;
                    if (sonuc % 7 == 0)
                        Console.WriteLine("{0} X {1} = {2}", i, j, sonuc);
                }
                Console.WriteLine(new string('-', 10));
            }

        }

        private static void Dongu12()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("---{0}. çarpım tablosu---", i);
                for (int j = 1; j <= 10; j++)
                {
                    int sonuc = i * j;
                    if (sonuc % 7 == 0)
                        break;

                    Console.WriteLine("{0} X {1} = {2}", i, j, sonuc);
                }
                Console.WriteLine(new string('-', 10));

                if (i >= 4)
                    break;
            }

            Console.WriteLine("Çıktım : " + i);
        }

        private static void Dongu11()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("---{0}. çarpım tablosu---", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, i*j);
                }
                Console.WriteLine(new string('-',10));
            }
        }

        private static void Dongu10()
        {
            //Big-O notation

            for (int i = 0; i < 10; i++)
            {
                // 10 defa çalışır O(n) => n=10 olduğunda O(10) karmaşıklık oluşturur.

                Console.WriteLine("i={0}. değer ",i);

                for (int j = 0; j < 10; j++)
                {
                    // Bu j değeri için 
                    // 10 defa çalışır O(n) => n=10 olduğunda O(10) karmaşıklık oluşturur.

                    // Ek olarak dış döngü i için 10 defa çalışan bir yapıdan dolayı limitlerin çarpımı kadar n*m => O(n^2) =>

                    // 100 defa çalışacaktır.
                    Console.WriteLine("\tj={0}. değer ",j);
                }
            }
        }

        private static void Dongu9()
        {

            int j = 0, k=0;
            int start, end;

            Console.Write("Start : ");
            int.TryParse(Console.ReadLine(), out start);
            Console.Write("End : ");
            int.TryParse(Console.ReadLine(), out end);

            if (start < end)
            {
                for (int i = start; i < end; i++)
                {
                    j++;
                    if (i % 2 == 0)
                        continue;

                    Console.WriteLine(i);
                }

                for (int i = start; i < end; i=i+2)
                {
                    k++;
                    Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Başlangıç değer bitiş değerinden büyük olamaz");
            Console.WriteLine("----");
            Console.WriteLine(j);
            Console.WriteLine("----");
            Console.WriteLine(k);
        }

        private static void Dongu8()
        {
            int start, end;

            Console.Write("Start : ");
            int.TryParse(Console.ReadLine(), out start);
            Console.Write("End : ");
            int.TryParse(Console.ReadLine(), out end);

            if (start < end)
            {
                for (int i = start; i < end; i++)
                {
                    if (i % 2 == 0)
                        continue;

                   Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Başlangıç değer bitiş değerinden büyük olamaz");
        }

        private static void Dongu7()
        {
            int start, end, artim;

            Console.Write("Start : ");
            int.TryParse(Console.ReadLine(), out start);
            Console.Write("End : ");
            int.TryParse(Console.ReadLine(), out end);
            Console.Write("Artım : ");
            int.TryParse(Console.ReadLine(), out artim);

            if (start < end)
            {
                for (int i = start; i < end; i = i + artim)
                {
                    Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Başlangıç değer bitiş değerinden büyük olamaz");
        }

        private static void Dongu6ek()
        {
            int start = 26;
            int end = 50;

            for (int i = start; i < end;)
            {
                start = start + 1;
                if (start % 2 == 0)
                {
                    //Tek sayıları ekrana yazdırmak
                    i = i + 2;
                    Console.WriteLine(i);
                    

                }
                else
                {
                    i = i + 1;
                    //Tek sayıları ekrana yazdırmak
                    Console.WriteLine(i);
                    
                }
            }
        }

        private static void Dongu6()
        {
            int start, end;

            Console.Write("Start : ");
            int.TryParse(Console.ReadLine(), out start);
            Console.Write("End : ");
            int.TryParse(Console.ReadLine(), out end);

            if (start < end)
            {
                //Koşul içinde tek sayıları mod(%) yardımı ile bulmak
                //for (int i = start; i < end; i++)
                //{
                //    //Tek sayıları ekrana yazdırmak
                //    if (i % 2 == 1)
                //        Console.WriteLine(i);
                //}

                if(start % 2 == 0) { start = start + 1; }

                for (int i = start; i < end; i = i + 2)
                {

                    //if (start % 2 == 0)
                    //{
                    //    i = i + 1;
                    //    //Tek sayıları ekrana yazdırmak
                    //    Console.WriteLine(i);

                    //}
                    //else
                    //{
                    //    //Tek sayıları ekrana yazdırmak
                    //    Console.WriteLine(i);
                    //    i = i + 2;
                    //}
                    Console.WriteLine(i);

                }
            }
            else
                Console.WriteLine("Başlangıç değer bitiş değerinden büyük olamaz");
        }

        private static void Dongu5()
        {
            int start, end;

            Console.Write("Start : ");
            int.TryParse(Console.ReadLine(), out start);
            Console.Write("End : ");
            int.TryParse(Console.ReadLine(), out end);

            if(start < end)
            {
                for (int i = start; i < end; i++)
                {
                    Console.WriteLine("{0}. deger {1}", i, i);
                }
            }
            else
                Console.WriteLine("Başlangıç değer bitiş değerinden büyük olamaz");


        }

        private static void Dongu4()
        {
            int start, end;

            Console.Write("Start : ");
            int.TryParse(Console.ReadLine(), out start);
            Console.Write("End : ");
            int.TryParse(Console.ReadLine(), out end);

            for (int i = start; i < end; i++)
            {
                Console.WriteLine("{0}. deger {1}", i , i);
            }
        }

        private static void Dongu3()
        {
            Console.Write("Limit : ");
            int limit;

            int.TryParse(Console.ReadLine(), out limit);

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Limit : {0}",limit);
        }

        private static void Dongu3Ek()
        {
            int limit = 0;
            try
            {
                Console.Write("Limit : ");
                limit = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {}

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Limit : {0}", limit);
        }

        private static void Dongu2()
        {
            // Hata olabilir bir örnek
            //Console.Write("Limit : ");
            //int limit = int.Parse(Console.ReadLine());

            //for (int i = 0; i < limit; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Hata yaklaması yapılarak iyileştirme yapıldı.
            try
            {
                Console.Write("Limit : ");
                int limit = int.Parse(Console.ReadLine());

                for (int i = 0; i < limit; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            
        }

        static void Dongu1()
        {
            //int limit = int.Parse(Console.ReadLine());

            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine((new Random().Next(10) + 1));
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    //Console.WriteLine((new Random().Next(10) + 1));
            //    Console.WriteLine(i);
            //}


            //for (int i = 10; i <= 10; i++)
            //{
            //    //Console.WriteLine((new Random().Next(10) + 1));
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i > 0; i--)
            //{
            //    //Console.WriteLine((new Random().Next(10) + 1));
            //    Console.WriteLine(i);
            //}

            for (int i = 1; i <= 10; ++i)
            {
                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------");

            for (int i = 1; i <= 10;)
            {
                ++i;
                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------");

            for (int i = 1; i <= 10;)
            {
                i = i * 2;
                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------");

            for (int i = 1; i <= 10;)
            {
                i = i + 2;
                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
            }


            Console.WriteLine("-----------");

            for (int i = 1; i <= 10;)
            {

                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
                i = i + 2;
            }

            Console.WriteLine("-----------");

            for (int i = 1; i <= 10; i = i + 2)
            {

                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
            }
        }
    }
}
