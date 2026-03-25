namespace Alistirma5Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Kullanıcının girdiği List<int> içinde en küçük ve en büyük sayıyı bulun.
            */

            List<int> liste = new List<int>();
            while (true)
            {
                Console.Write("Listeye eklenecek bir sayı giriniz (0 = Çıkış): ");
                if (Int32.TryParse(Console.ReadLine(), out int sayi))
                {
                    if (sayi == 0)
                    {
                        Console.WriteLine("İşlem sonlandırıldı! Oluşturulan liste ekrana yazdırılıyor...");
                        break;
                    }
                    liste.Add(sayi);
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yapıldı! Lütfen sayı giriniz.");
                }
                
            }
            Console.Write("Liste: ");
            int enbuyuk = liste[0];
            int enkucuk = liste[0];
            foreach (int a in liste)
            {
                if (a > enbuyuk)
                {
                    enbuyuk = a;
                }
                if (a < enkucuk)
                {
                    enkucuk = a;
                }
                Console.Write(a + " ");
            }
            Console.WriteLine($"\nListedeki en büyük eleman: {enbuyuk}");
            Console.WriteLine($"Listedeki en küçük eleman: {enkucuk}");
        }
    }
}
