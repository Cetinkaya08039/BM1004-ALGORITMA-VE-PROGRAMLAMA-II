namespace Alistirma3Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Kullanıcının girdiği bir List<int>'i tersine çevirerek ekrana yazdırın (Reverse() kullanmayınız).

                İlk sorudaki liste alma yapısı korunup tersine çevirme eklendi. Klasik iki elemanı yer değiştirme algoritması kullanıldı. 
                Gereksiz tekrar edip eski haline geri döndürmemesi için liste.Count yapmak yerine liste.Count/2 kullanıldı.
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
            Console.Write("Liste İlk Hali: ");
            foreach (int a in liste)
            {
                Console.Write(a + " ");
            }
            
            for (int i = 0; i < liste.Count/2; i++)
            {
                int temp = liste[i];
                liste[i] = liste[liste.Count-1-i];
                liste[liste.Count-1-i] = temp;
            }
            Console.Write("\nListe Sonraki Hali:");
            foreach(int a in liste)
            {
                Console.Write(a + " ");
            }
            
        }
    }
}
