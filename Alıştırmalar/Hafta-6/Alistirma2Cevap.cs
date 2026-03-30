namespace Alistirma2Cevap
{
    internal class Program
    {
        static int faktoriyel_hesapla(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * faktoriyel_hesapla(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(faktoriyel_hesapla(5));
        }
    }
}
