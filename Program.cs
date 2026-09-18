using System;

class Program
{
    static void Main()
    {
        string texto = Console.ReadLine();

        foreach (char letra in texto)
        {
            if (letra == 'a')
            {
                Console.Write("aaa");
            }
            else if (letra == 'e')
            {
                Console.Write("eee");
            }
            else if (letra == 'i')
            {
                Console.Write("iii");
            }
            else if (letra == 'o')
            {
                Console.Write("ooo");
            }
            else if (letra == 'u')
            {
                Console.Write("uuu");
            }
            else
            {
                Console.Write(letra);
            }
        }
    }
}
