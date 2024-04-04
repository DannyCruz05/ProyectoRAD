using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_PedidoDetalle
    {
        public int PedidoDetalleId { get; set; }
        public int Nulidad { get; set; }
        public int FK_PedidoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int FK_ProductoId { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }

        SqlCommand comando = new SqlCommand();
        CD_Conexion conexion = new CD_Conexion();

        public string InsertarPedidoDetalle()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("insertar_pedido_detalle", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@PedidoDetalleId", PedidoDetalleId);
                        command.Parameters.AddWithValue("@Nulidad", Nulidad);
                        command.Parameters.AddWithValue("@FK_PedidoId", FK_PedidoId);
                        command.Parameters.AddWithValue("@FechaCreacion", FechaCreacion);
                        command.Parameters.AddWithValue("@FK_ProductoId", FK_ProductoId);
                        command.Parameters.AddWithValue("@Precio", Precio);
                        command.Parameters.AddWithValue("@Total", Total);
                        command.Parameters.AddWithValue("@SubTotal", SubTotal);
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

        public string ModificarPedidoDetalle()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("modificar_pedido_detalle", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@PedidoDetalleId", PedidoDetalleId);
                        command.Parameters.AddWithValue("@Nulidad", Nulidad);
                        command.Parameters.AddWithValue("@FK_PedidoId", FK_PedidoId);
                        command.Parameters.AddWithValue("@FechaCreacion", FechaCreacion);
                        command.Parameters.AddWithValue("@FK_ProductoId", FK_ProductoId);
                        command.Parameters.AddWithValue("@Precio", Precio);
                        command.Parameters.AddWithValue("@Total", Total);
                        command.Parameters.AddWithValue("@SubTotal", SubTotal);
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

        public string EliminarPedidoDetalle()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("eliminar_pedido_detalle", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@PedidoDetalleId", PedidoDetalleId);

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

        public DataSet ConsultarPedidoDetalle(int pedidoDetalleId)
        {
            try
            {
                using (var datos = new DataSet())
                {
                    using (var adaptador = new SqlDataAdapter())
                    {
                        using (SqlCommand comando = new SqlCommand("consultar_pedido_detalle", conexion.Conectar()))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.Clear();
                            comando.Parameters.AddWithValue("@PedidoDetalleId", pedidoDetalleId);

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
