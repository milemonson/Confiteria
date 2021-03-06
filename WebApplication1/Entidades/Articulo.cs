using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo
    {
        int IdArticulo;
        string NombreRubro;
        int IdRubro;
        string NameArticulo;
        int Cantidad;
        float Precio;
        int Estado;
        public Rubro rubro { get; set; }


        public Articulo(){
        }



        public Articulo( int idArticulo, string nombreRubro,int idRubro, string nameArticulo, int cantidad, float precio,int estado)
        {
            IdArticulo = idArticulo;
            NombreRubro = nombreRubro;
            IdRubro = idRubro;
            NameArticulo = nameArticulo;
            Cantidad = cantidad;
            Precio = precio;
            Estado = estado;
        }

        public int idArticulo
        {
            get => IdArticulo;
            set => IdArticulo = value;
        }
        public string nombreRubro
        {
            get => NombreRubro;
            set => NombreRubro = value;
        }

        public int idRubro
        {
            get => IdRubro;
            set => IdRubro = value;
        }
        public string nameArticulo
        {
            get => NameArticulo;
            set => NameArticulo = value;
        }


        public int cantidad
        {
            get => Cantidad;
            set => Cantidad = value;
        }
        public float precio
        {
            get => Precio;
            set => Precio  = value;
        }

        public int estado
        {
            get => Estado;
            set => Estado = value;
        }
    
    }
}
