using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosDAL;

namespace ConexionBLL
{
    public class RubroBLL
    {
        public static void NewRubro(Rubro ru)
        {
            RubroDAL.GuardarRubroNuevo(ru);

        }
        public static void ActualizarRubro(Rubro ru)
        {
            RubroDAL.ActualizarRubro(ru);

        }
        public static void DeleteCategory(Rubro ru)
        {
            RubroDAL.EliminarRubro(ru);

        }
        public static List<Rubro> CargarRubro()
        {
            List<Rubro> cargar = RubroDAL.ObtenerRubro();
            return cargar;
        }


    }
}
