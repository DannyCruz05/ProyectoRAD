using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Pedidos

    {
        CD_Pedidos cdPedido = new CD_Pedidos();
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

        public string Insertar()
        {
            cdPedido.Pedidold = this.Pedidold;
            cdPedido.Pedido = this.Pedido;
            cdPedido.Nulidad = this.Nulidad;
            cdPedido.FK_Clienteld = this.FK_Clienteld;
            cdPedido.FechaCreacion = this.FechaCreacion;
            cdPedido.FechaPedido = this.FechaPedido;
            cdPedido.Estado = this.Estado;
            cdPedido.Total = this.Total;
            cdPedido.SubtTotal = this.SubtTotal;
            cdPedido.Descuento = this.Descuento;

            string mensaje = cdPedido.Insertar();

            return mensaje;
        }

        public string Modificar()
        {
            cdPedido.Pedidold = this.Pedidold;
            cdPedido.Pedido = this.Pedido;
            cdPedido.Nulidad = this.Nulidad;
            cdPedido.FK_Clienteld = this.FK_Clienteld;
            cdPedido.FechaCreacion = this.FechaCreacion;
            cdPedido.FechaPedido = this.FechaPedido;
            cdPedido.Estado = this.Estado;
            cdPedido.Total = this.Total;
            cdPedido.SubtTotal = this.SubtTotal;
            cdPedido.Descuento = this.Descuento;

            string mensaje = cdPedido.Modificar();

            return mensaje;
        }

        public string Eliminar()
        {
            cdPedido.Pedidold = this.Pedidold;
            return cdPedido.Eliminar();
        }

        public DataSet Consultar()
        {
            cdPedido.Pedido = this.Pedido;
            return cdPedido.Consultar();
        }

        public DataSet Buscar()
        {
            cdPedido.Pedidold = this.Pedidold;
            return cdPedido.Buscar();
        }
    }
}
