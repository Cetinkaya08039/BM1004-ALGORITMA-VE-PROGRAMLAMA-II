namespace Alistirma2Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Kullanıcıdan bir List<int> alarak sadece çift sayıları ekrana yazdırın.

                Önceki sorudaki yapı korunup çiftleri ekrana yazdırıcak şekilde düzenlendi
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
            foreach (int a in liste)
            {
                if (a%2 == 0)
                {
                    Console.Write(a + " ");
                }
            }
        }
    }
}
