namespace Alistirma11Cevap
{
    internal class Program
    {
        /*
            Bir List<int> alarak, listenin baştan ve sondan aynı olup olmadığını kontrol eden bir algoritma yazın (Reverse() kullanmayınız).

        */
        static bool simetrik_mi(List<int> liste)
        {
            for (int i = 0; i < liste.Count / 2; i++)
            {
                if (liste[i] != liste[liste.Count - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            List<int> liste = new List<int> { 1, 2, 3, 4, 3, 2, 1 };
            if (simetrik_mi(liste))
            {
                Console.WriteLine("Simetrik!");
            }
            else
            {
                Console.WriteLine("Asimetrik!");
            }
        }
    }
}
