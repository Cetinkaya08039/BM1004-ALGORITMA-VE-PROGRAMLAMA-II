namespace Alistirma22Cevap
{
    internal class Program
    {
        static void yazdir(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            yazdir(n - 1);
            Console.WriteLine(n);
        }
        static void Main(string[] args)
        {
            yazdir(3);
        }
    }
}
