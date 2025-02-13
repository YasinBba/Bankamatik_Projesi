using System.Threading.Channels;

namespace Bankamatik_Projesi
{
    internal class Program
    {
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

           
            Console.WriteLine(3-hak +1+ ". Hakkınız için Şifrenizi Giriniz )" );
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
            } while (hak>0);
        }

        static void AnaMenu()
        {
            Console.WriteLine("Ana Menüye Hoşgeldiniz");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz \n 1\t Para Çekme \n 2\t Para Yatırma ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine(  " Para Çekme Menüsüne Hoşgeldiniz");
            }
        }


    }
}
