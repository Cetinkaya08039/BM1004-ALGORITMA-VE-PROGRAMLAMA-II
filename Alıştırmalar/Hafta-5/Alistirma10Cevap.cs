namespace Alistirma10Cevap
{
    internal class Program
    {
        /*
            Kullanıcıdan iki farklı List<int> alarak, bu listelerde ortak olan elemanları bulan bir program yazın.
        */
        static void Main(string[] args)
        {
            List<int> liste = new List<int> {1, 2, 3, 4, 5, 6};
            List<int> liste2 = new List<int> {4, 5, 6, 7, 8, 9};
            List<int> ortak = new List<int>();
            Console.WriteLine($"Liste1: [{string.Join(", ", liste)}]");
            Console.WriteLine($"Liste2: [{string.Join(", ", liste2)}]");

            for (int i = 0; i < liste.Count; i++)
            {
                if (liste2.Contains(liste[i]) && !ortak.Contains(liste[i]))
                {
                    ortak.Add(liste[i]);
                }
            }
            Console.WriteLine($"Ortak Elemanlar: [{string.Join(", ", ortak)}]");
        }
    }
}
