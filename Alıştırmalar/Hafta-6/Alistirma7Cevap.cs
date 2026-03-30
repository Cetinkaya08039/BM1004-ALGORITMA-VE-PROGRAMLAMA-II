namespace Alistirma7Cevap
{
    internal class Program
    {
        static int ters_cevir(int n)
        {
            if (n/10 == 0)
            {
                return n;
            }

            return Int32.Parse((n%10).ToString() + ters_cevir(n/10).ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ters_cevir(42435));
        }
    }
}
