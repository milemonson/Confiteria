using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatosDAL;
using ConexionBLL;

namespace PasteleriaProyect
{
    public partial class Articulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                cargargrilla();
            }
        }

        private void CargarComboRubro()
        {
            try
            {
                List<Entidades.Rubro> ru = RubroDAL.ObtenerCombo();
                dropRubroEdit.DataSource = ru;
                dropRubroEdit.DataTextField = "nameRubro";
                dropRubroEdit.DataValueField = "idRubro";
                dropRubroEdit.DataBind();
                dropRubronew.DataSource = ru;
                dropRubronew.DataTextField = "nameRubro";
                dropRubronew.DataValueField = "idRubro";
                dropRubronew.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cargargrilla()
        {
            List<Entidades.Articulo> art = ArticuloBLL.CargarArticulo();
            gvArticulo.DataSource = art;
            gvArticulo.DataBind();
            gvArticulo.Columns[2].Visible = false;
            gvArticulo.Columns[0].Visible = false;
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            CargarComboRubro();
            try
            {
                Button btn = (Button)sender;
                GridViewRow gvr = (GridViewRow)btn.NamingContainer;
                input0.Text = gvr.Cells[0].Text;
                txtNameRubro.Text = gvr.Cells[1].Text;
                dropRubroEdit.SelectedValue = gvr.Cells[2].Text;
                txtNameArticulo.Text = gvr.Cells[3].Text;
                txtQuantity.Text = gvr.Cells[4].Text;
                txtPrice.Text = gvr.Cells[5].Text;

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
            txtNameArticulo.Enabled = false;
            txtQuantity.Enabled = false;
            txtPrice.Enabled = false;
            dropRubroEdit.Enabled = false;

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            txtNameRubro.Enabled = false;
            txtNameArticulo.Enabled = true;
            txtQuantity.Enabled = true;
            txtPrice.Enabled = true;
            dropRubroEdit.Enabled = true;
            btnCambios.Enabled = true;
            btnEliminar.Enabled = true;
        }
        protected void btnCambios_Click(object sender, EventArgs e)
        {


            if (ValidateArticuloModal() == true)
            {
                Entidades.Articulo ar = new Entidades.Articulo();

                try
                {
                    ar.idArticulo = int.Parse(input0.Text);
                    ar.nombreRubro = txtNameRubro.Text;
                    ar.nameArticulo = txtNameArticulo.Text;
                    ar.cantidad = int.Parse(txtQuantity.Text);
                    ar.idRubro = int.Parse(dropRubroEdit.SelectedValue);
                    ar.precio = float.Parse(txtPrice.Text);
                    ar.estado = 1;
                    ArticuloBLL.ActualizarArticulo(ar);
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
            Entidades.Articulo ar = new Entidades.Articulo();
            if (ValidateArticuloModal() == true)
            {
                try
                {
                    ar.idArticulo = int.Parse(input0.Text);
                    ar.nombreRubro = txtNameRubro.Text;
                    ar.idRubro = int.Parse(dropRubroEdit.SelectedValue);
                    ar.nameArticulo = txtNameArticulo.Text;
                    ar.cantidad = int.Parse(txtQuantity.Text);
                    ar.precio = float.Parse(txtPrice.Text);
                    ar.estado = 2;
                    ArticuloBLL.DeleteArticle(ar);
                    
                     ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "seeliminoarticulo()", true);
                    cargargrilla();
                }
                catch (Exception)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "nosepudoeliminararticulo()", true);
                }

            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Articulo ar = new Entidades.Articulo();
            if (ValidateArticulo() == true)
            {
                try
                {
                    ar.nombreRubro = txtNameRubro.Text;
                    ar.nameArticulo = txtNameArticulonew.Text;
                    ar.cantidad = int.Parse(txtQuantitynew.Text);
                    ar.idRubro = int.Parse(dropRubronew.SelectedValue);
                    ar.precio = float.Parse(txtPricenew.Text);
                    ar.estado = 1;
                  
                    ArticuloBLL.NewArticulo(ar);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardonuevoarticulo()", true);
                    cargargrilla();
                }
                catch (Exception)
                {
                  
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "noseguardoarticulo()", true);
                }

            }
        }

      

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            CargarComboRubro();
         
        }
        public bool ValidateArticuloModal()
        {
            if (input0.Text == "")
            {
                return false;
            }
            if (txtNameRubro.Text == "")
            {
                return false;
            }
            if (txtNameArticulo.Text == "")
            {
                return false;
            }
            if (txtQuantity.Text == "")
            {
                return false;
            }
            if (txtPrice.Text == "")
            {
                return false;
            }
            if(txtstate.Text == "1")
            {
                return false;
            }
            return true;
        }


        public bool ValidateArticulo()
        {
            if (txtNameArticulonew.Text == "")
            {
                return false;
            }
            if (txtQuantitynew.Text == "")
            {
                return false;
            }
            if (txtPricenew.Text == "")
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