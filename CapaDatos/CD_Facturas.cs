using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Vml;

namespace CapaDatos
{
    public class CD_Facturas
    {
        [Key]
        [Required]
        public int FacturaId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public int PedidoId { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        [Required]
        public DateTime FechaFactura { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal Descuento { get; set; }
    
    SqlCommand comando = new SqlCommand();
    CD_Conexion conexion = new CD_Conexion();
    public string InsertarFactura()
    {
        try
        {
            using (SqlConnection connection = conexion.Conectar())
            {
                using (SqlCommand command = new SqlCommand("insertar_factura", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ClienteId", ClienteId);
                    command.Parameters.AddWithValue("@PedidoId", PedidoId);
                    command.Parameters.AddWithValue("@FechaCreacion", FechaCreacion);
                    command.Parameters.AddWithValue("@FechaFactura", FechaFactura);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@Total", Total);
                    command.Parameters.AddWithValue("@SubtTotal", SubTotal);
                    command.Parameters.AddWithValue("@Descuento", Descuento);

                    command.ExecuteNonQuery();
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public string ModificarFactura()
    {
        try
        {
            using (SqlConnection connection = conexion.Conectar())
            {
                using (SqlCommand command = new SqlCommand("modificar_factura", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@FacturaId", FacturaId);
                    command.Parameters.AddWithValue("@ClienteId", ClienteId);
                    command.Parameters.AddWithValue("@PedidoId", PedidoId);
                    command.Parameters.AddWithValue("@FechaCreacion", FechaCreacion);
                    command.Parameters.AddWithValue("@FechaFactura", FechaFactura);
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@Total", Total);
                    command.Parameters.AddWithValue("@SubtTotal", SubTotal);
                    command.Parameters.AddWithValue("@Descuento", Descuento);

                    command.ExecuteNonQuery();
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public string EliminarFactura()
    {
        try
        {
            using (SqlConnection connection = conexion.Conectar())
            {
                using (SqlCommand command = new SqlCommand("eliminar_factura", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@FacturaId", FacturaId);

                    command.ExecuteNonQuery();
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public DataSet ConsultarFactura(int facturaId)
    {
        try
        {
            using (var datos = new DataSet())
            {
                using (var adaptador = new SqlDataAdapter())
                {
                    using (SqlCommand comando = new SqlCommand("consultar_factura", conexion.Conectar()))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@FacturaId", facturaId);

                        adaptador.SelectCommand = comando;
                        adaptador.Fill(datos);
                    }
                }

                return datos;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en la consulta: {ex.Message}");
            return null;
        }
    }
}
}

