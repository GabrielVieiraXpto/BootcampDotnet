using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace models.estacionamento
{
    public class Estacionamento
    {
        List<string> Carros=new List<string>();
        Double valorHora, valorInicial;

        public Estacionamento(double valorHora, double valorInicial)
        {
            this.valorHora = valorHora;
            this.valorInicial = valorInicial;
        }
    

        public void cadatrarCarro()
        {
            Console.Write("Digite o carro que deseja cadastrar: ");
            string carro = Console.ReadLine();
            if (carroExiste(carro)==false)
            {
                Carros.Add(carro);
                Console.WriteLine("Carro cadastrado com sucesso");
            }
            else
            {
                Console.WriteLine("O carro já foi cadastrado");
            }
        }

        public void removerCarro()
        {  
            Console.Write("Digite o carro que deseja remover: ");
            string carro = Console.ReadLine();

            if(carroExiste(carro))
            {
                Carros.Remove(carro);                
                Console.WriteLine($"O carro {carro} foi removido com o valor de: R$: " + valorFinal());
            }
            else
            {
                Console.WriteLine("O carro não foi encontrado");
            }
        }
        public void listarCarros()
        {
            if (Carros.Count == 0)
            {
                Console.WriteLine("Não há carros cadastrados");
            }
            else
            {
                Console.WriteLine("Carros cadastrados:");
                foreach (var item in Carros)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static public double valorHoraInicial()
        {
            Console.Write("Digite o valor da hora: ");
            return trataValor();
        }
            
        static public double valorInicialInicial()
        {
            Console.Write("Digite o valor inicial: ");
           
            return trataValor();
        }
        public double valorFinal()
        {
            Console.Write("Digite tempo de permanencia em numero de horas: ");
            return trataValor() * this.valorHora+this.valorInicial;
        }
        public bool carroExiste(string carro)
        {
            return Carros.Contains(carro);
        }

        static double trataValor()
        {

            double valor=0;
            while (true)
            {   
                    
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    return valor;
                }
                else
                {
                    Console.Write("Valor inválido, digite novamente: ");
                }
            
            }
            return valor;
            
        }

    }
}