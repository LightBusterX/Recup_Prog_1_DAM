namespace Recup_Prog;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    static char Menu()
    {
        char opcion;

        opcion = char.Parse(Console.ReadLine());
        return (opcion);
    }
}