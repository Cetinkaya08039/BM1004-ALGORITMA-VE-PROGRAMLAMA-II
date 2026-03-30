namespace Alistirma4Cevap
{
    internal class Program
    {
        static int us_al(int a, int b)
        {
           
            if (b == 1)
            {
                return a;
            }
            return a * us_al(a, b-1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(us_al(3, 3));
        }
    }
}
