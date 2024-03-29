﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ogrenci_Takip
{
    class Program
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Yeni(Y),Güncelle(G),Sil(S),Ara(A),Listele(L)");
                string cevap = Console.ReadLine();

                if (cevap == "y")
                {
                    Ogrenci ogrenci = new Ogrenci();

                    Console.WriteLine("Adınız?");
                    string adicevap = Console.ReadLine();
                    ogrenci.Adi = adicevap;
                    Console.WriteLine("Soyadınız?");
                    string soyadicevap = Console.ReadLine();
                    ogrenci.Soyadi = soyadicevap;
                    Console.WriteLine("Numaranız?");
                    string numaracevap = Console.ReadLine();
                    ogrenci.Numara = Convert.ToInt32(numaracevap);
                    Console.WriteLine("Sınıfınız?");
                    string sinifcevap = Console.ReadLine();
                    ogrenci.Sınıf = sinifcevap;
                    Console.WriteLine("Doğum yılınız?");
                    string dogumyilicevap = Console.ReadLine();
                    ogrenci.DogumYili = Convert.ToInt32(dogumyilicevap);

                    ogrenciler.Add(ogrenci);
                }
                else if (cevap == "g")
                {
                    Console.WriteLine("Hangi numaralı öğrenciyi güncellemek istiyorsunuz?");
                    int guncellenecekNumara = Convert.ToInt32(Console.ReadLine());
                    bool secenekDogruMu = true;
                    while (secenekDogruMu)
                    {
                        Console.WriteLine("Öğrencinin hangi bilgisini güncellemek istiyorsunuz?");
                        Console.WriteLine("1.Adı");
                        Console.WriteLine("2.Soyadi");
                        Console.WriteLine("3.Sınıf");
                        Console.WriteLine("4.Numara");
                        Console.WriteLine("5.DogumYili");
                        int secenek = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < ogrenciler.Count; i++)
                        {
                            if (ogrenciler[i].Numara == guncellenecekNumara)
                            {
                                switch (secenek)
                                {
                                    case 1:
                                        Console.WriteLine("Yeni adı giriniz: ");
                                        ogrenciler[i].Adi = Console.ReadLine();
                                        secenekDogruMu = false;
                                        break;
                                    case 2:
                                        Console.WriteLine("Yeni soyadını giriniz: ");
                                        ogrenciler[i].Soyadi = Console.ReadLine();
                                        secenekDogruMu = false;
                                        break;
                                    case 3:
                                        Console.WriteLine("Yeni sınıfını giriniz: ");
                                        ogrenciler[i].Sınıf = Console.ReadLine();
                                        secenekDogruMu = false;
                                        break;
                                    case 4:
                                        Console.WriteLine("Yeni numaranızı giriniz: ");
                                        ogrenciler[i].Numara = Convert.ToInt32(Console.ReadLine());
                                        secenekDogruMu = false;
                                        break;
                                    case 5:
                                        Console.WriteLine("Yeni doğum yılınızı giriniz: ");
                                        ogrenciler[i].DogumYili = Convert.ToInt32(Console.ReadLine());
                                        secenekDogruMu = false;
                                        break;
                                    default:
                                        Console.WriteLine("Yanlış seçenek seçtiniz");
                                        break;
                                }
                            }
                        }
                    }
                }
                else if (cevap == "s")
                {
                    Console.WriteLine("Hangi numaralı öğrenciyi silmek istersiniz?");
                    string entry = Console.ReadLine();
                    int silinecekNumara = 0;

                    if (!String.IsNullOrEmpty(entry))
                    {
                        silinecekNumara = Convert.ToInt32(entry);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış bir tuşa bastınız");
                        Console.ReadLine();

                    }

                    for (int i = 0; i < ogrenciler.Count; i++)
                    {
                        if (ogrenciler[i].Numara == silinecekNumara)
                        {
                            ogrenciler.Remove(ogrenciler[i]);
                            Console.WriteLine("Öğrenci silindi");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız öğrenci bulunamadı.");
                        }
                    }
                }
                else if (cevap == "a")
                {
                    Console.WriteLine("Aranacak olan öğrencinin numarasını giriniz");
                    int aranacakNumara = Convert.ToInt32(Console.ReadLine());
                    bool ogrenciBulunduMu = false;

                    for (int i = 0; i < ogrenciler.Count; i++)
                    {
                        if (ogrenciler[i].Numara == aranacakNumara)
                        {
                            Console.WriteLine("Adı: " + ogrenciler[i].Adi);
                            Console.WriteLine("Soyadı: " + ogrenciler[i].Soyadi);
                            Console.WriteLine("Numarası: " + ogrenciler[i].Numara);
                            Console.WriteLine("Sınıfı: " + ogrenciler[i].Sınıf);
                            Console.WriteLine("Doğum Yılı: " + ogrenciler[i].DogumYili);
                            ogrenciBulunduMu = true;
                        }

                    }

                    if (ogrenciBulunduMu == false)
                    {
                        Console.WriteLine("Aradığınız öğrenci bulunamadı.");
                    }


                }
                else if (cevap == "l")
                {
                    Console.WriteLine("Adı                 " + "Soyadı              " + "Numarası            ");

                    for (int i = 0; i < ogrenciler.Count; i++)
                    {
                        string adi = ogrenciler[i].Adi;
                        string soyadi = ogrenciler[i].Soyadi;
                        string numarasi = ogrenciler[i].Numara.ToString();
                        int boslukSayisi = 20 - adi.Length;
                        int boslukSayisi2 = 20 - soyadi.Length;
                        int boslukSayisi3 = 20 - numarasi.Length;
                        for (int a = 0; a < boslukSayisi; a++)
                        {
                            adi += " ";
                        }
                        Console.Write(adi);

                        for (int a = 0; a < boslukSayisi2; a++)
                        {
                            soyadi += " ";
                        }
                        Console.Write(soyadi);

                        for (int a = 0; a < boslukSayisi3; a++)
                        {
                            numarasi += " ";
                        }
                        Console.Write(numarasi);
                        Console.WriteLine();
                    }
                   
                    Console.ReadLine();
                    

                }
            }
        }

        public class Ogrenci
        {
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public string Sınıf { get; set; }
            public int Numara { get; set; }
            public int DogumYili { get; set; }

        }

    }
}
