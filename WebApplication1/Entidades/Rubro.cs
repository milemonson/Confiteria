using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rubro
    {

        int IdRubro;
        string NombreRubro;
        string Descripcion;
        int Estado;

        public Rubro() { 
        
        }

        public Rubro (int idRubro, string nameRubro, string descripcion,int estado){
            IdRubro = idRubro;
            NombreRubro = nameRubro;
            Descripcion = descripcion;
            Estado = estado;
        }

        public int idRubro
        {
            get => IdRubro;
            set => IdRubro = value;
        }


        public string nameRubro
        {
            get => NombreRubro;
            set => NombreRubro = value;
        }

        public string descripcion
        {
            get => Descripcion;
            set => Descripcion = value;
        }

        public int estado
        {
            get => Estado;
            set => Estado = value;
        }


    }
}
