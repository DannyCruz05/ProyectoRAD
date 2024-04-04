using CapaDatos;
using Fluent.Infrastructure.FluentModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Clientes
    {
        CD_Clientes cdClientes = new CD_Clientes();
        public int ClienteId { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int GrupoDescuentoId { get; set; }
        public int CondicionId { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public string Insertar()
        {
            cdClientes.ClienteId = this.ClienteId;
            cdClientes.Codigo = this.Codigo;
            cdClientes.Nombres = this.Nombres;
            cdClientes.Apellidos = this.Apellidos;
            cdClientes.GrupoDescuentoId = this.GrupoDescuentoId;
            cdClientes.CondicionId = this.CondicionId;
            cdClientes.Estado = this.Estado;
            cdClientes.FechaCreacion = this.FechaCreacion;

            string mensaje = cdClientes.Insertar();

            return mensaje;
        }

        public string Modificar()
        {
            cdClientes.ClienteId = this.ClienteId;
            cdClientes.Codigo = this.Codigo;
            cdClientes.Nombres = this.Nombres;
            cdClientes.Apellidos = this.Apellidos;
            cdClientes.GrupoDescuentoId = this.GrupoDescuentoId;
            cdClientes.CondicionId = this.CondicionId;
            cdClientes.Estado = this.Estado;
            cdClientes.FechaCreacion = this.FechaCreacion;

            string mensaje = cdClientes.Modificar();

            return mensaje;
        }

        public string Eliminar()
        {
            cdClientes.ClienteId = this.ClienteId;
            return cdClientes.Eliminar();
        }

        public DataSet Consultar()
        {
            cdClientes.Nombres = this.Nombres;
            cdClientes.Apellidos = this.Apellidos;
            return cdClientes.Consultar();
        }

        public DataSet Buscar()
        {
            cdClientes.ClienteId = this.ClienteId;
            return cdClientes.Buscar();
        }
    }
}
