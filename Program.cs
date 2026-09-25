using System;


Console.WriteLine("Digite um texto:");

string texto = Console.ReadLine() ?? string.Empty;
Console.Write("Em baleiês: ");

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
