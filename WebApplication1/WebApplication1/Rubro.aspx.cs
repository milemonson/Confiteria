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
    public partial class Rubro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                cargargrilla();
            }

        }
        private void cargargrilla() {
            List<Entidades.Rubro> rub = RubroBLL.CargarRubro();
            gvRubro.DataSource = rub;
            gvRubro.DataBind();
            gvRubro.Columns[0].Visible = false;



        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                GridViewRow gvr = (GridViewRow)btn.NamingContainer;
                txtId.Text = gvr.Cells[0].Text;
                txtNameRubro.Text = gvr.Cells[1].Text;
                txtDescription.Text = gvr.Cells[2].Text;
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
            txtNameRubro.Enabled = false;
            txtDescription.Enabled = false;
          
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            txtNameRubro.Enabled = true;
            txtDescription.Enabled = true;
            btnCambios.Enabled = true;
            btnEliminar.Enabled = true;
        }
        protected void btnCambios_Click(object sender, EventArgs e)
        { 
            if (ValidateRubroModal() == true)
            {
                Entidades.Rubro ru = new Entidades.Rubro();

                try
                {
                    ru.idRubro = int.Parse(txtId.Text);
                    ru.nameRubro = txtNameRubro.Text;
                    ru.descripcion = txtDescription.Text;
                    ru.estado = 1;
                   
                   
                    RubroBLL.ActualizarRubro(ru);
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
            Entidades.Rubro ru = new Entidades.Rubro();
            if (ValidateRubroModal() == true)
            {
                try
                {
                    ru.idRubro = int.Parse(txtId.Text);
                    ru.nameRubro = txtNameRubro.Text;
                    ru.descripcion = txtDescription.Text;
                    ru.estado = 2;
                    RubroBLL.DeleteCategory(ru);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "seeliminoRubro()", true);
                    cargargrilla();
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "nosepudoeliminarRubro()", true);
                }

            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Rubro ru = new Entidades.Rubro();
            if (ValidateRubro() == true)
            {
                try
                {
                    ru.nameRubro = txtNameRubronew.Text;
                    ru.descripcion = txtDescriptionnew.Text;
                    ru.estado = 1;

                    RubroBLL.NewRubro(ru);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardonuevoRubro()", true);
                    cargargrilla();
                }
                catch (Exception)
                {

                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseguardoRubro()", true);
                }

            }
        }
        public bool ValidateRubroModal()
        {
            if (txtId.Text == "")
            {
                return false;
            }
            if (txtNameRubro.Text == "")
            {
                return false;
            }
            if (txtDescription.Text == "")
            {
                return false;
            }
            if (txtState.Text == "1")
            {
                return false;
            }
            return true;
        }


        public bool ValidateRubro()
        {
            if (txtNameRubronew.Text == "")
            {
                return false;
            }
            if (txtDescriptionnew.Text == "")
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