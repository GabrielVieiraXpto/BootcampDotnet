using System;
using Celular.models;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Nokia");
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 100);
        nokia.InstalarApp("Whatsapp");
        nokia.Ligar();




        Console.WriteLine("\nIphone");
        Iphone iphone = new Iphone("987654321", "Iphone 6", "987654321", 100);
        iphone.ReceberLigacao();
        iphone.InstalarApp("Facebook");
        //nokia.InstalarApp("Whatsapp");
        //iphone.InstalarApp("Whatsapp");
    }
}
