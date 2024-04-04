using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_FacturaDetalle
    {
        public int FacturaDetalleId { get; set; }

        public int FacturaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int ProductoId { get; set; }

        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal SubtTotal { get; set; }
        public decimal Descuento { get; set; }


        SqlCommand comando = new SqlCommand();
        CD_Conexion conexion = new CD_Conexion();


        public string InsertarFacturaDetalle()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("insertar_factura_detalle", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@FacturaDetalleId", FacturaDetalleId);
                        command.Parameters.AddWithValue("@FacturaId", FacturaId);
                        command.Parameters.AddWithValue("@FechaCreacion", FechaCreacion);
                        command.Parameters.AddWithValue("@ProductoId", ProductoId);
                        command.Parameters.AddWithValue("@Precio", Precio);
                        command.Parameters.AddWithValue("@Total", Total);
                        command.Parameters.AddWithValue("@SubtTotal", SubtTotal);
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

        public string ModificarFacturaDetalle()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("modificar_factura_detalle", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@FacturaDetalleId", FacturaDetalleId);
                        command.Parameters.AddWithValue("@FacturaId", FacturaId);
                        command.Parameters.AddWithValue("@FechaCreacion", FechaCreacion);
                        command.Parameters.AddWithValue("@ProductoId", ProductoId);
                        command.Parameters.AddWithValue("@Precio", Precio);
                        command.Parameters.AddWithValue("@Total", Total);
                        command.Parameters.AddWithValue("@SubtTotal", SubtTotal);
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

        public string EliminarFacturaDetalle()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("eliminar_factura_detalle", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@FacturaDetalleId", FacturaDetalleId);

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

        public DataSet ConsultarFacturaDetalle(int facturaDetalleId)
        {
            try
            {
                using (var datos = new DataSet())
                {
                    using (var adaptador = new SqlDataAdapter())
                    {
                        using (SqlCommand comando = new SqlCommand("consultar_factura_detalle", conexion.Conectar()))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.Clear();
                            comando.Parameters.AddWithValue("@FacturaDetalleId", facturaDetalleId);

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
