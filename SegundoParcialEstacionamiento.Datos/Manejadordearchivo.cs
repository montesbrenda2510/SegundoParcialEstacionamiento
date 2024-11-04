using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SegundoParcialEstacionamiento.Entidades
{
    public class Manejadordearchivo
    {
        public static void Guardar(List<Vehiculo> lista, string archivo)
        {
            using (var escritor = new StreamWriter(archivo, true))
            {
                foreach (var vehiculo in lista)
                {
                    var linea = ConstruirLinea(vehiculo);
                    escritor.WriteLine(linea);

                }
            }
        }

        private static string ConstruirLinea(Vehiculo vehiculo)
        {
            if (vehiculo.GetType() == typeof())
            {
                return
                    $"{vehiculo.Patente}|{vehiculo.Patente}|{((Vehiculo)vehiculo).GetNumero()}|{((Jugador)persona).GetEsCapitan()}|{Tipo.Jugador}";
            }
            return $"{persona.Nombre}|{persona.Apellido}|{Tipo.Tecnico}";
        }

        public static List<Vehiculo> LeerDatos(string archivo)
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            if (!File.Exists(archivo))
            {
                return lista;
            }

            using (var lector = new StreamReader(archivo))
            {
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Vehiculo a = ConstruirVehiculo(linea);
                    lista.Add(a);
                }
            }

            return lista;
        }

        private static Vehiculo ConstruirVehiculo(string linea)
        {
            Vehiculo p;
            var campos = linea.Split('|');

            if (campos.Length == 5)
            {
                var patente = campos[0];
                var ingreso = int.Parse(campos[1]);

                p = new Moto(patente, ingreso);

            }
            if else
                {
                    var = campos[0];
                    var apellido = campos[1];
                    var tipo = campos[2];
                    p = new DirectorTecnico(nombre, apellido);
                }

            return p;
        }
    }
}
