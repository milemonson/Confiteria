using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local
    {

        int IdLocal;
        string Entidad;
        string Cuit;
        string IIBB;
        string Iva;
       

        public Local()
        {

        }

        public Local(int idLocal, string entidad, string cuit, string iibb,string iva)
        {
            IdLocal = idLocal;
            Entidad = entidad;
            Cuit = cuit;
            IIBB = iibb;
            Iva = iva;
        }


        public int idLocal
        {
            get => IdLocal;
            set => IdLocal = value;
        }


        public string entidad
        {
            get => Entidad;
            set => Entidad = value;

        }
        public string cuit
        {
            get => Cuit;
            set => Cuit = value;
        }
        public string iibb
        {
            get => IIBB;
            set => IIBB = value;
        }
        public string iva
        {
            get => Iva;
            set => Iva = value;
        }

        


    }
}
