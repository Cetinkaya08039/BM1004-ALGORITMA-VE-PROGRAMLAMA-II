namespace Alistirma8Cevap
{
    internal class Program
    {
        /*
            Bir List<char> içinde ardışık olarak tekrar eden elemanları yalnızca bir kez yazarak yeni bir liste oluşturun.,
            
            Örnek Girdi:
            Liste: [a, a, b, b, b, c, c, a, a, d, d]
            
            Örnek Çıktı:
            Yeni Liste: [a, b, c, a, d]
        */
        static void Main(string[] args)
        {
            List<char> liste = new List<char> { 'a', 'a', 'b', 'b', 'b', 'c', 'c', 'a', 'a', 'd', 'd'};
            Console.WriteLine($"Liste: [{string.Join(", ", liste.Select(c => $"'{c}'"))}]"); // daha temiz bir görüntü elde edilebilmesi için liste.select kısmında yapay zekadan destek alındı.
            
            List<char> liste2 = new List<char>();
            for (int i = 0;i < liste.Count; i++)
            {
                if (i == 0 || liste[i] != liste[i-1])
                {
                    liste2.Add(liste[i]);
                }
            }
            
            Console.WriteLine($"Yeni Liste: [{string.Join(", ", liste2.Select(c => $"'{c}'"))}]");
        }
    }
}
