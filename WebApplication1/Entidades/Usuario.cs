using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        int IdUser;
        string NameUser;
        string Password;
        int State;

        public Usuario() { 

        }
        public Usuario(int idUser, string nameUser, string password,int state)
        {
            IdUser = idUser;
            NameUser = nameUser;
            Password = password;
            State = state;
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

        public string password
        {
            get => Password;
            set => Password = value;
        }

        public int state
        {
            get => State;
            set => State = value;
        }

    }
}
