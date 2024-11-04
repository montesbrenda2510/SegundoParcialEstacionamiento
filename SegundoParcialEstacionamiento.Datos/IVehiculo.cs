using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialEstacionamiento.Entidades
{
    public interface IVehiculo<T> where T : class
    {
        List<T> lista { get; set; }     
        decimal ObtenerCostoPorHora();
        List<T> GetLista();

    }
}
