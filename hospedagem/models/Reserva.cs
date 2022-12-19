using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospedagem.models
{
    public class Reserva
    {
        List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite Suite { get; set; }

        public int DiasReservados { get; set; }

        public Reserva(int DiasReservados)
        {
            this.DiasReservados = DiasReservados;
        }


        public void AdicionarHospede(List<Pessoa> Hospede)
        {
            if (this.Hospedes.Count > Suite.Capacidade)
            {
                throw new Exception("Capacidade excedida");
            }
            this.Hospedes=Hospede;
        }

        public void cadastarSuite(Suite Suite)
        {
            this.Suite=Suite;
        }
        public int qtdHospedes()
        {
            return this.Hospedes.Count;
        }
        public decimal valorTotal()
        {
            Decimal valorTotal=Suite.ValorDiaria*DiasReservados;

            if(DiasReservados>=10)
            {
              return valorTotal-((valorTotal*10)/100);;   
            }
            return valorTotal;
        }
        

    }
}