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
                dropRubro1.DataSource = ru;
                dropRubro1.DataTextField = "nameRubro";
                dropRubro1.DataValueField = "idRubro";
                dropRubro1.DataBind();
                dropRubro.DataSource = ru;
                dropRubro.DataTextField = "nameRubro";
                dropRubro.DataValueField = "idRubro";
                dropRubro.DataBind();
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
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            CargarComboRubro();
            try
            {
                Button btn = (Button)sender;
                GridViewRow gvr = (GridViewRow)btn.NamingContainer;
                input0.Text = gvr.Cells[0].Text;
                input1.Text = gvr.Cells[1].Text;
                input2.Text = gvr.Cells[3].Text;
                input3.Text = gvr.Cells[4].Text;
                input4.Text = gvr.Cells[5].Text;
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
            input3.Enabled = false;
            input4.Enabled = false;
            dropRubro1.Enabled = false;

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            input1.Enabled = true;
            input2.Enabled = true;
            input3.Enabled = true;
            input4.Enabled = true;
            dropRubro1.Enabled = true;
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
                    ar.nombreRubro = input1.Text;
                    ar.descripcion = input2.Text;
                    ar.cantidad = int.Parse(input3.Text);
                    ar.idRubro = int.Parse(dropRubro1.SelectedValue);
                    ar.precio = float.Parse(input4.Text);
                    ar.estado = 1;
                    ArticuloBLL.ActualizarArticulo(ar);
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
            Entidades.Articulo ar = new Entidades.Articulo();
            if (ValidateArticuloModal() == true)
            {
                try
                {
                    ar.idArticulo = int.Parse(input0.Text);
                    ar.nombreRubro = input1.Text;
                    ar.descripcion = input2.Text;
                    ar.cantidad = int.Parse(input3.Text);
                    ar.precio = float.Parse(input4.Text);
                    ArticuloBLL.DeleteArticle(ar);
                    ar.estado = 2;
                     ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "seeliminoarticulo()", true);

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
                    ar.nombreRubro = inputnew1.Text;
                    ar.descripcion = inputnew2.Text;
                    ar.cantidad = int.Parse(inputnew3.Text);
                    ar.idRubro = int.Parse(dropRubro.SelectedValue);
                    ar.precio = float.Parse(input4.Text);
                    ar.estado = 1;

                   ArticuloBLL.NewArticulo(ar);
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "guardonuevoarticulo()", true);

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
            if(input5.Text == "1")
            {
                return false;
            }
            return true;
        }


        public bool ValidateArticulo()
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
            if (inputestado.Text == "1")
            {
                return false;
            }
            return true;
        }

       
    }
}