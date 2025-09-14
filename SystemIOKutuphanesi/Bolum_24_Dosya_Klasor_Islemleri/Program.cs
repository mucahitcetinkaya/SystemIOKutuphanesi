

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




    }
}
