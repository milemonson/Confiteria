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
            gvLocal.Columns[0].Visible = false;

        }
        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            txtId.Text = gvr.Cells[0].Text;
            txtNameEntiti.Text = gvr.Cells[1].Text;
            txtCuit.Text = gvr.Cells[2].Text;
            txtIIBB.Text = gvr.Cells[3].Text;
            txtIVA.Text = gvr.Cells[4].Text;
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
                    lo.idLocal = int.Parse(txtId.Text);
                    lo.entidad = txtNameEntiti.Text;
                    lo.cuit = txtCuit.Text;
                    lo.iibb = txtIIBB.Text;
                    lo.iva = txtIVA.Text;

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
            txtNameEntiti.Enabled = false;
            txtCuit.Enabled = false;
            txtIIBB.Enabled = false;
            txtIVA.Enabled = false;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            txtNameEntiti.Enabled = true;
            txtCuit.Enabled = true;
            txtIIBB.Enabled = true;
            txtIVA.Enabled = true;
            btnCambios.Enabled = true;
          
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidateModal() == true)
            {
                Entidades.Local lo = new Entidades.Local();

                try
                {
                    lo.idLocal = int.Parse(txtId.Text);
                    lo.entidad = txtNameEntiti.Text;
                    lo.cuit = txtCuit.Text;
                    lo.iibb = txtIIBB.Text;
                    lo.iva = txtIVA.Text;

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
            if (txtId.Text == "")
            {
                return false;
            }
            if (txtNameEntiti.Text == "")
            {
                return false;
            }
            if (txtCuit.Text == "")
            {
                return false;
            }
            if (txtIIBB.Text == "")
            {
                return false;
            }
            if (txtIVA.Text == "")
            {
                return false;
            }
            return true;
        }


        public bool ValidateModal()
        {
            if (txtNameEntitinew.Text == "")
            {
                return false;
            }
            if (txtCuitnew.Text == "")
            {
                return false;
            }
            if (txtIIBBnew.Text == "")
            {
                return false;
            }

            if (txtIVAnew.Text == "")
            {
                return false;
            }

          
            return true;
        }
    }
}