using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Ticket
    {
        int IdTicket;
        int IdLocal;
        int IdMozo;
        int IdArticulo;
        DateTime Fecha;


        public Ticket() {
        
        }

        public Ticket(int idticket, int idLocal, int idMozo,int idArticulo, DateTime fecha)
        {
            IdTicket = idticket;
            IdLocal = idLocal;
            IdMozo = idMozo ;
            IdArticulo = idArticulo;
            Fecha = fecha;


        }

        public int idticket
        {
            get => IdTicket;
            set => IdTicket = value;
        }

        public int idLocal
        {
            get => IdLocal;
            set => IdLocal = value;
        }


        public int idMozo
        {
            get => IdMozo;
            set => IdMozo = value;
        }

        public int idArticulo
        {
            get => IdArticulo;
            set => IdArticulo = value;
        }

        public DateTime fecha
        {
            get => Fecha;
            set => Fecha = value;
        }

    }
}
