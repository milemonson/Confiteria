using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DatosDAL;

namespace ConexionBLL
{
   public class UsuarioBLL
    {
        public static void NewUser(Usuario usu)
        {
            UsuarioDAL.GuardarUserNuevo(usu);

        }
        public static void ActualizarUser(Usuario usu)
        {
            UsuarioDAL.ActualizarUser(usu);

        }
        public static void DeleteUser(Usuario u)
        {
            
            UsuarioDAL.EliminarUser(u);

        }
        public static List<Usuario> CargarUser()
        {
            List<Usuario> cargar = UsuarioDAL.ObtenerUser();
            return cargar;
        }
       
        public static bool ValidarUsuario(string nameUser, string password)
        {
           bool cargar = UsuarioDAL.VerificarUsuario(nameUser,password);
            return cargar;
        }

    }
}
