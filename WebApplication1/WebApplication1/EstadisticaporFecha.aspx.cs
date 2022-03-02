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
    public partial class EstadisticaporFecha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if (!IsPostBack)
                {
                btnDescargar.Enabled = false;
                calcularTotal();
                }
        }

        protected void btnVentas_Click(object sender, EventArgs e)
        {
            gvVxFecha.DataSource= TicketDAL.VentasPorRango(DateTime.Parse(txtDateEntrada.Text), DateTime.Parse(txtDateSalida.Text));
            gvVxFecha.DataBind();
            lblTotalPorFechas.Enabled = true;
            calcularTotal();
            btnDescargar.Enabled = true;
        }
        private void calcularTotal()
        {
            int sum = 0;
            foreach (GridViewRow item in gvVxFecha.Rows)
            {
                sum += (int.Parse(item.Cells[2].Text));
            }
            lblTotalPorFechas.Text = sum.ToString();
        }
    }
}