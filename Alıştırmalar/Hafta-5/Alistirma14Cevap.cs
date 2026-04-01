namespace Alistirma13Cevap
{
    internal class Program
    {
        /*
            Bir öğretmen, öğrencilerin notlarını girecek. 50'nin altındaki notları otomatik olarak listeden çıkaran ve yeni ortalamayı hesaplayan bir program yaz.

        */

        static void Main(string[] args)
        {
            List<double> notlar = new List<double>();
            while (true)
            {
                Console.Write("Öğrencinin notunu giriniz(Çıkış için -1): ");
                try
                {
                    double not = double.Parse(Console.ReadLine());
                    if (not == -1) break;
                    if (not > 100 || not < 0)
                    {
                        throw new Exception("uygunsuznot");
                    }
                    notlar.Add(not);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalnızca sayısal değer girmeniz gerekmekte!");
                    continue;
                }
                catch (Exception ex) when (ex.Message == "uygunsuznot")
                {
                    Console.WriteLine("0-100 arasında bir değer girmeniz gerekmekte!");
                    continue;
                }
                catch
                {
                    Console.WriteLine("Bir hata oluştu!");
                    continue;
                }               
                
            }
            if (notlar.Any())
            {
                Console.Write($"Girilen notlar: [{string.Join(", ", notlar)}]");
                // bu yorum satırındaki şekildede toplam hesaplanabilir ancak daha hızlı yazmak için notlar.Sum() da kullanabiliriz.
                //double toplam = 0;
                //foreach (double a in notlar)
                //{
                //    toplam += a;
                //}
                var toplam = notlar.Sum();
                Console.WriteLine($"\nİlk ortalama: {toplam / notlar.Count}");
                // Buradaki kısım benim ilk yazdığım kod yorum satırında olmayan kısım ise yapay zekadan yardım alarak öğrendiğim kavram.
                // Döngüyü son elemandan başlatılmasının nedeni listeden bir elemanı çıkarttığımızda listenin sona kayması.
                //for (int i = notlar.Count - 1; i >= 0; i--)
                //{
                //    if (notlar[i] < 50)
                //    {
                //        notlar.RemoveAt(i);
                //    }
                //}
                notlar.RemoveAll(n => n < 50);
                if (notlar.Any())
                {
                    toplam = notlar.Sum();
                    Console.Write($"Temizlenmiş notlar: [{string.Join(", ", notlar)}]");
                    Console.WriteLine($"\nSon ortalama: {toplam / notlar.Count}");
                }
                else
                {
                    Console.WriteLine("Temizleme işleme yapıldıktan sonra listede not kalmadı!");
                }
            }
            else
            {
                Console.WriteLine("Hiç not girilmedi!");
            }
            
        }
    }
}
