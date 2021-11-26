using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosDAL;


namespace ConexionBLL
{
   public class LocalBLL
    {

        public static List<Local> CargarLocal()
        {
            List<Local> cargar = LocalDAL.ObtenerLocal();
            return cargar;
        }

        public static void NewLocal(Local lo)
        {
            LocalDAL.GuardarLocalNuevo(lo);

        }
        public static void ActualizarLocal(Local lo)
        {
            LocalDAL.ActualizarDatosLocal(lo);

        }
    }
}
