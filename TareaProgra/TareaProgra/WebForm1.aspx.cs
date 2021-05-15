using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TareaProgra.clases;

namespace TareaProgra
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void CargarDATOS()
        {
            string stef = @"C:\Users\alumno\Desktop\archivos\1_4949951634001101227.csv";
            ClsArchivo gs = new ClsArchivo();
            ClsConexion ma = new ClsConexion();

            string[] arreglonotas = gs.LeerArchivo(stef);
            string conexion_sql = "";
            int numerolin = 0;
            foreach(string linea in arreglonotas)
                {
                string[] datos = linea.Split(';');
                if (numerolin > 0)
                {
                    conexion_sql = $"insert into estudiantes values({datos[0]},'{datos[1]}'{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}'";
                    ma.EjecutaSQLDirecto(conexion_sql);
                }
                numerolin++;

                }
            numerolin = 0;

            }
        public DataTable conexion_sql(string abc="1=1")
        {
            ClsConexion ma = new ClsConexion();
            DataTable tef = new DataTable();
            string gmk = $"select*from estudiantes where {abc}";
            tef = ma.consultaTablaDirecta(gmk);
            return tef;
        }







        protected void CargarArchivo_Click(object sender, EventArgs e)
        {
            CargarDATOS();

        }
    }
     
        

        }
    
