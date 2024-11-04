using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialEstacionamiento.Entidades.Entidades
{
    public class Auto
    {
        private ConsoleColor _color { get; set; }     
        private decimal valorHora;

        private Auto()
        {

        }
        public Auto(string patente,string marca, string modelo,ConsoleColor color)
        {
            
        }

        public Auto(ConsoleColor color, decimal valorHora) :  base()
        {
            this._color=color ;
            this.valorHora = valorHora;
        }



    }
}
