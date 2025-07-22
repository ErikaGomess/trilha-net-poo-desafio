using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando smartphone Nokia:");
        Smartphone nokia = new Nokia("11999999999", "Nokia 3310", "123456789012345", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine();

        Console.WriteLine("Testando smartphone iPhone:");
        Smartphone iphone = new Iphone("11888888888", "iPhone 13", "987654321098765", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
