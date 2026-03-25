namespace Alistirma1Cevap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Kullanıcıdan sürekli olarak sayı girmesini isteyen bir program yazın.Kullanıcı "0" girince, girilen tüm sayıları sırasıyla ekrana yazdırın.

                While döngüsü kullanılarak kullanıcının sürekli input girebilmesi sağlandı. Eğer kullanıcı hatalı bir değer girerse(örn. 'a', 'ğ' '>' gibi) TryParse ile hata yakalandı
                TryParse tarafından döndürülen boolean değerine göre işlem gerçekleştirildi.
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
        }
    }
}
