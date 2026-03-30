namespace Alistirma3Cevap
{
    internal class Program
    {
        static int fibonacci_hesapla(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return fibonacci_hesapla(n - 1) + fibonacci_hesapla(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci_hesapla(5));
        }
    }
}
