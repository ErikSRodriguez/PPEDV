internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var t1 = new Task(() =>
        {
            Console.WriteLine("T1 gestartet");
            Thread.Sleep(1000);
            Console.WriteLine("T1 fertig");
            throw new ExecutionEngineException();
        });

        t1.ContinueWith(t => Console.WriteLine("OK"), TaskContinuationOptions.NotOnFaulted);
        t1.ContinueWith(t => Console.WriteLine("ALWAYS"));
        t1.ContinueWith(t => Console.WriteLine($"ERROR: {t.Exception.InnerException.Message}"), TaskContinuationOptions.OnlyOnFaulted);

        var t2 = new Task<IEnumerable<int>>(() =>
        {
            Console.WriteLine("T2 gestartet");
            Thread.Sleep(3000);
            Console.WriteLine("T2 fertig");

            return new[] { 12, 2, 66, 787, 33 };
        });

        t2.ContinueWith(t =>
        {
            foreach (var item in t.Result)
            {
                Console.WriteLine(item);
            }
        });

        t1.Start();
        t2.Start();

        //Task.WaitAll(t1, t2);

        //t2.Wait();

        //foreach (var item in t2.Result)
        //{
        //    Console.WriteLine(item);
        //}

        Console.WriteLine("Ende");
        Console.ReadKey();
    }


}