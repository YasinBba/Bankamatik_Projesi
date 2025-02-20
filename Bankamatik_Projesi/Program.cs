using System.Threading.Channels;

namespace Bankamatik_Projesi
{
    internal class Program
    {
        static int bakiye = 250;
        static string sifre = "ab18";

        static void Main(string[] args)
        {
            IlkGiris();


        }

        static void IlkGiris()
        {

            do
            {


                Console.WriteLine("Kartlı İşlem İçin 1 Tuşlayınız");
                Console.WriteLine("Kartsız İşlem İçin 2 Tuşlayınız");
                //1-2
                string IlkGiris = Console.ReadLine();

                if (IlkGiris == "1")
                {
                    Console.WriteLine("Kartlı İşlem Menüsüne Hoşgeldiniz");
                    Login();
                    break;
                }
                else if (IlkGiris == "2")
                {
                    Console.WriteLine("Kartsız İşlem Menüsüne Hoşgeldiniz");
                    break;
                }

                else
                {
                    Console.WriteLine("Lütfen Seçeneklerin Dışına Çıkmayınız");
                }
            } while (true);

        }
        static void Login()
        {
            int hak = 3;
            Console.WriteLine("Şifreniz için (3 Hakkınız Vardır!)");
            do
            {


                Console.WriteLine("Lütfen Şifrenizi Giriniz\nKalan Giriş Hakkınız   "+hak);
                string girilensifre = Console.ReadLine();
                if (girilensifre==sifre)
                {
                    Console.WriteLine(" Ana Menüye Yönlendiriliyorsunuz...");
                    AnaMenu();
                    return;
                }
                else
                {
                    Console.WriteLine("Yanlış şifre");
                    hak--;
                }
            } while (hak > 0);
        }

