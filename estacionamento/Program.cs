using models.estacionamento;
using System;

class Program
{
    public static void Main()
    {
        string comando;

        Console.WriteLine("Sistema de estacionamento");
        Estacionamento estacionamento = new Estacionamento( Estacionamento.valorHoraInicial(), Estacionamento.valorInicialInicial());

        while(true)
        {
            
            Console.WriteLine("\nDigite 1 para cadastrar carro");
            Console.WriteLine("Digite 2 para remover carro");
            Console.WriteLine("Digite 3 para listar carros");
            Console.WriteLine("Digite 4 para sair");
            Console.Write("Comando:");

            comando = Console.ReadLine();
            Console.Clear();
            
            switch (comando)
            {
                case "1":
                    estacionamento.cadatrarCarro();
                    break;
                case "2":
                    estacionamento.removerCarro();
                    break;
                case "3":
                    estacionamento.listarCarros();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
