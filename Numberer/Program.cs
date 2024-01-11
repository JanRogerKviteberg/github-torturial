namespace Numberer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("numberer");
        foreach (string s in args)
        {
            Console.WriteLine(s);
            ;
        }
    }
}