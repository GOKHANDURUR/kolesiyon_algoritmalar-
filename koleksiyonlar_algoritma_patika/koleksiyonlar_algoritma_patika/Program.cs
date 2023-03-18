using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyonlar_algoritma_patika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ödev - 2
            Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            (ArrayList sınıfını kullanarak yazınız.)

            Negatif ve numeric olmayan girişleri engelleyin.
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            
            ArrayList AsalSayilar = new ArrayList();
            ArrayList AsalOlmayanSayilar = new ArrayList();
            for (int i = 0; i <20; i++)
            {
                X:
                Console.WriteLine("Pozitif bir sayı giriniz: ");
                try
                {
                    int sayi=Convert.ToInt32(Console.ReadLine());
                    if (sayi <= 0)
                    {
                        Console.WriteLine("negatif veya notr bir değer girdiniz");
                        goto X;
                    }
                    else if (sayi >= 2)
                    {
                        int mod = 0;
                        for (int j = 2; j <=sayi; j++)
                        {
                            if(sayi % j == 0)
                            {
                                mod++;
                            }
                            if (mod == 2)
                            {
                                AsalOlmayanSayilar.Add(sayi);
                                break;
                            }
                        }
                        if(mod == 1)
                        {
                            AsalSayilar.Add(sayi);
                        }

                    }
                    else
                    {
                        AsalOlmayanSayilar.Add(sayi);
                    }
                }
                catch {
                    Console.WriteLine("numeric olmayan bir değer girdiniz");
                    goto X;
                }              

            }

            AsalOlmayanSayilar.Sort();
            AsalSayilar.Sort();
            Console.Write("Asal olmayan sayılar: ");
            foreach (int i in AsalOlmayanSayilar)
                Console.Write(i+" ");
            Console.Write("Asal sayılar: ");
            foreach (int i in AsalSayilar)
                Console.Write(i+" ");
            Console.WriteLine();
            double asalolmayanlar = AsalOlmayanSayilar.Count;
            double asallar = AsalSayilar.Count;


            Console.WriteLine(asalolmayanlar);
            Console.WriteLine(asallar);
            double asaltoplam = 0;
            foreach (int i in AsalSayilar)
            {
                asaltoplam = asaltoplam + i;
            }
            double asalolmayantoplam = 0;
            foreach (int i in AsalOlmayanSayilar)
            {
                asalolmayantoplam = asalolmayantoplam + i;
            }
            double a = asaltoplam / asallar;
            Console.WriteLine(string.Format("{0:0.00}",a ));
            double b = asalolmayantoplam / asalolmayanlar;
            Console.WriteLine(string.Format("{0:0.00}", b));
            */

            /*
            Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını 
            console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            
            int[] sayilar=new int[20];
            for (int i = 0; i < 20; i++)
            {
            X:
                Console.WriteLine("Bir sayı giriniz: ");
                try
                {
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    sayilar[i] = sayi;
                }
                catch
                {
                    Console.WriteLine("numeric olmayan bir değer girdiniz");
                    goto X;
                }
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayi = 0;
                for (int j = i+1; j < sayilar.Length; j++)
                {
                    if (sayilar[i] > sayilar[j])
                    {
                        sayi=sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = sayi;
                    }
                }
            }
            double kucuk1=sayilar[0];
            double kucuk2=sayilar[1];
            double kucuk3=sayilar[2];
            double buyuk1=sayilar[19];
            double buyuk2=sayilar[18];
            double buyuk3=sayilar[17];
            Console.WriteLine("3 küçük sayının ortalaması " + (kucuk1 + kucuk2 + kucuk3) / 3 + " 3 büyük sayının ortalaması: " + (buyuk1 + buyuk3 + buyuk2) / 3);
            */
            /*
            Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
            ve dizinin elemanlarını sıralayan programı yazınız.
        
            Console.WriteLine("Bir cümle yazınız: ");
            string cumle=Console.ReadLine();
            string sesli = null;
            foreach (char c in cumle)
            {
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'ı':
                    case 'i':
                    case 'u':
                    case 'ü':
                    case 'o':
                    case 'ö':
                        {
                            sesli += c;
                            break;
                        }

                }
            }
            Console.WriteLine(sesli);
            */

            Console.ReadKey();

            
            }
    }
}
