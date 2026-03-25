namespace Alistirma6Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                KOD HATALI SONRADAN TEKRAR BAKILACAK!!!
                
                Kullanıcıdan bir List<int> alarak, elemanları kullanıcının belirttiği adım kadar sağa kaydırın.
                Örnek girdi:
                Liste: 1 2 3 4 5 
                Kaydırma: 2
                
                Örnek Çıktı:
                4 5 1 2 3
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
            int kaydirma;
            while (true)
            {
                Console.Write("\nKaydırma: ");

                if (Int32.TryParse(Console.ReadLine(), out kaydirma))
                {
                    break;
                }
                else
                {
                    Console.Write("Hatalı giriş yapıldı! Lütfen sayı giriniz.");
                }
            }

            for (int i = 0; i < liste.Count - kaydirma; i++)
            {
                int temp = liste[i+kaydirma];
                liste[i + kaydirma] = liste[i];
                liste[i] = temp;
            }
            foreach (int a in liste)
            {
                Console.Write(a + " ");
            }



        }
    }
}