        static void AnaMenu()
        {
            Console.WriteLine("Ana Menüye Hoşgeldiniz");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz 1-Para Çekme 2-Para Yatırma 3-Para Transferleri  4-Eğitim Ödemeleri 5-Fatura Ödemeleri  6-Bilgi Güncellemesi ");
            string secim = Console.ReadLine();


            if (secim == "1")
            {
                Console.WriteLine(" Para Çekme Menüsüne Hoşgeldiniz");
                ParaCekme();
                return;
            }
            else if (secim == "2")
            {
                Console.WriteLine("Para Yatırma Menüsüne Hoşgeldiniz");
                ParaYatırma();
                return;

            }
            else if (secim == "3")
            {
                Console.WriteLine("Para Transferleri Menüsüne Hoşgeldiniz");
                ParaTransfer();
                    return;
            }
            else if (secim == "4")
            {
                Console.WriteLine("Eğitim Ödemeleri Menüsüne Hoşgeldiniz");
                EğitimÖdeme();
                return;
            }
            else if (secim == "5")
            {
                Console.WriteLine("Fatura Ödemeleri Menüsüne Hoşgeldiniz");
                FaturaÖdeme();
                return;
            }
            else if (secim == "6")
            {
                Console.WriteLine("Bilgi Güncelleme Menüsüne Hoşgeldiniz");
                BilgiGüncelle();
                return;
            }
            else
            {
                Console.WriteLine("Lütfen Seçenekler Doğrultusunda Seçim Yapınız");
                AnaMenu();
            }

        }
        static void ParaCekme()
        {
            Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz \nBakiyeniz:" + bakiye);
            int CekmeTutar = Convert.ToInt32(Console.ReadLine());


            if (CekmeTutar <= bakiye)
            {
                Console.WriteLine("Paranız Veriliyor, İşlem Başarılı");
                Console.WriteLine("- **9:** Ana menüye dön. \r\n- **0:** Çıkış yap.  ");
                if (Console.ReadLine() == "9")
                {
                    Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");
                    bakiye = bakiye - CekmeTutar;
                    AnaMenu();
                }
                else if (Console.ReadLine() == "0")
                {
                    Console.WriteLine("Çıkış Yapılıyor");
                }

            }
            else
            {
                Console.WriteLine("Yetersiz Bakiye");
                Console.WriteLine("- **9:** Ana menüye dön. \r\n- **0:** Çıkış yap.  ");
                if (Console.ReadLine() == "9")
                {
                    Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");
                    bakiye = bakiye - CekmeTutar;
                    AnaMenu();
                }
                else if (Console.ReadLine() == "0")
                {
                    Console.WriteLine("Çıkış Yapılıyor");
                }
            }


        }
        static void ParaYatırma()
        {
            Console.WriteLine("Kredi Kartına Para Yatırmak İçin 1'i Tuşlayınız" +
                "\nHesaba Para Yatırmak İçin 2'yi Tuşlayınız \nBakiyeniz:" + bakiye);
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {

                Console.WriteLine("12 Haneli Kredi Kartı Numaranızı Giriniz");
                string kknumara = Console.ReadLine();
                if (kknumara.Length == 12)
                {
                    Console.WriteLine("Yatırmak İstediğiniz Miktarı Giriniz");
                    int kkmiktar = Convert.ToInt32(Console.ReadLine());
                    if (kkmiktar <= bakiye)
                    {
                        Console.WriteLine("Yatırma İşleminiz Gerçekleşmiştir");
                        AnaMenu() ;
                        
                        Console.WriteLine("- **9:** Ana menüye dön. \r\n- **0:** Çıkış yap.  ");
                        if (Console.ReadLine() == "9")
                        {
                            Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");
                            bakiye = bakiye - kkmiktar;
                            AnaMenu();
                        }
                        else if (Console.ReadLine() == "0")
                        {
                            Console.WriteLine("Çıkış Yapılıyor");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bakiyeniz Yetersiz");
                        ParaYatırma();
                    }

                }
                else
                {
                    Console.WriteLine("Lütfen 12 Haneli Kredi Kartı Numaranızı Doğru Giriniz");
                    ParaYatırma();
                }
            }
            else if (secim == 2)
            {
                Console.WriteLine("Hesabınıza Yatırmak İstediğiniz Tutarı Giriniz ");
                int hesapyatırma = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine("Hesabınıza\t" + hesapyatırma + "TL Yatırdınız");
                Console.WriteLine("- **9:** Ana menüye dön. \r\n- **0:** Çıkış yap.  ");
                if (Console.ReadLine() == "9")
                {
                    Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");
                    bakiye = bakiye + hesapyatırma;
                    AnaMenu();
                }
                else if (Console.ReadLine() == "0")
                {
                    Console.WriteLine("Çıkış Yapılıyor");
                }

            }


        }
        static void ParaTransfer()
        {
            Console.WriteLine("\nBaşka Bir Hesaba ETF Yapmak İçin 1'\nBaşka Hesaba Havale Yapmak İçin Lütfen 2'yi Tuşlayınız\nBakiyeniz:"+bakiye);
            int secim=Convert.ToInt32(Console.ReadLine());
            if (secim==1)
            {
                Console.WriteLine("Lütfen 'TR'ile Başlayan 14 Karakterli İban Numarası Giriniz");
                string ibannumara = Console.ReadLine();
                if(ibannumara.StartsWith("TR")&& ibannumara.Length==16)
                {
                    Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                    int ibanmiktar = Convert.ToInt32(Console.ReadLine());
                    if (ibanmiktar<=bakiye)
                    {
                        Console.WriteLine("Yatırma İşleminiz Gerçekleşmiştir");
                        bakiye= bakiye - ibanmiktar;
                        AnaMenu();
                    }
                    else
                    {
                        Console.WriteLine("Bakiyeniz Yetersiz");
                        Console.WriteLine("- **9:** Ana menüye dön. \r\n- **0:** Çıkış yap.  ");
                        if (Console.ReadLine() == "9")
                        {
                            Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");
                            
                            AnaMenu();
                        }
                        else if (Console.ReadLine() == "0")
                        {
                            Console.WriteLine("Çıkış Yapılıyor");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen Doğru İban Numarası Giriniz!");
                    ParaTransfer();
                }
            }
            else if (secim==2)
            {
                Console.WriteLine("Lütfen 11 Haneli Hesap Numarasını Giriniz");
                string hesapnumara = Console.ReadLine();
                if (hesapnumara.Length==11)
                {
                    Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                    int hesapmiktar=Convert.ToInt32(Console.ReadLine());
                    if (hesapmiktar<=bakiye)
                    {
                        Console.WriteLine("Yatırma İşleminiz Gerçekleşmiştir");
                        bakiye=bakiye - hesapmiktar;
                        AnaMenu();
                    }
                    else
                    {
                        Console.WriteLine("Bakiyeniz Yetersiz");
                        Console.WriteLine("- **9:** Ana menüye dön. \r\n- **0:** Çıkış yap.  ");
                        if (Console.ReadLine() == "9")
                        {
                            Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");

                            AnaMenu();
                        }
                        else if (Console.ReadLine() == "0")
                        {
                            Console.WriteLine("Çıkış Yapılıyor");
                        }

                    }
                            
                }
            }
            else
            {
                Console.WriteLine("Lütfen Doğru Hesap Numarası Giriniz!");
                ParaTransfer();
            }
        }
        static void EğitimÖdeme()
        {
            Console.WriteLine("Eğitim Ödemeleri Sayfası Arızalıdır");
            Console.WriteLine("- **9:** Ana menüye dön. \r\n- **0:** Çıkış yap.  ");
            if (Console.ReadLine() == "9")
            {
                Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");

                AnaMenu();
            }
            else if (Console.ReadLine() == "0")
            {
                Console.WriteLine("Çıkış Yapılıyor");
            }
        }
        static void FaturaÖdeme()
        {
            Console.WriteLine("Lütfen Ödemek İstediğiniz Fatura Türünü Seçiniz\n1-Elektrik Faturası\n2-Telefon Faturası\n3-İnternet Faturası\n4-Su Faturası\n5-OGS Ödemeleri");
            int faturasecim=Convert.ToInt32(Console.ReadLine());
            if (faturasecim >=1 && faturasecim <=5) 
            {
                Console.WriteLine("Lütfen Fatura Tutarını Giriniz");
                int faturatutar =Convert.ToInt32(Console.ReadLine());
                if (faturatutar<=bakiye)
                {
                    Console.WriteLine("Faturanız Yatırılmıştır");
                    bakiye = bakiye - faturatutar;
                    AnaMenu();
                }
                else
                {
                    Console.WriteLine("Bakiyeniz Fatura Ödemeniz İçin Yetersiz");
                    Console.WriteLine("- **9:** Ana menüye dön. \r\n- **0:** Çıkış yap.  ");
                    if (Console.ReadLine() == "9")
                    {
                        Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");

                        AnaMenu();
                    }
                    else if (Console.ReadLine() == "0")
                    {
                        Console.WriteLine("Çıkış Yapılıyor");
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen Ödemek İstediğiniz Fatura Türlerinden Birini Seçiniz");
                FaturaÖdeme();
            }
        }
        static void BilgiGüncelle()
        {
            Console.WriteLine("Bu Kısımdan Şifrenizi Güncelleyebilirsiniz\nLütfen Eski Şifrenizi Giriniz");
            string girilenMevcutSifre = Console.ReadLine();
            if (girilenMevcutSifre==sifre)
            {
                Console.WriteLine("Yeni Şifrenizi Giriniz");
                string girilenYeniSifre = Console.ReadLine();
                sifre = girilenYeniSifre;
                Console.WriteLine("Şifreniz Başarıyla Değiştirildi");
                AnaMenu();
            }
            else
            {
                Console.WriteLine("Lütfen Eski Şifrenizi Doğru Giriniz!");
                BilgiGüncelle();
            }
        }


    }
}
