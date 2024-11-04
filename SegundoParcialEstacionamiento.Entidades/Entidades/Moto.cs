using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialEstacionamiento.Entidades.Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada { get; set; }
        private decimal valorHora;


        private Moto()
        {

        }

        public Moto(decimal valorHora, int cilindrada) : base(valorHora, cilindrada)
        {

        }


    }
}
