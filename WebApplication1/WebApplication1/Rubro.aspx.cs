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
        
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                GridViewRow gvr = (GridViewRow)btn.NamingContainer;
                input0.Text = gvr.Cells[0].Text;
                input1.Text = gvr.Cells[1].Text;
                input2.Text = gvr.Cells[2].Text;
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
            input1.Enabled = false;
            input2.Enabled = false;
          
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            input1.Enabled = true;
            input2.Enabled = true;
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
                    ru.idRubro = int.Parse(input0.Text);
                    ru.nameRubro = input1.Text;
                    ru.descripcion = input2.Text;
                    ru.estado = 1;
                   
                   
                    RubroBLL.ActualizarRubro(ru);
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
            Entidades.Rubro ru = new Entidades.Rubro();
            if (ValidateRubroModal() == true)
            {
                try
                {
                    ru.idRubro = int.Parse(input0.Text);
                    ru.nameRubro = input1.Text;
                    ru.descripcion = input2.Text;
                    ru.estado = 2;
                    RubroBLL.DeleteCategory(ru);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "seeliminoRubro()", true);

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
                    ru.nameRubro = inputnew1.Text;
                    ru.descripcion = inputnew2.Text;
                    ru.estado = 1;

                    RubroBLL.NewRubro(ru);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardonuevoRubro()", true);

                }
                catch (Exception)
                {

                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseguardoRubro()", true);
                }

            }
        }
        public bool ValidateRubroModal()
        {
            if (input0.Text == "")
            {
                return false;
            }
            if (input1.Text == "")
            {
                return false;
            }
            if (input2.Text == "")
            {
                return false;
            }
            if (input3.Text == "1")
            {
                return false;
            }
            return true;
        }


        public bool ValidateRubro()
        {
            if (inputnew1.Text == "")
            {
                return false;
            }
            if (inputnew2.Text == "")
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