using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        int IdUser;
        string User;
        string Pass;
    

    public Login(int idUser, string user, string pass)
    {

        IdUser = idUser;
        User = user;
        Pass = pass;

    }
    public int idUser
    {
        get => IdUser;
        set => IdUser = value;
    }


    public string user
    {
        get => User;
        set => User = value;
    }

    public string pass
    {
        get => Pass;
        set => Pass = value;
    }
    }

}
