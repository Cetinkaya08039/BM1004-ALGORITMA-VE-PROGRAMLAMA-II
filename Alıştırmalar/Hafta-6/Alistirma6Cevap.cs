namespace Alistirma6Cevap
{
    internal class Program
    {
        static void basamak_yazdir(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(n%10);
            basamak_yazdir(n/10);
        }
        static void Main(string[] args)
        {
            basamak_yazdir(123321);

        }
    }
}
