using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_PedidoDetalle
    {
        CD_PedidoDetalle cdPedido = new CD_PedidoDetalle();
        public int PedidoDetalleId { get; set; }
        public int Nulidad { get; set; }
        public int FK_PedidoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int FK_ProductoId { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }

        public string Insertar()
        {
            cdPedido.PedidoDetalleId = this.PedidoDetalleId;
            cdPedido.Nulidad = this.Nulidad;
            cdPedido.FK_PedidoId = this.FK_PedidoId;
            cdPedido.FechaCreacion = this.FechaCreacion;
            cdPedido.FK_ProductoId = this.FK_ProductoId;
            cdPedido.Precio = this.Precio;
            cdPedido.Total = this.Total;
            cdPedido.SubTotal = this.SubTotal;
            cdPedido.Descuento = this.Descuento;

            string mensaje = cdPedido.Insertar();

            return mensaje;
        }

        public string Modificar()
        {
            cdPedido.PedidoDetalleId = this.PedidoDetalleId;
            cdPedido.Nulidad = this.Nulidad;
            cdPedido.FK_PedidoId = this.FK_PedidoId;
            cdPedido.FechaCreacion = this.FechaCreacion;
            cdPedido.FK_ProductoId = this.FK_ProductoId;
            cdPedido.Precio = this.Precio;
            cdPedido.Total = this.Total;
            cdPedido.SubTotal = this.SubTotal;
            cdPedido.Descuento = this.Descuento;

            string mensaje = cdPedido.Modificar();

            return mensaje;
        }

        public string Eliminar()
        {
            cdPedido.PedidoDetalleId = this.PedidoDetalleId;
            return cdPedido.Eliminar();
        }

        public DataSet Consultar()
        {
            cdPedido.PedidoDetalleId = this.PedidoDetalleId;
            return cdPedido.Consultar();
        }

        public DataSet Buscar()
        {
            cdPedido.PedidoDetalleId = this.PedidoDetalleId;
            return cdPedido.Buscar();
        }

    }

}
