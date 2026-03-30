namespace Alistirma5Cevap
{
    internal class Program
    {
        static int basamak_topla(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n%10 + basamak_topla(n/10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(basamak_topla(123321));
        }
    }
}
