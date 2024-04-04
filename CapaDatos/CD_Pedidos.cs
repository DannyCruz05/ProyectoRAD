using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Pedidos
    {
        
        public int Pedidold { get; set; }
        public int Pedido { get; set; }
        public int Nulidad { get; set; }
        public int FK_Clienteld { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPedido { get; set; }
        public bool Estado { get; set; }
        public decimal Total { get; set; }
        public decimal SubtTotal { get; set; }
        public decimal Descuento { get; set; }

        SqlCommand comando = new SqlCommand();
        CD_Conexion conexion = new CD_Conexion();

        public string InsertarPedido()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("insertar_pedido", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@PedidoId", Pedidold);
                        command.Parameters.AddWithValue("@Nulidad", Nulidad);
                        command.Parameters.AddWithValue("@FK_ClienteId", FK_Clienteld);
                        command.Parameters.AddWithValue("@FechaCreacion", FechaCreacion);
                        command.Parameters.AddWithValue("@FechaPedido", FechaPedido);
                        command.Parameters.AddWithValue("@Estado", Estado);
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

        public string ModificarPedido()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("modificar_pedido", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@PedidoId", Pedidold);
                        command.Parameters.AddWithValue("@Nulidad", Nulidad);
                        command.Parameters.AddWithValue("@FK_ClienteId", FK_Clienteld);
                        command.Parameters.AddWithValue("@FechaCreacion", FechaCreacion);
                        command.Parameters.AddWithValue("@FechaPedido", FechaPedido);
                        command.Parameters.AddWithValue("@Estado", Estado);
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

        public string EliminarPedido()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("eliminar_pedido", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@PedidoId", Pedidold);

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

        public DataSet ConsultarPedido(int pedidoId)
        {
            try
            {
                using (var datos = new DataSet())
                {
                    using (var adaptador = new SqlDataAdapter())
                    {
                        using (SqlCommand comando = new SqlCommand("consultar_pedido", conexion.Conectar()))
                        {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.Clear();
                            comando.Parameters.AddWithValue("@PedidoId", pedidoId);

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
