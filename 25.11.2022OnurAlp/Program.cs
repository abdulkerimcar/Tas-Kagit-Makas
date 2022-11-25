using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _25._11._2022OnurAlp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. kullanıcıdan yaş bilgisi alınız.Mantıklı,tutarlı bir yaş mı kontrol ediniz.
            //2.Yaş 20-65 arasındaysa riskli gruptasınız mesajı veriniz.
            //3.Yaş 0-20 ve 65-100 arasındaysa riskli grupta değilsiniz mesajını veriniz.
            //4.görev diğer girişler için hatalı giriş mesajı versin.
            /*
            Basla:
            bool yasMi;
            int Age;

            do
            {
                Console.WriteLine("lütfen yaşınızı giriniz");
                string Yas = Console.ReadLine();
                
                yasMi = int.TryParse(Yas, out Age);
                string sonuc = Age > 19 && Age < 66 ? "riskli gruptasınız" : (Age > 0 && Age < 20) || (Age > 65 && Age < 100) ? "riskli grupta değilisiniz" : "hatalı giriş yaptınız";
                Console.WriteLine(sonuc);
                goto Basla;



            } while (yasMi==false);
            */
            //2.yol

            //if (Age>20 && Age<65)
            //{
            //    Console.WriteLine("riskli gruptasınız");
            //}
            //else if (Age>0 && Age<20)
            //{
            //    Console.WriteLine("riskli grupta değilsini");
            //}
            //else if (Age > 65 && Age < 100)
            //{
            //    Console.WriteLine("riskli grupta değilsiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız");
            //}


            // kullanıcıya içeçek tercihini sorunuz ,tercihe göre ekrana tercihiniz ( çay kahve su) oldu yazınız.
            /*
            Basla:
            Console.WriteLine("hangi içeçeği tercih edersiniz");
            string cevap = Console.ReadLine();

            switch (cevap)
            {
                case "cay":
                    Console.WriteLine("tercihiniz çay oldu");
                    break;
                case "kahve":
                    Console.WriteLine("tercihiniz kahve oldu");
                    break;
                case "su":
                    Console.WriteLine("tercihiniz su oldu");

                    break;
                default:
                    Console.WriteLine("hatalı giriş yaptınız");
                    break;
                    goto Basla;
 
               


            }
            */
            //anket
            //satış yaptığımız 1 tane ürünümüzz var. Kullanıcı ürünü beğenip beğenmediğimizi ya da kararsız olma durumunu sorunuz.
            //ankete devam etmek istiyormusunuz diye sorunuz.
            //beğenme,beğenmeme,,kararsız sayısını anket sonunda ekrana yazdırınız.
            /*
            int like, unlike, kararsız;
            like = 0;
            unlike = 0;
            kararsız = 0;
            
           Devam: Console.WriteLine("Ankete devam etmek istiyormusunuz? E/H");
            string devam = Console.ReadLine();
            if (devam == "evet")
            {

                Console.WriteLine("ürünü beğendinizmi?");
                string cevap = Console.ReadLine();
                if (cevap == "beğendim")
                {
                    like++;
                }
                else if (cevap == "beğenmedim")
                {
                    unlike++;
                }
                else if (cevap == "kararsızım")
                {
                    kararsız++;
                }
                
                goto Devam;
            }
            else
            {
                Console.WriteLine("anket sonuclarına göre beğeni sayısı: " + like);
                Console.WriteLine("anket sonuclarına göre beğenmedi sayısı: " + unlike);
                Console.WriteLine("anket sonuclarına göre kararsız sayısı: " + kararsız);
            }
            */
            /////////////2.yol
            ///
            /*
            int like, unlike, kararsız;
            like = 0;
            unlike = 0;
            kararsız = 0;

             Console.WriteLine("Ankete devam etmek istiyormusunuz? E/H");
            string devam = Console.ReadLine();
           baslangic: Console.WriteLine("ürünü beğendinizmi?");
            string cevap = Console.ReadLine();
            switch (cevap.ToLower())
            {
                case "e":
                    like++;
                    break;
                case "h":
                    unlike++;
                    break;
                case "k":
                    kararsız++;
                    break;
                default:
                    Console.WriteLine("hatalı giriş yaptınız lütfen tekrar deneyin");
                    goto baslangic;
            }
            Anketsorgu:
            Console.WriteLine("ankete başka katılacak bir kullanıcı var mı ?");
            devam = Console.ReadLine();
            switch (devam.ToLower())
            {
                case "e":
                    goto baslangic;
                case "h":
                    Console.WriteLine($"Ankete katılan toplam kişi sayısı:  {like+unlike+kararsız}");
                    Console.WriteLine("anket sonuclarına göre beğeni sayısı: " + like);
                    Console.WriteLine("anket sonuclarına göre beğenmedi sayısı: " + unlike);
                    Console.WriteLine("anket sonuclarına göre kararsız sayısı: " + kararsız);
                    break:

                default:
                    Console.WriteLine("hatalı giriş yaptınız");
                    goto Anketsorgu;
                    break;
            }
            */

            // Taş kağıt makas oyunu
            //kullanıcı ve bilgisayar
            //el bittiği zaman kazananı yazdırınız.
            //tekrar oynayıp oynamak istemediğini sorunuz
            //skor tutunuz
            //oyun sürdükçe skoru güncelleyiniz

            /*
            int kaybeden = 0;
            int kazanan = 0;
            int berabere = 0;
            string kullanici = "";
            do
            {
                Console.WriteLine("oyun sürekli devam edecek eğer çıkış yapmak istiyorsanız x tuşuna basınız");

                Console.WriteLine("lütfen taş kağıt makas seçeneklerinden birini giriniz");
                kullanici = Console.ReadLine();
                string[] PCsecenek = { "tas", "kagit", "makas" };
                Random pc = new Random();
                int dizi = pc.Next(3);

                if (kullanici == "tas" && PCsecenek[dizi] == "makas")
                {
                    kazanan++;
                }
                if (kullanici == "tas" && PCsecenek[dizi] == "kagit")
                {
                    kaybeden++;
                }
                if (kullanici == "makas" && PCsecenek[dizi] == "tas")
                {
                    kaybeden++;
                }
                if (kullanici == "makas" && PCsecenek[dizi] == "kagit")
                {
                    kazanan++;
                }
                if (kullanici == "kagit" && PCsecenek[dizi] == "tas")
                {
                    kazanan++;
                }
                if (kullanici == "kagit" && PCsecenek[dizi] == "makas")
                {
                    kaybeden++;
                }
                if (kullanici == "kagit" && PCsecenek[dizi] == "kagit")
                {
                    berabere++;
                }
                if (kullanici == "makas" && PCsecenek[dizi] == "makas")
                {
                    berabere++;
                }
                if (kullanici == "tas" && PCsecenek[dizi] == "tas")
                {
                    berabere++;
                }

                Console.WriteLine("kullanıcı bilgisayari yi " + kazanan + " kadar yendi");
                Console.WriteLine("bilgisayar kullanıcı yi " + kaybeden + " kadar yendi");
                Console.WriteLine("bilgisayar ile kullanıcı  " + berabere + " kadar beraber kaldı");

            } while (kullanici !="x");
            
            */


            int kaybeden = 0;
            int kazanan = 0;
            int berabere = 0;
            string kullanici ;
            do
            {
                Console.WriteLine("oyun sürekli devam edecek eğer çıkış yapmak istiyorsanız x tuşuna basınız");

                Console.WriteLine("lütfen taş kağıt makas seçeneklerinden birini giriniz");
                kullanici = Console.ReadLine();
                string[] PCsecenek = { "tas", "kagit", "makas" };
                Random pc = new Random();
                int dizi = pc.Next(3);

                if ((kullanici == "tas" && PCsecenek[dizi] == "makas")||(kullanici == "makas" && PCsecenek[dizi] == "kagit")||(kullanici == "kagit" && PCsecenek[dizi] == "tas"))
                {
                    kazanan++;
                }
                if ((kullanici == "tas" && PCsecenek[dizi] == "kagit")||(kullanici == "makas" && PCsecenek[dizi] == "tas")|| (kullanici == "kagit" && PCsecenek[dizi] == "makas"))
                {
                    kaybeden++;
                }
                if ((kullanici == "kagit" && PCsecenek[dizi] == "kagit")|| (kullanici == "makas" && PCsecenek[dizi] == "makas")|| (kullanici == "tas" && PCsecenek[dizi] == "tas"))
                {
                    berabere++;
                }
                else
                {
                    Console.WriteLine("yanlış giriş yaptınız");
                }

                Console.WriteLine("Senin kazandığın skor: " + kazanan );
                Console.WriteLine("bilgisayarın kazandığı skor: " + kaybeden );
                Console.WriteLine("Berabere kalınan skor:  " + berabere );

            } while (kullanici != "x");


            Console.ReadKey();

        }
    }
}
