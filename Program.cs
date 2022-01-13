using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T -> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            System.Console.WriteLine(renkListesi.Count);
            System.Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.ForEach
            foreach (var item in sayiListesi)
            {
                System.Console.WriteLine(item);
            }
            foreach (var item in renkListesi)
            {
                System.Console.WriteLine(item);
            }
            sayiListesi.ForEach(x=>System.Console.WriteLine(x));
            renkListesi.ForEach(z=>System.Console.WriteLine(z));

            //Listeden Eleman Çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(x=>System.Console.WriteLine(x));
            renkListesi.ForEach(z=>System.Console.WriteLine(z));

            //Liste İçerisinde Arama
            if(sayiListesi.Contains(10))
                System.Console.WriteLine("10 Liste İçerisinde Bulundu!");

            //Eleman ile indexe ulaşma
            System.Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

            //Diziyi List e Çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi Nasıl temizleriz ?
            hayvanListesi.Clear();

            //List İçerisinde nesne Tutmak.
            List<Kullanicilar> UserList = new List<Kullanicilar>();
            Kullanicilar User1 = new Kullanicilar();
            User1.Isim = "Melih Ömer";
            User1.SoyIsım = "Kamar";
            User1.Yas=24;

            Kullanicilar User2 = new Kullanicilar();
            User2.Isim="Ömer Melih";
            User2.SoyIsım="Kamar";
            User2.Yas=25;
            UserList.Add(User1);
            UserList.Add(User2);
            
            List<Kullanicilar> newList = new List<Kullanicilar>();
            newList.Add(new Kullanicilar(){
                    Isim="Deniz",
                    SoyIsım="Arda",
                    Yas=27
            });
            foreach (var item in UserList)
            {
                System.Console.WriteLine("Kullanıdı Adı :"+ item.Isim);
                System.Console.WriteLine("Kullanıdı Soy Adı :"+ item.SoyIsım);
                System.Console.WriteLine("Kullanıdı Yaşı :"+ item.Yas);
            }
            newList.Clear();

            
            

        }
    }

    public class Kullanicilar
    {
        
       private string isim;
       private string soyIsım;
       private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsım { get => soyIsım; set => soyIsım = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
