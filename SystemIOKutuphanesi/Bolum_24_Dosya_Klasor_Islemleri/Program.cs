

using System.IO;


namespace Bolum_24_Dosya_Klasor_Islemleri
{
    internal class Program
    {

        //#region VİDEO

        //static void Main(string[] args)
        //{

        //}

        //#endregion


        #region VİDEO 220 Bilgilendirme

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 24 Dosya ve Klasor Islemleri V220 Bilgilendirme

        //    */


        //    /*

        //    1. not baslangıç

        //    CSharpEgitim_2 dersinin bölüm 24 ü ayrı olarak işlemek istedim

        //    Bu bölümde C# ı kullanarak sabit diskimiz de bulunan dosya klasör işlemlerini nasıl yönetebileceğimizi öğreneceğiz.
        //    Gerçek hayatta sıklıkla kullanmış olduğumuz System.IO namespace ini kullanarak 
        //    Klasörler oluşturacağız onları yöneteceğiz daha sonra dosyalar oluşturup bunları yönetmeye çalışacağız.

        //    Gerçek hayatta database e gittiğimiz kadar dosya ve klasörlere de ihtiyaç duyarız 

        //    */


        //}

        #endregion


        #region VİDEO 221 Directory.CreateDirectory(Yeni Klasör Oluşturma )

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 24 Dosya ve Klasor Islemleri V221 Directory.CreateDirectory( Yeni Klasör Oluşturma )

        //    */


        //    /*

        //    1. not baslangıç

        //    Directory sınıfından bahsedelim cagırdıgımız da system.ıo kutuphanesini ekler => using System.IO;

        //    Directory sınıfı bizim sabit disk üzerinde klasör işlemleri yapmamıza olanak sağlar.

        //    1. not bitiş

        //    2. not baslangıc

        //    bir metot olusturalım 

        //    static void YeniKlasorOlustur(string path)
        //    {
        //        Directory.CreateDirectory(path);
        //    }

        //    static yaptık direk cagırabileceğiz
        //    void geriye bişey donmeyecek
        //    string tipinde bir path parametresi alacak
        //    Directory.CreateDirectory ile path e gelen konuma olusturacak

        //    CreateDirectory i biraz inceleyelim

        //    Directory sınıfının içerisinde CreateDirectory ulabilmek için sadece . operatörü ile erişebildim.
        //    Demekki Directory sınıfının içerisinde CreateDirectory static bir metot.
        //    Orneklemeden ulasmamı sagladı.

        //    benden parametre alıyor ve DirectoryInfo adında bir deger döndürüyor

        //    DirectoryInfo olarak cagırıp bir degiskene atayalım ve ne geliyor bakalım

        //    son durum

        //    static void YeniKlasorOlustur(string path)
        //    {
        //        //Directory.CreateDirectory(path);
        //        DirectoryInfo D1 = Directory.CreateDirectory(path);
        //    }

        //    CreateDirectory bizden 2 farklı parametre istiyor 
        //    ilgili klasörün güvenlik ayarlarını girmen lazım
        //    o tarafta şimdilik işimiz yok oraya girmiyoruz

        //    2. not bitiş

        //    3. not baslangıc

        //    metotu cagırıp c nin içinde bir klasör olusturalım

        //    YeniKlasorOlustur("C:\\Udemy");

        //    breakpoint ile kontrol edelim

        //    olusturdu sorun yok 

        //    DirectoryInfo olarak D1 e atadıgı degerlere bakmak gerekirse

        //    ne zaman olusturuldu
        //    ust klasör var mı 
        //    adı 
        //    path adresi
        //    exist yani orada bulunuyor mu 
        //    vs vs gibi bir cok degere ulabiliyoruz

        //    sırada varlık kontrolunu yapalım diger derse gecelim


        //    */

        //    // 1. not baslangıc

        //    //Directory.CreateDirectory();

        //    YeniKlasorOlustur("C:\\Udemy");


        //}

