namespace Soru1Cevap
{
    internal class Program
    {
        static int toplam(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + toplam(n-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(toplam(10));
        }
    }
}
