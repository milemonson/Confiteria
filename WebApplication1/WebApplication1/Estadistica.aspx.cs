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
            dtpFecha.SelectedDate = DateTime.Today;
            lblTotal.Visible = false;
            lblTotalPorDia.Visible = false;
            lblInforme.Visible = false;
            btnDescargar.Visible = false;
            calcularTotal();
        }

        protected void btnVentasPorDia_Click(object sender, EventArgs e)
        {
            gvTotalPorDia.DataSource = TicketDAL.VentasPorDia(dtpFecha.SelectedDate);
            gvTotalPorDia.DataBind();
            string fecha = dtpFecha.SelectedDate.ToString();
            lblFecha1.Text = fecha;
            calcularTotal();
            lblTotal.Visible = true;
            lblTotalPorDia.Visible = true;
            lblInforme.Visible = true;
            btnDescargar.Visible = true;

        }

        private void calcularTotal()
        {
            int sum = 0;
            foreach (GridViewRow item in gvTotalPorDia.Rows)
            {
                sum += (int.Parse(item.Cells[2].Text));
            }
            lblTotalPorDia.Text = sum.ToString();
        }

    }
}