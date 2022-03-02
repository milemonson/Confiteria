using DatosDAL;
using Entidades;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System;

namespace ConexionBLL
{
    public class MozoBLL
    { 
        public static void NewMozo(Mozo mo)
        {
            MozoDAL.GuardarMozoNuevo(mo);

        }
        public static void ActualizarMozo(Mozo mo)
        {
            MozoDAL.ActualizarDatosMozo(mo);

        }
        public static void DeleteWaiter(Mozo mo)
        {
            MozoDAL.EliminarDatosMozo(mo);

        }

        public static List<Mozo> CargarMozos()
        {
            List<Mozo> cargar = MozoDAL.ObtenerMozo();

            return cargar;
        }

        public static SqlDataReader ventasPorMozo(DateTime fecha)
        {
            return MozoDAL.VentasPorMozo(fecha);
        }



    }
}
