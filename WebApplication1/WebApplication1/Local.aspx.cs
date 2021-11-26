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
    public partial class Local : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargargrilla();
            }
        }

        private void cargargrilla() {
            List<Entidades.Local> local = LocalBLL.CargarLocal();
            gvLocal.DataSource = local;
            gvLocal.DataBind();

        }
        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            input0.Text = gvr.Cells[0].Text;
            input1.Text = gvr.Cells[1].Text;
            input2.Text = gvr.Cells[2].Text;
            input3.Text = gvr.Cells[3].Text;
            input4.Text = gvr.Cells[4].Text;
            Deshabilitar();
            btnModificar.Enabled = true;
            btnCambios.Enabled = true;
          
        }

        protected void btnCambios_Click(object sender, EventArgs e)
        {
            if (ValidateLocalModal() == true)
            {
                Entidades.Local lo = new Entidades.Local();

                try
                {
                    lo.idLocal = int.Parse(input0.Text);
                    lo.entidad = input1.Text;
                    lo.cuit = input2.Text;
                    lo.iibb = input3.Text;
                    lo.iva = input4.Text;

                    LocalBLL.ActualizarLocal(lo);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardocambios()", true);

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseguardaroncambios()", true);
                }
            }
        
    }
        private void Deshabilitar()
        {
            input1.Enabled = false;
            input2.Enabled = false;
            input3.Enabled = false;
            input4.Enabled = false;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            input1.Enabled = true;
            input2.Enabled = true;
            input3.Enabled = true;
            input4.Enabled = true;
            btnCambios.Enabled = true;
          
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidateModal() == true)
            {
                Entidades.Local lo = new Entidades.Local();

                try
                {
                    lo.idLocal = int.Parse(input0.Text);
                    lo.entidad = input1.Text;
                    lo.cuit = input2.Text;
                    lo.iibb = input3.Text;
                    lo.iva = input4.Text;

                    LocalBLL.ActualizarLocal(lo);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardoLocalNuevo()", true);

                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseguardoLocal()", true);
                }
            }
        }
        public bool ValidateLocalModal()
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
            if (input3.Text == "")
            {
                return false;
            }
            if (input4.Text == "")
            {
                return false;
            }
            return true;
        }


        public bool ValidateModal()
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

          
            return true;
        }
    }
}