using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Clientes
    {
        [Key]
        [Required]
        public int ClienteId { get; set; }
        [MaxLength(10)]
        [Required]
        public string Codigo { get; set; }
        [MaxLength(15)]
        [Required]
        public string Nombres { get; set; }
        [MaxLength(50)]
        [Required]
        public string Apellidos { get; set; }
        [MaxLength(50)]
        [Required]
        [ForeignKey("GrupoDescuentoId")]
        public int GrupoDescuentoId { get; set; }
        [Required]

        [ForeignKey("CondicionId")]
        public int CondicionId { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public System.DateTime FechaCreacion { get; set; }

        SqlCommand comando = new SqlCommand();
        CD_Conexion conexion = new CD_Conexion();

        public string Insertar()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("insertar_cliente", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@ClienteId", ClienteId);
                        command.Parameters.AddWithValue("@Codigo", Codigo);
                        command.Parameters.AddWithValue("@Nombres", Nombres);
                        command.Parameters.AddWithValue("@Apellidos", Apellidos);
                        command.Parameters.AddWithValue("@GrupoDescuentoId", GrupoDescuentoId);
                        command.Parameters.AddWithValue("@CondicionId", CondicionId);
                        command.Parameters.AddWithValue("@Estado", Estado);

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


        public string Modificar()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("modificar_cliente", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@ClienteId", ClienteId);
                        command.Parameters.AddWithValue("@Codigo", Codigo);
                        command.Parameters.AddWithValue("@Nombres", Nombres);
                        command.Parameters.AddWithValue("@Apellidos", Apellidos);
                        command.Parameters.AddWithValue("@GrupoDescuentoId", GrupoDescuentoId);
                        command.Parameters.AddWithValue("@CondicionId", CondicionId);
                        command.Parameters.AddWithValue("@Estado", Estado);

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

        public string Eliminar()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand("eliminar_empleado", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@ClienteId", ClienteId);

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

        public DataSet Consultar()
        {
            try
            {
                using (var datos = new DataSet())
                {
                    using (var adaptador = new SqlDataAdapter())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "consultar_cliente";
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@Codigo", Codigo);

                        using (SqlConnection connection = conexion.Conectar())
                        {
                            comando.Connection = connection;
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

        public DataSet Buscar()
        {
            try
            {
                using (var datos = new DataSet())
                {
                    using (var adaptador = new SqlDataAdapter())
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "buscar_cliente";
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@ClienteId", ClienteId);

                        using (SqlConnection connection = conexion.Conectar())
                        {
                            comando.Connection = connection;
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

