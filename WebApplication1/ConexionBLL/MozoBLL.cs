using DatosDAL;
using Entidades;
using System.Collections.Generic;

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



    }
}
