using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class DetalleTicket
    {
        int IdDetalle;
        int IdTicket;
        int Articulo;
        int Cantidad;
        float Precio;
        
        public DetalleTicket()
        {
        }

        public DetalleTicket(int idDetalle,int idTicket, string nombre, int articulo, int cantidad, float precio)
        {
            IdDetalle = idDetalle;
            IdTicket = idTicket;
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
        
        }

        public int idDetalle
        {
            get => IdDetalle;
            set => IdDetalle = value;
        }


        public int idTicket
        {
            get => IdTicket;
            set => IdTicket = value;
        }
        public int articulo
        {
            get => Articulo;
            set => Articulo = value;
        }

        public int cantidad
        {
            get => Cantidad;
            set => Cantidad = value;
        }
         
        public float precio {
            get => Precio;
            set => Precio = value;
        }
    
    
    }
}
