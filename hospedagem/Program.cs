using System;
using hospedagem.models;


public class Program
{
    public static void Main()
    {
            List<Pessoa> hospedes=new List<Pessoa>();

            Pessoa p1=new Pessoa("Joao","Silva");
            Pessoa p2=new Pessoa("Maria","Silva");

            hospedes.Add(p1);
            hospedes.Add(p2);
            
            Suite s1=new Suite("Luxo",8,100);
            
            Reserva r1=new Reserva(5);

            r1.cadastarSuite(s1);
            r1.AdicionarHospede(hospedes);

            Console.WriteLine($"Hospedes: {r1.qtdHospedes()}");
            Console.WriteLine($"Valor Total: {r1.valorTotal()}");
                        
    }

}