        //// 2. not baslangıc
        //static void YeniKlasorOlustur(string path)
        //{
        //    //Directory.CreateDirectory(path);
        //    DirectoryInfo D1 = Directory.CreateDirectory(path);
        //}

        #endregion


        #region VİDEO 222 Directory.Exists ( Varlık Kontrolünün Sağlanması )

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 24 Dosya ve Klasor Islemleri V222 Directory.Exists ( Varlık Kontrolünün Sağlanması )

        //    */


        //    /*

        //    1. not baslangıç

        //    sırada varlık kontrolunu yapalım 

        //    yeni bir metot olusturalım


        //    static void YeniKlasorVarlikKontrol(string path)
        //    {
        //         bool varMı = Directory.Exists(path);
        //    }

        //    Exists metotunu cagıralım 
        //    Exists almıs oldugu degerin yani path in konumunda olup olmadıgına bakar
        //    geriye bool doner 

        //    C içinde Udemy klasörü var mı diye bakar

        //    su anda C nin içinde Udemy klasörü bulunuyor ne olacak bi bakalım

        //    YeniKlasorVarlikKontrol breakpoint ekleyelim ve kontrol edelim

        //    main deki metot calıstı ilgili metot a gitti path i aldı

        //    varMı true döndü çünkü var

        //    silip baktıgımız da false döndü

        //    diger derste delete işlemlerine bakacagız

        //    */


        //    //YeniKlasorOlustur("C:\\Udemy");
        //    YeniKlasorVarlikKontrol("C:\\Udemy");


        //}

        //static void YeniKlasorOlustur(string path)
        //{
        //    DirectoryInfo D1 = Directory.CreateDirectory(path);
        //}

        //static void YeniKlasorVarlikKontrol(string path)
        //{
        //    bool varMı = Directory.Exists(path);
        //}

        #endregion


        #region VİDEO 223 Directory.Delete ( Klasör Silme )

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 24 Dosya ve Klasor Islemleri V223 Directory.Delete ( Klasör Silme )

        //    */


        //    /*

        //    1. not baslangıç

        //    yeni bir metot olusturalım silme konusunu işleyelim


        //    static void YeniKlasorSilme(string path)
        //    {
        //        Directory.Delete(path);
        //    }

        //        Directory.Delete => void geriye bir şey dönmüyor

        //    C içerisindeki Udemy klasörünü direk siliyor sorun yok

        //    C içerisindeki Udemy klasörünün içine bir dosya ekleyip silmeye çalışınca hata veriyor 
        //    System.IO.Exception : "The directory is not empty."

        //    Klasör boş değil içi dolu silemiyorum klasörü diyor.

        //    Delete in 2. kullanımı override metotu 2 paremetreli calısıyor
        //    bool recursive degeri alıyor 
        //    içerisinde de dosya varsa sileyim mi diye onay istiyor

        //    */


        //    //YeniKlasorOlustur("C:\\Udemy");
        //    //YeniKlasorVarlikKontrol("C:\\Udemy");
        //    YeniKlasorSilme("C:\\Udemy");

        //}

        //static void YeniKlasorOlustur(string path)
        //{
        //    DirectoryInfo D1 = Directory.CreateDirectory(path);
        //}

        //static void YeniKlasorVarlikKontrol(string path)
        //{
        //    bool varMı = Directory.Exists(path);
        //}

        //static void YeniKlasorSilme(string path)
        //{
        //   Directory.Delete(path);
        //   Directory.Delete(path, true);

        //}

        #endregion


        #region VİDEO 224 Ödev

        //static void Main(string[] args)
        //{

        //    /*

        //    Bolum 24 Dosya ve Klasor Islemleri V224 Ödev

        //    */


        //    /*

        //    1. not baslangıç

        //    C nin içinde Udemy adında bir klasör olusturun oluşturmadan önce varlık kontrol yapın klasör var ise silin sonra olusturun klasör yok ise direk olusturun bu adımların bilgisini ekrana yazdırın

        //    benim yaptıgım

        //     string path = "C:\\Udemy";

        //    bool varMi = Directory.Exists(path);

