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
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargargrilla();
            }

        }
        private void cargargrilla()
        {
            List<Usuario> users = UsuarioBLL.CargarUser();
            gvUsuarios.DataSource = users;
            gvUsuarios.DataBind();
            gvUsuarios.Columns[0].Visible = false;
        }



        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                    Button btn = (Button)sender;
                    GridViewRow gvr = (GridViewRow)btn.NamingContainer;
                    txtId.Text = gvr.Cells[0].Text;
                    txtUser.Text = gvr.Cells[1].Text;
                    txtPass.Text = gvr.Cells[2].Text;
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
            txtUser.Enabled = false;
            txtPass.Enabled = false;

            }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            btnCambios.Enabled = true;
            btnEliminar.Enabled = true;
        }
        protected void btnCambios_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();

            if (ValidateUserModal() == true)
            {     
                try
                {
                    usu.idUser = int.Parse(txtId.Text);
                    usu.nameUser = txtUser.Text;
                    usu.password = txtPass.Text;
                    usu.state =1;
                    UsuarioBLL.ActualizarUser(usu);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardocambios()", true);
                    cargargrilla();
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseguardaroncambios()", true);
                }
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();

            if (ValidateUserModal() == true)
            {    
                try
                {
                    usu.idUser = int.Parse(txtId.Text);
                    usu.nameUser = txtUser.Text;
                    usu.password = txtPass.Text;
                    usu.state = 2;
                    UsuarioBLL.DeleteUser(usu);
                    cargargrilla();
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "seeliminouser()", true);

                }
                catch (Exception )
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "nosepudoeliminar()", true);
                }

            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            Usuario usu = new Usuario();

            if (ValidateUser() == true)
            {
                try
                {
                    usu.nameUser = txtNameUsernew.Text;
                    usu.password = txtPassnew.Text;
                    usu.state=1;
                    UsuarioBLL.NewUser(usu);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardonuevoUser()", true);
                    cargargrilla();
                }
                catch (Exception)
                {

                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseagregousuario()", true);
                }

            }
        }
        
        
       
        public bool ValidateUserModal()
        {
            if (txtUser.Text == "")
            {
                return false;
            }
            if (txtPass.Text == "")
            {
                return false;
            }
            if (txtState.Text == "1")
            {
                return false;
            }
            return true;
        }


        public bool ValidateUser()
        {
            if (txtNameUsernew.Text == "")
            {
                return false;
            }
            if (txtPassnew.Text == "")
            {
                return false;
            }
            if (txtStatenew.Text == "1")
            {
                return false;
            }
            return true;
        }
    }


}
