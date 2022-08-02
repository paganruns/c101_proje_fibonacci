namespace fibonacci;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Fibonacci derlemesi için derinlik sayısını giriniz");
        int sayi = Int32.Parse(Console.ReadLine());
        Fibonacci(sayi);
    }


    public static void Fibonacci(int len)
    {
        int a = 0, b = 1, c = 0;
        Console.Write("{0} {1}", a, b);
        for (int i = 2; i < len; i++)
        {
            c = a + b;
            Console.Write(" {0}", c);
            a = b;
            b = c;
        }
    }
}
