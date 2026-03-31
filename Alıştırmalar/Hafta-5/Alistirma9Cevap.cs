namespace Alistirma9Cevap
{
    internal class Program
    {
        /*
            Kullanıcının girdiği List<int> içindeki sayıların ortalamasını hesaplayın ve bu ortalama değere en yakın sayıyı bulun.
        */
        static void Main(string[] args)
        {
            List<int> liste = new List<int> {10, 15, 20, 30, 40, 50};
            Console.WriteLine($"Liste: [{string.Join(", ", liste)}]");
            double toplam = 0;
            foreach (int i in liste)
            {
                toplam += i;
            }
            int enyakin = liste[0];
            double ort = toplam / liste.Count;
            foreach (int i in liste)
            {
                if (Math.Abs(ort - i) < Math.Abs(ort - enyakin))
                {
                    enyakin = i;
                }
            }
            Console.WriteLine($"Ortalama: {ort}\nOrtalamaya en yakın sayı: {enyakin}");
        }
    }
}
