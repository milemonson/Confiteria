using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosDAL;

namespace ConexionBLL
{
    public class ArticuloBLL
    {
        public static void NewArticulo(Articulo ar)
        {
            ArticuloDAL.GuardarArticulo(ar);

        }
        public static void ActualizarArticulo(Articulo ar)
        {
            ArticuloDAL.ActualizarArticulo(ar);

        }
        public static void DescontarArticulo(int cantidad, int idTicket)
        {
            ArticuloDAL.DescArticulo(cantidad, idTicket);

        }
        public static void DeleteArticle(Articulo ar)
        {
            ArticuloDAL.EliminarArticulo(ar);

        }
        public static List<Articulo> CargarArticulo()
        {
            List<Articulo> cargar = ArticuloDAL.ObtenerArticulo();

            return cargar;
        }


    }
}
