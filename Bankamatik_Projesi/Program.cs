using System.Threading.Channels;

namespace Bankamatik_Projesi
{
    internal class Program
    {
        static int bakiye = 250;

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


                Console.WriteLine(3 - hak + 1 + ". Hakkınız için Şifrenizi Giriniz )");
                string sifre = Console.ReadLine();
                if (sifre == "ab18")
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
            }
            else if (secim == "4")
            {
                Console.WriteLine("Eğitim Ödemeleri Menüsüne Hoşgeldiniz");
            }
            else if (secim == "5")
            {
                Console.WriteLine("Fatura Ödemeleri Menüsüne Hoşgeldiniz");
            }
            else if (secim == "6")
            {
                Console.WriteLine("Bilgi Güncelleme Menüsüne Hoşgeldiniz");
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
                        bakiye = bakiye - kkmiktar;
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
                bakiye = bakiye + hesapyatırma;
                Console.WriteLine("Hesabınıza" + hesapyatırma + "TL Yatırdınız");
                Console.WriteLine("- **9:** Ana menüye dön. \r\n- **0:** Çıkış yap.  ");

            }


        }


    }
}
