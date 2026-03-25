namespace Alistirma7Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Kullanıcıdan alınan List<int> içinde tekrar eden sayıları kaldırarak yeni bir liste oluşturun.
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
                Console.Write(a + " ");
            }

            Console.Write("\nYeni liste: ");
            List<int> yeni_liste = new List<int>();
            for (int i = 0; i < liste.Count; i++)
            {
                if (!yeni_liste.Contains(liste[i]))
                {
                    yeni_liste.Add(liste[i]);
                }
            }
            foreach (int a in yeni_liste)
            {
                Console.Write(a + " ");
            }


        }
    }
}
