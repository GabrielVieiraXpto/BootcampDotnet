using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarApp(string nome)
        {
            Console.WriteLine("Instalando app "+nome+" no Iphone");
        }


    }
}