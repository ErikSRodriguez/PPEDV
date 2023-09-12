using System;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Parallel.For(0, 100_000,
                     i => Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - {i}"));

        //Parallel.Invoke(() => ZähleMax(12),
        //                //() => Console.Beep(),
        //                Zähle, Zähle, Zähle, Zähle, Zähle, Zähle, Zähle);

        Console.WriteLine("Ende");
    }

    private static void ZähleMax(int max)
    {
        for (int i = 0; i < max; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - {i}");
        }
    }

    private static void Zähle()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - {i}");
        }
    }
}