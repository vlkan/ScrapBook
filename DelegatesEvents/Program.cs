public delegate void IslemDelegesi(int sayi);

public class Islemler
{
    public void KareAl(int sayi)
    {
        Console.WriteLine($"Sayının karesi: {sayi * sayi}");
    }

    public void KupAl(int sayi)
    {
        Console.WriteLine($"Sayının küpü: {sayi * sayi * sayi}");
    }
}

public delegate void OlayIsleyici(string mesaj);

public class OlayYayinlayici
{
    // Olayı tutan delege değişkeni
    public OlayIsleyici Olay;

    // Olayı tetikleyen metot
    public void OlayiTetikle(string mesaj)
    {
        // Delegeye bağlı metotları çağır
        if (Olay != null)
        {
            Olay(mesaj);
        }
    }
}

public class OlayDinleyici1
{
    // Olayı işleyecek metot
    public void OlayiIsle(string mesaj)
    {
        Console.WriteLine($"Dinleyici 1: {mesaj}");
    }
}

public class OlayDinleyici2
{
    // Olayı işleyecek metot
    public void OlayiIsle(string mesaj)
    {
        Console.WriteLine($"Dinleyici 2: {mesaj.ToUpper()}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Islemler islemler = new Islemler();
        IslemDelegesi kareDelegesi = new IslemDelegesi(islemler.KareAl);
        IslemDelegesi kupDelegesi = new IslemDelegesi(islemler.KupAl);

        kareDelegesi(5); // Çıktı: Sayının karesi: 25
        kupDelegesi(3); // Çıktı: Sayının küpü: 27

        IslemDelegesi cokluDelege = kareDelegesi + kupDelegesi;
        cokluDelege(2); // Çıktı: Sayının karesi: 4, Sayının küpü: 8.

        cokluDelege.DynamicInvoke(4); // Çıktı: Sayının karesi: 16, Sayının küpü: 64.
        cokluDelege.Invoke(1); // Çıktı: Sayının karesi: 1, Sayının küpü: 1.

        Console.WriteLine("-----------------------------------------------------------------------");

        OlayYayinlayici yayinlayici = new OlayYayinlayici();
        OlayDinleyici1 dinleyici1 = new OlayDinleyici1();
        OlayDinleyici2 dinleyici2 = new OlayDinleyici2();

        // Olay işleyicilerini delegeye ekle
        yayinlayici.Olay += dinleyici1.OlayiIsle;
        yayinlayici.Olay += dinleyici2.OlayiIsle;

        // Olayı tetikle
        yayinlayici.OlayiTetikle("Merhaba, Olay!");

    }
}