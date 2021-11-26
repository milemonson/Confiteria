using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace DatosDAL
{
    public class TicketDAL
    {
        public static bool insertarDetalleTicket(Ticket ti, List<DetalleTicket> dt)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString);
            SqlTransaction objTransaccion  = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idLocal",ti.idLocal);
                cmd.Parameters.AddWithValue("@idMozo", ti.idMozo);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Today);
                cmd.CommandText = "sp_insertTicket";
                cn.Open();
                objTransaccion = cn.BeginTransaction("insertarDetalleTicket");
                cmd.Transaction = objTransaccion;
                cmd.ExecuteNonQuery();

                foreach (var id in dt){
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idTicket", id.idTicket);
                    cmd.Parameters.AddWithValue("@articulo",id.articulo);
                    cmd.Parameters.AddWithValue("@cantidad",id.cantidad );
                    cmd.CommandText = "sp_insertDetalleTicket";
                    cmd.ExecuteNonQuery();
                }

                objTransaccion.Commit();
                return true;
            }
            catch (Exception)
            {
                objTransaccion.Rollback();
                return false;
            }
        }

      
        public static int TraerNumeroTicket()
        {
            int idTicket = 0 ;
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString);
        
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "sp_traerTicket";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                idTicket = (int)cmd.ExecuteScalar();
                return idTicket;
            }
            catch (Exception)
            {
                return idTicket;
            }

        }
        public static SqlDataReader VentasPorDia(DateTime fecha)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString);
           
            try
           {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.CommandText = "sp_VentasporDia";
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cn.Open();
                SqlDataReader obt = cmd.ExecuteReader();
                return obt;
            }
            catch (Exception ex)
            {
                throw ex;             
            }
        }

        public static decimal TotalPorDia(DateTime fecha)
        {

            decimal total = 0;
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "sp_TotalPorDia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cn.Open();
                SqlDataReader obt = cmd.ExecuteReader();

                if (obt.Read())
                {
                    if (obt["Total"] != null)
                    {
                        total = (decimal)obt["Total"];
                    }

                }
                return total;

            }
            catch (Exception)
            {
                return total;
            }
        }
    }
}
