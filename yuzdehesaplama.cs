using System;
class HelloWorld {
  static void Main(string[] args)
        {
            string sayi, yuzde;
            Console.Write("Bir sayı girin: ");
            sayi = Console.ReadLine();
            
            Console.Write("Yüzde kaçı hesaplansın: ");
            yuzde = Console.ReadLine();
            
            Console.WriteLine("Sonuç: " + (Convert.ToDouble(sayi) * (Convert.ToDouble(yuzde) / 100) ) );
            Console.ReadKey();
        }
}
