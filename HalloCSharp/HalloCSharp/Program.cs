

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Person fred = new Person() { Name = "Fred" };
        var fred2 = new Person() { Name = "Fred" };
        Person fred3 = new () { Name = "Fred" };

        ClassicCasting(fred);

        using var sr = new StreamReader(@"C:\dev\aaaaaLLLLL\.gitignore");
        //{
        ClassicCasting(sr);
        //} //-> sr.Dispose(); --> sr.Close();


        ClassicBoxing(fred);

        ModernPatternMatching(fred);

        foreach (var item in GetData())
        {
            Console.WriteLine(item);
        }
    }//-> sr.Dispose(); --> sr.Close();


    public static IEnumerable<int> GetData()
    {
        //var data = new[] { 12, 4, 22, 34, 8, 644, 5 };

        //foreach (var item in data)
        //{
        //    yield return item;
        //}
        yield return 12;
        yield return 5;
        yield return 3;
    }



    private static void ModernPatternMatching(object dings)
    {
        if (dings is Person dingsAsPerson)
            Console.WriteLine($"ModernPatternMatching: {dingsAsPerson.Name}");

    }

    public static void ClassicBoxing(object dings)
    {
        Person dingsAsPerson = dings as Person; //boxing
        if (dingsAsPerson != null)
            Console.WriteLine($"Classic Boxing: {dingsAsPerson.Name}");

    }
    public static void ClassicCasting(object dings)
    {
        if (dings is Person)
        {
            Person dingsAsPerson = (Person)dings;
            Console.WriteLine($"Classic Casting: {dingsAsPerson.Name}");
        }
    }



}


class Person
{
    public string Name { get; set; }

    private int myVar;

    public int MyProperty
    {
        get => myVar;
        set => myVar = value;
    }

}