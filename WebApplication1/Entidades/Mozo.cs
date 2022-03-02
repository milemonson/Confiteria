using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Mozo
    {
        int idMozo;
        string Nombre;
        string Apellido;
        string Telefono;
        string Email;
        int IdUser;
        string NameUser;
        int Estado;
        float Comision;

        public Usuario usuario { get; set; }


        public Mozo() { 
        
        }

        public Mozo (int mozo, string name, string lastname, string cellphone, string email,int idUser,string nameUser, int estado,float comision) {

            idMozo = mozo;
            Nombre = name;
            Apellido = lastname;
            Telefono = cellphone;
            Email = email;
            IdUser = idUser;
            NameUser = nameUser;
            Estado = estado;
            Comision = comision;
         }


        public int mozo
        {
            get => idMozo;
            set => idMozo = value;
        }


        public string name
        {
            get => Nombre;
            set => Nombre = value;

        }
        public string lastname
        {
            get => Apellido;
            set => Apellido = value;
        }
        public string cellphone 
        {
            get => Telefono;
            set => Telefono = value;
        }
        public string email
        {
            get => Email;
            set => Email = value;
        }

        public int idUser
        {
            get => IdUser;
            set => IdUser = value;
        }
        public string nameUser
        {
            get => NameUser;
            set => NameUser = value;
        }
        public int estado
        {
            get => Estado;
            set => Estado = value;
        }
        public float comision
        {
            get => Comision;
            set => Comision = value;
        }

    }
}
