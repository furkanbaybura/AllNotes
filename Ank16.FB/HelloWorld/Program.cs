

        static void calismalar1()
        {
            int a = 10;
            int b;
            b = 20;
    //test

            Console.WriteLine("A=" + a + " B=" + b);
            Console.WriteLine("A={0}\n B={1}", a, b);

            Console.WriteLine("A\\B = {0}\\{1}", a, b);



            Console.WriteLine("lütfen birinci sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lütfen ikinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("yapmak istediginiz islemi giriniz");
            string islem = Console.ReadLine();

            if (islem == "+")
            {

                int result = (sayi1 + sayi2);
                Console.WriteLine("A={0} {3} B={1} islem={2}", sayi1, sayi2, result, islem);

            }
            if (islem == "-")
            {

                int result = (sayi1 - sayi2);
                Console.WriteLine("A={0} {3} B={1} islem={2}", sayi1, sayi2, result, islem);

            }
            if (islem == "*")
            {

                int result = (sayi1 * sayi2);
                Console.WriteLine("A={0} {3} B={1} islem={2}", sayi1, sayi2, result, islem);

            }
            if (islem == "/")
            {

                int result = (sayi1 / sayi2);
                Console.WriteLine("{0} {3} {1} = {2}", sayi1, sayi2, result, islem);

            }


            Console.ReadKey();
        }

        static void calismalar2()
        {
        }

        static void calismalar3()
        { }

        static void calismalar4()
        {

            int sayi = 0;
            int sayi2 = 0;
            double sonuc;
            Console.Write("Sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("üssü gir");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Karesi=" + (sayi * sayi));
            //Console.WriteLine("Küpü=" + (sayi * sayi * sayi));
            //Console.ReadKey();

            sonuc = Math.Pow(sayi, sayi2);
            Console.WriteLine(sonuc);

        }

        static void calismalar5()
        {
            int saniye;
            int dakika = 0;
            int saat;
            int saniye1;

            Console.WriteLine("saniyeyi gir");
            Console.WriteLine(saniye = Convert.ToInt32(Console.ReadLine()));



            saat = (saniye / 3600);
            saniye1 = (saniye - saat * 3600);
            dakika = (saniye1 - dakika * 60);

            Console.WriteLine("saniye= " + saniye1);
            Console.WriteLine("dakika= " + dakika);
            Console.WriteLine("saat= " + saat);








        }
        static void calismalar6()
        {

            string isim;
            int maas;
            decimal vergi;
            char guvenlik;
            string bilgi;


            Console.WriteLine("adınızı giriniz : ");
            isim = Console.ReadLine();
            Console.WriteLine("maasinizi giriniz : ");
            maas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vergi oranını giriniz : ");
            vergi = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("güvenlik için bir harf giriniz : ");
            guvenlik = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("medeni durumunuz nedir : ");
            Boolean medenidurum = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("kendiniz hakkında bilgi veriniz : ");
            bilgi = Console.ReadLine();

            Console.WriteLine("Adı Soyadı : " + isim);
            Console.WriteLine("Maasi : " + maas);
            Console.WriteLine("Vergi Oranı : " + vergi);
            Console.WriteLine("Guvenlik karakteri : " + guvenlik);


        }

        

    



}

        

        
    
 