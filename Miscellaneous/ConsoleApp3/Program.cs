using ClassLibrary;
    class Prog
{
    static void Main(string[] args)
    {
        Calculator c=new Calculator();
        int r1 = c.Add(5, 7);
        Console.WriteLine(r1);
    }
}

