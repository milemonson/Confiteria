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
            gvMozos.Columns[0].Visible = false;
            gvMozos.Columns[5].Visible = false;
            gvMozos.Columns[7].Visible = false;

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                GridViewRow gvr = (GridViewRow)btn.NamingContainer;
                txtId.Text = gvr.Cells[0].Text;
                txtName.Text = gvr.Cells[1].Text;
                txtLastName.Text = gvr.Cells[2].Text;
                txtCellphone.Text = gvr.Cells[3].Text;
                txtMail.Text = gvr.Cells[4].Text;
                txtidUser.Text = gvr.Cells[5].Text;
                txtNameUser.Text = gvr.Cells[6].Text;
                txtComision.Text = gvr.Cells[8].Text;
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
            txtName.Enabled = false;
            txtLastName.Enabled = false;
            txtCellphone.Enabled = false;
            txtMail.Enabled = false;
            txtNameUser.Enabled = false;
            txtComision.Enabled = false;

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtLastName.Enabled = true;
            txtCellphone.Enabled = true;
            txtMail.Enabled = true;
            txtComision.Enabled = true;
            txtNameUser.Enabled = false;
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
                    mo.mozo = int.Parse(txtId.Text);
                    mo.name = txtName.Text;
                    mo.lastname = txtLastName.Text;
                    mo.cellphone = txtCellphone.Text;
                    mo.email = txtMail.Text;
                    mo.usuario = new Usuario();
                    mo.usuario.idUser = int.Parse(txtidUser.Text);
                    mo.usuario.nameUser = txtNameUser.Text;
                    mo.comision = float.Parse(txtComision.Text);
                    MozoBLL.ActualizarMozo(mo);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardocambios()", true);
                    cargargrilla();
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseguardaroncambios()", true);
                }

            }
            else {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alert", "myerror1();", true);
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidades.Mozo mo = new Entidades.Mozo();

            if (ValidatePersonModal() == true)
            {
                try
                {
                    mo.mozo = int.Parse(txtId.Text);
                    mo.name = txtName.Text;
                    mo.lastname = txtLastName.Text;
                    mo.cellphone = txtCellphone.Text;
                    mo.email = txtMail.Text;
                    mo.usuario = new Usuario();
                    mo.usuario.idUser = int.Parse(txtidUser.Text);
                    mo.usuario.nameUser = txtNameUser.Text;
                    mo.comision = float.Parse(txtComision.Text);
                    mo.estado = 2;
                    MozoBLL.DeleteWaiter(mo);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "seeliminomozo()", true);
                    cargargrilla();
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
                    mo.name = txtNamenew.Text;
                    mo.lastname = txtLastNamenew.Text;
                    mo.cellphone = txtCellphonenew.Text;
                    mo.email = txtMailnew.Text;
                    mo.usuario = new Usuario();
                    mo.usuario.idUser= MozoDAL.TraerNameUser(txtNameUsernew.Text.Trim());
                    mo.usuario.nameUser = txtNameUsernew.Text;
                    if (mo.usuario.idUser == 0) {
                        ScriptManager.RegisterStartupScript(this, GetType(), "alert", "myerror3()", true);
                        return;
                    }
                    mo.comision = float.Parse(txtComisionnew.Text);
                    mo.estado = 1;

                    MozoBLL.NewMozo(mo);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardonuevomozo()", true);
                     cargargrilla();
                    
                }
                catch (Exception)
                {

                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseguardomozo()", true);
                }

            }

        }

        public bool ValidatePersonModal()
        {
            if (txtName.Text == "")
            {
                return false;
            }
            if (txtLastName.Text == "")
            {
                return false;
            }
            if (txtCellphone.Text == "")
            {
                return false;
            }
            if (txtMail.Text == "")
            {
                return false;
            }
            if (txtidUser.Text == "")
            {
                return false;
            }
            if (txtNameUser.Text == "")
            {
                return false;
            }
            if (txtComision.Text == "")
            {
                return false;
            }
            return true;
        }


        public bool ValidatePerson()
        {
            if (txtNamenew.Text == "")
            {
                return false;
            }
            if (txtLastNamenew.Text == "")
            {
                return false;
            }
            if (txtCellphonenew.Text == "")
            {
                return false;
            }
            if (txtMailnew.Text == "")
            {
                return false;
            }
            if (txtidUsernew.Text == "")
            {
                return false;
            }
            if (txtNameUsernew.Text == "")
            {
                return false;
            }
            if (txtComisionnew.Text == "")
            {
                return false;
            }
            if (txtstatenew.Text == "1")
            {
                return false;
            }
            return true;
        }

       
    }
}