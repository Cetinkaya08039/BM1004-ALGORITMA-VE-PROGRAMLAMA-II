namespace Alistirma4Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Kullanıcının girdiği List<int>'in ortalamasını hesaplayın ve ortalamadan büyük olanları listeleyin.


                İlk sorudaki liste alma yapısı korunup ortalamadan büyük olan sayılar için ayrı bir liste oluşturuldu ve ekrana yazdırıldı.
            */

            List<int> liste = new List<int>();
            int toplam = 0;
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
                    toplam += sayi;
                    liste.Add(sayi);
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yapıldı! Lütfen sayı giriniz.");
                }
                
            }
            Console.Write("Liste: ");
            foreach (int a in liste)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine($"Ortalama: {toplam/liste.Count}");
            List<int> ortbuyuk = new List<int>();
            Console.Write("Ortalamadan büyük olan sayılar: ");
            foreach (int a in liste)
            {
                if (a > toplam/liste.Count)
                {
                    ortbuyuk.Add(a);
                }
            }
            foreach (int a in ortbuyuk)
            {
                Console.Write(a + " ");
            }



        }
    }
}
