using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SegundoParcialEstacionamiento.Datos
{
   public class Serealizadorxml<T> where T : class, new()
    {
        public static void Guardar(string archivo, T objeto)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;
                var stringJson = JsonSerializer.Serialize(objeto, opciones);
                escritor.WriteLine(stringJson);
            }
        }

        public static T Leer(string archivo)
        {
            using (var lector = new StreamReader(archivo))
            {
                string linea = lector.ReadToEnd();
                return JsonSerializer.Deserialize<T>(linea);
            }
        }
        public static void GuardarXml(string archivo, T objeto)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                xmlSerializer.Serialize(escritor, objeto);
            }
        }
    }
}