        //    if (varMi)
        //    {
        //        Console.WriteLine("C de Udemy klasörü var.");
        //        Directory.Delete(path,true);
        //        Console.WriteLine("C deki Udemy klasörü silindi.");
        //        Directory.CreateDirectory(path);
        //        Console.WriteLine("C de Udemy klasörü oluşturuldu.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("C de Udemy klasörü yok.");
        //        Directory.CreateDirectory(path);
        //        Console.WriteLine("C de Udemy klasörü oluşturuldu.");
        //    }


        //     //------------------------------hocanın yaptıgı-----------------------------------------------

        //    string dosyaYolu = "C:\\Udemy";

        //    bool kontrol = Directory.Exists(dosyaYolu);

        //    if (kontrol)
        //    {
        //        Console.WriteLine("Eklemek istediğiniz klasör sistemde mecvut.");
        //        Console.Write("Silmek ve yerine yeni olarak oluşturmak istiyor musunuz [E/H]");
        //        string cevap = Console.ReadLine().ToUpper();
        //        if (cevap == "E")
        //        {
        //            Directory.Delete(dosyaYolu, true);
        //            Console.WriteLine("Dosya silme işlemi tamamlandı.");
        //            System.Threading.Thread.Sleep(2000);
        //            Console.WriteLine(dosyaYolu + " sisteminizde oluşturuluyor.");
        //            Directory.CreateDirectory(dosyaYolu);
        //        }
        //        else
        //        {
        //            Console.WriteLine("İşlem bitti.");
        //        }
        //    }
        //    else
        //    {
        //        DirectoryInfo d1 = Directory.CreateDirectory(dosyaYolu);
        //        if(d1.Exists)
        //        {
        //            Console.WriteLine("Dosya sistemde oluşturuldu.");
        //        }
        //    }



        //    */

        //    //string path = "C:\\Udemy";

        //    //bool varMi = Directory.Exists(path);

        //    //if (varMi)
        //    //{
        //    //    Console.WriteLine("C de Udemy klasörü var.");
        //    //    Directory.Delete(path,true);
        //    //    Console.WriteLine("C deki Udemy klasörü silindi.");
        //    //    Directory.CreateDirectory(path);
        //    //    Console.WriteLine("C de Udemy klasörü oluşturuldu.");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("C de Udemy klasörü yok.");
        //    //    Directory.CreateDirectory(path);
        //    //    Console.WriteLine("C de Udemy klasörü oluşturuldu.");
        //    //}

        //    //////------------------------------hocanın yaptıgı-----------------------------------------------

        //    ////string dosyaYolu = "C:\\Udemy";

        //    ////bool kontrol = Directory.Exists(dosyaYolu);

        //    ////if (kontrol)
        //    ////{
        //    ////    Console.WriteLine("Eklemek istediğiniz klasör sistemde mecvut.");
        //    ////    Console.Write("Silmek ve yerine yeni olarak oluşturmak istiyor musunuz [E/H]");
        //    ////    string cevap = Console.ReadLine().ToUpper();
        //    ////    if (cevap == "E")
        //    ////    {
        //    ////        Directory.Delete(dosyaYolu, true);
        //    ////        Console.WriteLine("Dosya silme işlemi tamamlandı.");
        //    ////        System.Threading.Thread.Sleep(2000);
        //    ////        Console.WriteLine(dosyaYolu + " sisteminizde oluşturuluyor.");
        //    ////        Directory.CreateDirectory(dosyaYolu);
        //    ////    }
        //    ////    else
        //    ////    {
        //    ////        Console.WriteLine("İşlem bitti.");
        //    ////    }
        //    ////}
        //    ////else
        //    ////{
        //    ////    DirectoryInfo d1 = Directory.CreateDirectory(dosyaYolu);
        //    ////    if(d1.Exists)
        //    ////    {
        //    ////        Console.WriteLine("Dosya sistemde oluşturuldu.");
        //    ////    }
        //    ////}

        //}

        #endregion



    }
}
