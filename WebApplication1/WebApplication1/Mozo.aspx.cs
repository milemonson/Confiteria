using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using DatosDAL;
using ConexionBLL;

namespace PasteleriaProyect
{
    public partial class Mozo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) {
                cargargrilla();
          }

        }
        
        private void cargargrilla()
        {
            List<Entidades.Mozo> mozo = MozoBLL.CargarMozos();
            gvMozos.DataSource = mozo;
            gvMozos.DataBind();

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                GridViewRow gvr = (GridViewRow)btn.NamingContainer;
                inputid.Text = gvr.Cells[0].Text;
                inputname.Text = gvr.Cells[1].Text;
                inputlast.Text = gvr.Cells[2].Text;
                inputcellphone.Text = gvr.Cells[3].Text;
                inputmail.Text = gvr.Cells[4].Text;
                inputiduser.Text = gvr.Cells[5].Text;
                inputcomision.Text = gvr.Cells[7].Text;
                Deshabilitar();
                btnModificar.Enabled = true;
                btnCambios.Enabled = true;
                btnEliminar.Enabled = true;

            }
            catch (Exception)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alert", "myerror1();", true);

            }

        }
        private void Deshabilitar()
        {
            inputname.Enabled = false;
            inputlast.Enabled = false;
            inputcellphone.Enabled = false;
            inputmail.Enabled = false;
            inputiduser.Enabled = false;
            inputcomision.Enabled = false;

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            inputname.Enabled = true;
            inputlast.Enabled = true;
            inputcellphone.Enabled = true;
            inputmail.Enabled = true;
            inputcomision.Enabled = true;
            inputiduser.Enabled = false;
            btnCambios.Enabled = true;
            btnEliminar.Enabled = true;
        }
        protected void btnCambios_Click(object sender, EventArgs e)
        {
          

            if (ValidatePersonModal() == true)
            {
               Entidades.Mozo mo = new Entidades.Mozo();

                try
                {
                    mo.mozo = int.Parse(inputid.Text);
                    mo.name = inputname.Text;
                    mo.lastname = inputlast.Text;
                    mo.cellphone = inputcellphone.Text;
                    mo.email = inputmail.Text;
                    mo.idusuario = int.Parse(inputiduser.Text);
                    mo.comision = float.Parse(inputcomision.Text);
                    MozoBLL.ActualizarMozo(mo);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardocambios()", true);

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseguardaroncambios()", true);
                }
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidades.Mozo mo = new Entidades.Mozo();

            if (ValidatePersonModal() == true)
            {
                try
                {
                    mo.mozo = int.Parse(inputid.Text);
                    mo.name = inputname.Text;
                    mo.lastname = inputlast.Text;
                    mo.cellphone = inputcellphone.Text;
                    mo.email = inputmail.Text;
                    mo.idusuario = int.Parse(inputiduser.Text);
                    mo.comision = float.Parse(inputcomision.Text);
                    mo.estado = 2;
                    MozoBLL.DeleteWaiter(mo);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "seeliminomozo()", true);

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "nosepudoeliminarmozo()", true);
                }

            }
        }
        protected void btnPlus_Click(object sender, EventArgs e)
        {
            Entidades.Mozo mo = new Entidades.Mozo();

            if (ValidatePerson() == true)
            {
                try
                {
                    mo.name = inputnew1.Text;
                    mo.lastname = inputnew2.Text;
                    mo.cellphone = inputnew3.Text;
                    mo.email = inputnew4.Text;
                    mo.idusuario = int.Parse(inputnew5.Text);
                    mo.comision = float.Parse(inputnew6.Text);
                    mo.estado = 1;
                    MozoBLL.NewMozo(mo);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardonuevomozo()", true);

                }
                catch (Exception)
                {

                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseguardomozo()", true);
                }

            }

        }

        public bool ValidatePersonModal()
        {
            if (inputname.Text == "")
            {
                return false;
            }
            if (inputlast.Text == "")
            {
                return false;
            }
            if (inputcellphone.Text == "")
            {
                return false;
            }
            if (inputmail.Text == "")
            {
                return false;
            }
            if (inputiduser.Text == "")
            {
                return false;
            }
            if (inputcomision.Text == "")
            {
                return false;
            }
            return true;
        }


        public bool ValidatePerson()
        {
            if (inputnew1.Text == "")
            {
                return false;
            }
            if (inputnew2.Text == "")
            {
                return false;
            }
            if (inputnew3.Text == "")
            {
                return false;
            }
            if (inputnew4.Text == "")
            {
                return false;
            }
            if (inputnew5.Text == "")
            {
                return false;
            }
            if (inputnew6.Text == "")
            {
                return false;
            }
            if (inputestado.Text == "1")
            {
                return false;
            }
            return true;
        }

       
    }
}