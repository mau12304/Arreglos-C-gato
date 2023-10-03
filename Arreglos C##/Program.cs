using System;
class Program
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50, 60 };
        Console.WriteLine(+numeros[3]);

        int[] n = new int[] { 3, 4, 5 };
        Console.WriteLine(+n[1]);

        char[] c = { 'L', 'u', 'i', 's' };
        Console.WriteLine(c);

        string s = "Mona lisa";
        Console.WriteLine(s);
        Console.ReadKey();
    }
}