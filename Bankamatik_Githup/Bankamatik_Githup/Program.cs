using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bankamatik_Githup
{
    public class Program
    {
        static void Main(string[] args)
        {
            // #region Bankamatik
            /*   
             *   250 tl parası olacak 
            Bir bankamatik düşünülerek tasarlanacak bir program  için 
            Kartlı işlem    1
            Kartsız işlem   2
            //********Kartlı işlem bölümü
            Şifre istenecek=> Şifre:ab18
            ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
            //*******************Ana Menü 
            Para Çekmek için    1
            Para yatırmak için  2
            Para Transferleri   3
            Eğitim Ödemeleri    4
            Ödemeler            5
            Bilgi Güncelleme    6
           
            //*********************Seçim 1************
            Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
            Ana meüye dönmek için   9
            Çıkmak için             0
          
            //******************Seçim 2***********************
            Kredi Kartına   1
            Kendi Hesabınıza yatırmak için  2
            Ana Menü        9
            Çıkmak için     0
            //------------------------------------
            //----1
            Kredi kardı için en az 12 haneli kart numarasını girsin
            bakiye yeterli ise hesaptan kredi kartına para yatırılaca
            Ana Menü        9
            Çıkmak için     0
            //--------------------------
            //---2
            hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
            Ana Menü        9
            Çıkmak için     0
           
            
            //*****************************Seçim 3


            Başka Hesaba EFT    1
            Başka Hesaba Havale 2
            //---------------------------------
            //--1
            EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
            yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
            Ana Menü        9
            Çıkmak için     0
            //-----------------------------
            //---2
            hesap için 11 haneli hesap numarası işlemler doğru ise
            gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
            Ana Menü        9
            Çıkmak için     0
           
            
            //****************Seçim 4
            Eğitim Ödemeleri sayfası arızalı
            Ana Menü        9
            Çıkmak için     0
            
            //****************************Seçim 5
            Elektrik Faturası       1
            Telefon Faturası        2
            İnternet faturası       3
            Su Faturası             4
            OGS Ödemeleri           5
            //-----------------------------------------
            //---1 => bütün faturala için aşağıdaki şart yeterli
            fatura tutarı istenir, hesap uygun ise yatırılır değilse
            Ana Menü        9
            Çıkmak için     0
            //-----------------------------------
            //***************Seçim 6
            Şifre değiştirmek için 1
            Şifre değiştirme işlemi gerçekleştirilir
            Ana Menü        9
            Çıkmak için     0

             */

            int Sifre = 1234;
            int bakiye = 250;
            int hak = 3;

            while (true)
            {
                Console.WriteLine("***** Bankamatik Uygulumasına Hoş geldiniz *****");

                Console.WriteLine("Kartlı İşelmler (1) Kartşız İşelemler (2) ");
                int Islem = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                
                if(Islem == 1) // Kartlı İşlem Menüsü Giriş 
                {
                while (hak>0)
                { 
                     Console.WriteLine("Şifrenizi Giriniz");
                     int GirilenSifre = Convert.ToInt16(Console.ReadLine());
                      Console.Clear();

                     if (Sifre == GirilenSifre)// Kartlı İşelem Bölümü AnaMenüye Geçiş Sorgusu
                            
                     {
                            while (true)
                            {
                                Console.WriteLine("*** Ana Menü ***");
                                Thread.Sleep(1000);
                                Console.WriteLine("Para Çekmek İçin (1)\nPara Yatırmak İçin (2)\nPara Trasferi İçin (3)\nEğitim Ödeneleri İçin (4)\nÖdemeler İçin(5)\nBilgi Güncellemek İçin (6)");
                                int Secim = Convert.ToInt16(Console.ReadLine());
                                Console.Clear();

                                if (Secim == 1)//Para Çekmek İçin
                                {
                                    Console.WriteLine("Çekmek İstedğiniz Tutarı Giriniz");
                                    int Tutar = Convert.ToInt16(Console.ReadLine());
                                    Console.Clear();
                                    if (bakiye>=Tutar)
                                    {
                                        bakiye -= Tutar;
                                        Console.WriteLine("Paranızı Alabilirsiniz Kalan Bakiye {0} Anamenü İçin (9) Çıkış İçin (0) Basınız", bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bakiye Yetersiz Mevcut Bakiye {0}  Anamenü İçin (9) Çıkış İçin (0) Basınız ", bakiye);
                                    }
                                    
                                    int P1Secim = Convert.ToInt16(Console.ReadLine());
                                    if (P1Secim == 9)
                                    {
                                        Console.WriteLine("Anamenüye Geri Dönülüyor");
                                        Thread.Sleep(1000);
                                    }
                                    else if (P1Secim == 0)
                                    {
                                        Console.WriteLine("Çıkış Yapılıyor");
                                        Environment.Exit(0);
                                    }
                                }
                               
                                if (Secim == 2)//Para Yatırmak İçin
                                {
                                    while (true)
                                    {
                                    Console.WriteLine("Kredi Kartına (1)\nKendi Hesabına(2)\nAna Menü (3)\nAna Menü İçin (9)\n Çıkmak İçin(0) ");
                                    int P2secim = Convert.ToInt16(Console.ReadLine());
                                    Console.Clear();
                                        if (P2secim == 1)
                                        {
                                            Console.WriteLine("Yatıralacak Olan Kart Numarısını Giriniz ");
                                            string KartNo = Console.ReadLine();
                                            Console.Clear();
                                            if (KartNo.Length == 12)
                                            {
                                                Console.WriteLine("Yatarılacak Tutarı Giriniz");
                                                int Tutar = Convert.ToInt16(Console.ReadLine());
                                                Console.Clear();
                                                bakiye += Tutar;
                                                Console.WriteLine(" İşlem Başarıyla Gerçekleşti ");
                                                Thread.Sleep(1000);
                                                Console.WriteLine("Ana Menü İçin (9)\n Çıkmak İçin(0)");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Kart Numarısını Dogru Giriniz");
                                                Thread.Sleep(1000);
                                                Console.WriteLine("Ana Menü İçin (9)\n Çıkmak İçin(0)");


                                            }
                                            int Cıkıs = Convert.ToInt16(Console.ReadLine());
                                            if (Cıkıs == 9)
                                            {
                                                Console.WriteLine("Ana Menüye Dönülüyor ");
                                                break;

                                            }
                                            else if (Cıkıs == 0)
                                            {
                                                Console.WriteLine("Çıkış Yapılıyor");
                                                Thread.Sleep(1000);
                                                Environment.Exit(0);
                                            }
                                        }



                                        if (P2secim == 2)
                                        {
                                            Console.WriteLine("Tutar Giriniz ");
                                            int KdTutar = Convert.ToInt16(Console.ReadLine());
                                            Console.Clear();
                                            bakiye += KdTutar;
                                            Console.WriteLine("Mevcut Bakiye {0} ",bakiye);
                                            Console.WriteLine("Ana Menü İçin (9)\n Çıkmak İçin(0)");
                                        }
                                       int Cıkıs2 = Convert.ToInt16(Console.ReadLine());
                                        if (Cıkıs2 == 9)
                                        {
                                            Console.WriteLine("Ana Menüye Dönülüyor ");
                                            break;
                                        }
                                        else if (Cıkıs2 == 0)
                                        {
                                            Console.WriteLine("Çıkış Yapılıyor");
                                            Environment.Exit(0);
                                        }

                                    }

                                }
                                if (Secim == 3)// Trasfer İşlemleri 
                                {
                                    while(true){
                                        Console.WriteLine("Başka Hesaba Eft İçin (1)\nBaşka Hesaba Havale (2)");
                                        int secim = Convert.ToInt16(Console.ReadLine());
                                        Console.Clear();
                                        if (secim == 1)
                                        {

                                            string tr = "TR";
                                            Console.WriteLine("Lütfen İban Giriniz");
                                            string Eft = Console.ReadLine();
                                            Console.Clear();
                                            string IBAN = tr + Eft;
                                            if (IBAN.StartsWith("TR") && IBAN.Length == 14)
                                            {
                                                Console.WriteLine("Trasfer Edilecek Miktar");
                                                int Tutar = Convert.ToInt32(Console.ReadLine());
                                                Console.Clear();
                                                if (bakiye >= Tutar)
                                                {
                                                    bakiye -= Tutar;
                                                    Console.WriteLine("Mevcut Bakiye {0} ", bakiye);
                                                    Console.WriteLine("Ana Menü İçin (9)\n Çıkmak İçin(0)");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Bakiye Yetersiz ");
                                                    Console.WriteLine("Ana Menü İçin (9)\n Çıkmak İçin(0)");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Iban Hatalı ");
                                                Console.WriteLine("Ana Menü İçin (9)\n Çıkmak İçin(0)");
                                            }

                                            int Cıkıs2 = Convert.ToInt16(Console.ReadLine());
                                            if (Cıkıs2 == 9)
                                            {
                                                Console.WriteLine("Ana Menüye Dönülüyor ");
                                                break;

                                            }
                                            else if (Cıkıs2 == 0)
                                            {
                                                Console.WriteLine("Çıkış Yapılıyor");
                                                Environment.Exit(0);
                                            }
                                        }
                                        if(secim == 2)
                                        {
                                            Console.WriteLine("Havele Edilecek Hesap No ");
                                            string Hesap = Console.ReadLine();
                                            if (Hesap.Length ==11)
                                            {
                                                Console.WriteLine("Gönderilecek Tutarı Giriniz ");
                                                int Tutar = Convert.ToInt32(Console.ReadLine());
                                                if (bakiye >= Tutar)
                                                {
                                                    bakiye -= Tutar;
                                                    Console.WriteLine("Mevcut Bakiye {0}",bakiye);
                                                    Console.WriteLine("Ana Menü İçin (9)\n Çıkmak İçin(0)");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Bakiye Yetersiz");
                                                    Console.WriteLine("Ana Menü İçin (9)\n Çıkmak İçin(0)");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hesap No Hatalı");
                                                Console.WriteLine("Ana Menü İçin (9)\n Çıkmak İçin(0)");
                                            }
                                        }
                                        int Cıkıs = Convert.ToInt16(Console.ReadLine());
                                        if (Cıkıs == 9)
                                        {
                                            Console.WriteLine("Ana Menüye Dönülüyor ");
                                            break;

                                        }
                                        else if (Cıkıs == 0)
                                        {
                                            Console.WriteLine("Çıkış Yapılıyor");
                                            Thread.Sleep(1000);
                                            Environment.Exit(0);
                                        }
                                    }

                                }
                                if (Secim == 4)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("Eğitim Ödemeler Arzalı");
                                        Console.WriteLine("Ana Menü İçin (9)\n Çıkmak İçin(0)");
                                        int Cıkıs = Convert.ToInt16(Console.ReadLine());
                                        Console.Clear();
                                        if (Cıkıs == 9)
                                        {
                                            Console.WriteLine("Ana Menüye Dönülüyor ");
                                            break;

                                        }
                                        else if (Cıkıs == 0)
                                        {
                                            Console.WriteLine("Çıkış Yapılıyor");
                                            Thread.Sleep(1000);
                                            Environment.Exit(0);
                                        }
                                    }


                                }
                                if (Secim == 5)
                                {
                                    while (true)
                                    {


                                        Console.WriteLine("Elektrik Faturası (1)\nTelefon Faturası (2)\nİnternet Faturası (3)\nSu Faturası (4)\nOGS Faturası (5)");
                                        int secim = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        if (secim == 1 || secim==2 || secim == 3 || secim == 4 || secim == 5)
                                        {
                                            Console.WriteLine("Ücreti Giriniz ");
                                            int miktar = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            if (bakiye > miktar)
                                            {
                                                
                                                bakiye -= miktar;
                                                Console.WriteLine(" İşlem Başarıyla Gerçekleşti Bakiyeniz {0}",bakiye);
                                                Console.WriteLine("Ana Menü İçin (9)\n Çıkmak İçin(0)");
                                            }
                                        }
                                        int Cıkıs = Convert.ToInt16(Console.ReadLine());
                                        if (Cıkıs == 9)
                                        {
                                            Console.WriteLine("Ana Menüye Dönülüyor ");
                                            break;

                                        }
                                        else if (Cıkıs == 0)
                                        {
                                            Console.WriteLine("Çıkış Yapılıyor");
                                            Thread.Sleep(1000);
                                            Environment.Exit(0);
                                        }



                                    }
                                }
                                if (Secim == 6)
                                {
                                    while (true)
                                    {


                                        Console.WriteLine("Mevcut Şifreyi Giriniz");
                                        int Mvsifre = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        if (Mvsifre == Sifre)
                                        {
                                            Console.WriteLine("Yeni Şifre");
                                            int YnSifre = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            Console.WriteLine("Tekrar Giriniz");
                                            int tkSifre = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            if (YnSifre == tkSifre)
                                            {
                                                Sifre = YnSifre;
                                                Console.WriteLine("Şİfreniz Değiştirildi  Çıkış Yapılıyor");
                                                Thread.Sleep(1000);
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Girdiğiniz Şifreyle Uyuşmuyor Tekrar Deneyiniz ..");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Eşleşmiyor Tekrar Deneyiniz ");
                                        }


                                    }
                                }
                            }
                          


                        }
                     else
                     {
                     hak--;
                     Console.WriteLine("Hatalı Şifre Hakkınız {0} kaldı", hak+1);
                     } 
                }
                        if (hak == 0)
                        {
                            Console.Write("Program Kapanıyor Yapılıyor");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(2000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                        break;
                            //Environment.Exit(0);
                        }
                        
                        
                        
                    
                  

                }
                if (Islem ==2)
                {
                    Console.Write("Çalışma Yapılıyor ");
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);

                    Console.WriteLine("Başa Dönülüyor");
                    Console.Clear();
                }
             
            }
            

        }
    } 
}
