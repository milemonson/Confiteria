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
    public partial class Estadistica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTotal.Enabled = false;
            lblTotalPorDia.Enabled = false;
            lblInforme.Enabled = false;
            calcularTotal();
            lblTotal.Enabled = false;
            lblTotalaPagar.Enabled = false;
            lblVentasPorMozo.Enabled = false;
            btnDescargar.Enabled = false;
            calcularTotalapagar();
        }

        protected void btnVentasPorDia_Click(object sender, EventArgs e)
        {
            gvVxDia.DataSource = TicketDAL.VentasPorDia(dtpFechaVxDia.SelectedDate);
            gvVxDia.DataBind();
            string fecha = dtpFechaVxDia.SelectedDate.ToString();
            lblFechaxV.Text = fecha;
            calcularTotal();
            lblTotal.Enabled = true;
            lblTotalPorDia.Enabled = true;
            btnDescargar.Enabled = true;
            lblInforme.Enabled = true;
           
        }

        private void calcularTotal()
        {
            int sum = 0;
            foreach (GridViewRow item in gvVxDia.Rows)
            {
                sum += (int.Parse(item.Cells[2].Text));
            }
            lblTotalPorDia.Text = sum.ToString();
        }

        protected void btnVentasPorMozo_Click(object sender, EventArgs e)
        {
            gvVxM.DataSource = MozoBLL.ventasPorMozo(dtpFechaVxMozo.SelectedDate);
            gvVxM.DataBind();
            string fecha = dtpFechaVxMozo.SelectedDate.ToString();
            lblfechamozo.Text = fecha;
            calcularTotalapagar();
            lblTotalaPagar.Enabled = true;
            lblTotal.Enabled = true;
            btnDescargar.Enabled = true;
            lblVentasPorMozo.Enabled = true;
        }
        private void calcularTotalapagar()
        {
            float sum = 0;
            foreach (GridViewRow item in gvVxM.Rows)
            {
                sum += float.Parse(item.Cells[4].Text);
            }
            lblTotalaPagar.Text = sum.ToString();
        }

    }
}