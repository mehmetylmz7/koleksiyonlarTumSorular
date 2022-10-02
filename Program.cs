using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyonlarTumSorular
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            Negatif ve numeric olmayan girişleri engelleyin.
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın. 
             */
            ArrayList asalSayi = new ArrayList();
            ArrayList normalSayi = new ArrayList();

            int[] sayilar = new int[20];

            Console.WriteLine("lutfen 20 adet pozitif sayi giriniz..");

            for (int i = 0; i <= 19; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz..", i + 1);

                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }


            for (int i = 0; i <= 19; i++)
            {
                if (sayilar[i] == 0 || sayilar[i] == 1)
                {
                    normalSayi.Add(sayilar[i]);
                }


                else
                {
                    for (int j = 2; j < sayilar[i]; j++)
                    {
                        if (sayilar[i] % j == 0)
                        {
                            normalSayi.Add(sayilar[i]);
                            break;
                        }
                    }
                }
            }


            for (int i = 0; i <= 19; i++)
            {
                if (normalSayi.Contains(sayilar[i]))
                {

                }
                else
                {
                    asalSayi.Add(sayilar[i]);
                }
            }






            int asalSayilarToplami = 0;
            int normalSayiToplami = 0;

            foreach (var asa in asalSayi)
            {
                asalSayilarToplami = asalSayilarToplami + Convert.ToInt32(asa);
            }

            foreach (var norm in normalSayi)
            {
                normalSayiToplami = normalSayiToplami + Convert.ToInt32(norm);
            }


            Console.WriteLine("{0} adet asal sayi vardir", asalSayi.Count);
            Console.WriteLine("{0} adet normal sayi vardir", normalSayi.Count);
            Console.WriteLine("asal sayılar toplamı:{0}", asalSayilarToplami);
            Console.WriteLine("normal sayılar toplamı:{0}", normalSayiToplami);
            Console.WriteLine("asal sayılar ortalaması :{0}", asalSayilarToplami / asalSayi.Count);
            Console.WriteLine("normal sayılar ortalaması:{0}", normalSayiToplami / normalSayi.Count);






            asalSayi.Sort();
            normalSayi.Sort();

            Console.WriteLine("ASAL SAYILAR");
            foreach (var asalSayilar in asalSayi)
            {
                Console.WriteLine(asalSayilar);
            }



            Console.WriteLine("NORMAL SAYILAR");
            foreach (var normalSayilar in normalSayi)
            {
                Console.WriteLine(normalSayilar);
            }




            Console.ReadLine();


            /*
            Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde 
            ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
             */

            ArrayList sayilar = new ArrayList();
            ArrayList yuksekSayilar = new ArrayList();
            ArrayList dusukSayilar = new ArrayList();
            int yuksekSayilarToplami = 0;
            int dusukSayilarToplami = 0;



            Console.WriteLine("lutfen 20 adet pozitif sayi giriniz..");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz..", i + 1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);

            }



            sayilar.Sort();
            Console.WriteLine("en dusuk 3 sayi:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sayilar[i]);
                dusukSayilar.Add(sayilar[i]);
            }

            sayilar.Reverse();
            Console.WriteLine("en buyuk 3 sayi:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sayilar[i]);
                yuksekSayilar.Add(sayilar[i]);
            }



            for (int i = 0; i < 3; i++)
            {
                yuksekSayilarToplami = yuksekSayilarToplami + Convert.ToInt32(yuksekSayilar[i]);

            }
            Console.WriteLine("yuksek sayilar toplami:{0}", yuksekSayilarToplami);

            for (int i = 0; i < 3; i++)
            {
                dusukSayilarToplami = dusukSayilarToplami + Convert.ToInt32(dusukSayilar[i]);
            }
            Console.WriteLine("dusuk sayilar toplami:{0}", dusukSayilarToplami);


            Console.WriteLine("yuksek sayilarin ortalamasi:{0}", yuksekSayilarToplami / yuksekSayilar.Count);
            Console.WriteLine("dusuk sayilarin ortalamasi:{0}", dusukSayilarToplami / dusukSayilar.Count);



            Console.ReadLine();

            /*
           Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
           ve dizinin elemanlarını sıralayan programı yazınız. */


            Console.WriteLine("Bir cümle giriniz:");
            string cumle = Console.ReadLine();
            string sesliHarfler = "aeıioöuü";
            ArrayList sesliDizi = new ArrayList();
            if (!string.IsNullOrEmpty(cumle))
            {
                string cumleK = cumle.ToLower();
                for (int i = 0; i < cumle.Length; i++)
                {
                    if (sesliHarfler.Contains(cumleK[i]))
                    {
                        sesliDizi.Add(cumleK[i]);
                    }
                }
            }

            sesliDizi.Sort();

            foreach (var harf in sesliDizi)
            {
                Console.WriteLine(harf);
            }

            Console.ReadLine();






        }









    }
}
