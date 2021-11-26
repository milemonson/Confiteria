using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using DatosDAL;

namespace PasteleriaProyect
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NameUser"] != null)
            {
                string userName = Session["NameUser"].ToString();
                txtBienvenido.Text = "Bienvenido  " + userName;
            }
        }   
        
    }
}