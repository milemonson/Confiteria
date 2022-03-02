using System;
using System.Collections;
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
    public partial class Ticket : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["Detalle"] = true;
                txtDate.Text = Convert.ToString(DateTime.Today);
                gvTicket.Enabled = true;
                nextNumberTicket();
                calcularTotal();
                CargarComboMozo();
                CargarComboArticulo();
                CargarComboLocal();
                btnGenerarPdf.Enabled = false;
            }
        }

     
        protected void btnArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Ticket ti = new Entidades.Ticket();
                ti.fecha = DateTime.Parse(txtDate.Text);
                ti.idMozo = int.Parse(dropMozo.SelectedValue);
                ti.idLocal = int.Parse(dropLocal.SelectedValue);
                
                DetalleTicket dt = new DetalleTicket();
                dt.articulo = int.Parse(dropArticulo.SelectedValue);


                txtPrice.Text = ArticuloDAL.ObtenerPrecio(int.Parse(dropArticulo.SelectedValue));

               
                List<DetalleTicket> tic = new List<DetalleTicket>();

                if (Session["Data"] != null)
                {
                    tic = Session["Data"] as List<DetalleTicket>; 
                }
                tic.Add(new DetalleTicket
                {
                    idTicket = int.Parse(lblIdTicket.Text),
                    articulo = int.Parse(dropArticulo.SelectedValue),
                    cantidad = int.Parse(txtQuantity.Text),
                   
                    precio = float.Parse(txtPrice.Text),
                }) ;
                Session["cantidad"] = int.Parse(txtQuantity.Text);
                Session["Data"] = tic;
                gvTicket.DataSource = tic;
                gvTicket.DataBind();
                calcularTotal();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }


        protected void GenerarFac_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Ticket ti = new Entidades.Ticket();
                ti.fecha = DateTime.Parse(txtDate.Text);
                ti.idMozo = int.Parse(dropMozo.SelectedValue);
                ti.idLocal = int.Parse(dropLocal.SelectedValue);

                List<DetalleTicket> dt = (List<DetalleTicket>)Session["Data"];
                
                bool resultado = TicketDAL.insertarDetalleTicket(ti,dt);

                int idTicket = TicketDAL.TraerNumeroTicket();
                
                ArticuloBLL.DescontarArticulo(int.Parse(Session["cantidad"].ToString()), idTicket);


                if (resultado)
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alert", "succes();", true);
                    btnGenerarPdf.Enabled = true;
                    gvTicket.Enabled = true;
                }
                else {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alert", "myerror2();", true);
                }
               
            }
            catch (Exception ex){
                throw ex;
            
            }
        }


        private void CargarComboLocal()
        {
            LoadCombo(dropLocal);
        }
        private void CargarComboMozo()
        {
                LoadCombo(dropMozo);
        }
        private void CargarComboArticulo()
        {
                LoadCombo(dropArticulo);
               
        }
        private void nextNumberTicket()
        {
            lblIdTicket.Text = (TicketDAL.TraerNumeroTicket() + 1).ToString();
        }

       
        private void calcularTotal()
        {
            int sum = 0;
            foreach (GridViewRow item in gvTicket.Rows)
            {
                sum += (int.Parse(item.Cells[3].Text) * int.Parse(item.Cells[2].Text));
            }
            lblTotal.Text = sum.ToString();
        }

        public void LoadCombo(DropDownList dropDownList)
        {
            dropDownList.Items.Clear();
            switch (dropDownList.ID)
            {
                case "dropArticulo":
                    dropDownList.Items.Clear();
                    dropDownList.Items.Add("[Seleccione...]");
                    List<Entidades.Articulo> art = ArticuloDAL.ObtenerComboArticulo();
                    foreach (Entidades.Articulo pv in art)
                        dropArticulo.Items.Add(new ListItem(pv.nameArticulo, pv.idArticulo.ToString()));
                    break;
                case "dropMozo":
                    dropDownList.Items.Clear();
                    dropDownList.Items.Add("[Seleccione...]");
                    List<Entidades.Mozo> mo = MozoDAL.ObtenerComboMozo();
                    foreach (Entidades.Mozo pv in mo)
                        dropMozo.Items.Add(new System.Web.UI.WebControls.ListItem(pv.name, pv.mozo.ToString()));
                    break;
                case "dropLocal":
                    dropDownList.Items.Clear();
                    dropDownList.Items.Add("[Seleccione...]");
                    List<Entidades.Local> lo = LocalDAL.ObtenerComboLocal();              
                        foreach (Entidades.Local pv in lo)
                        dropLocal.Items.Add(new System.Web.UI.WebControls.ListItem(pv.entidad, pv.idLocal.ToString()));
                    break;
            }
        }

        
    }
   
}