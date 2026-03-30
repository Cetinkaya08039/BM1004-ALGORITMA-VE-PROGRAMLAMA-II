namespace Alistirma12Cevap
{
    internal class Program
    {
        static int uzunluk_hesapla(string n, int sayac = 1)
        {
            if (n == "")
            {
                return 0;
            }
            string str = n.Substring(1);
            return 1 + uzunluk_hesapla(n.Substring(1), sayac++);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(uzunluk_hesapla("ABCa123"));
        }
    }
}
