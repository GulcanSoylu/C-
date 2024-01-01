using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");
            Console.WriteLine("5. Çıkış");

            Console.Write("Seçiminizi yapın (1-5): ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Toplama();
                    break;
                case "2":
                    Cikarma();
                    break;
                case "3":
                    Carpma();
                    break;
                case "4":
                    Bolme();
                    break;
                case "5":
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                    break;
            }

            Console.WriteLine(); // Biraz boşluk ekleyelim
        }
    }

    static void Toplama()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        double toplam = sayi1 + sayi2;
        Console.WriteLine($"Sonuç: {toplam}");
    }

    static void Cikarma()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        double fark = sayi1 - sayi2;
        Console.WriteLine($"Sonuç: {fark}");
    }

    static void Carpma()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        double carpim = sayi1 * sayi2;
        Console.WriteLine($"Sonuç: {carpim}");
    }

    static void Bolme()
    {
        Console.Write("Bölünen sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bölen sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        if (sayi2 != 0)
        {
            double bolum = sayi1 / sayi2;
            Console.WriteLine($"Sonuç: {bolum}");
        }
        else
        {
            Console.WriteLine("Hata: Bölen sıfır olamaz!");
        }
    }
}
