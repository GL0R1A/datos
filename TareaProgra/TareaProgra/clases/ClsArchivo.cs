using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TareaProgra.clases
{
    public class ClsArchivo
    {
        public string Archivo { get; private set; }

        public string[] LeerArchivo(string Archivo)
        {
            String[] lineas = File.ReadAllLines(Archivo);
            return lineas;
        }

        public string LeerTodoArchivo(string Archivo)
        {
            string ContenidoArchivo;
            using (StreamReader reader = new StreamReader(Archivo))
            {
                ContenidoArchivo = reader.ReadToEnd();
            }
            return ContenidoArchivo;
        }


        //puede tambien contener arreglo
        //sobre escribe el archivo si ya tiene informacion
        public void grabarArchivoNuevo(String archivo, String contenido)
        {
            File.WriteAllText(Archivo, contenido);
        }

        public void agreagarDatosArchivo(String Archivo, String Contenido)
        {
            using (StreamWriter sw = File.AppendText(Archivo))
            {
                sw.WriteLine(Contenido);
            }
        }
    }
}
