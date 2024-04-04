using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class CN_FacturaDetalle
    {
        CD_FacturaDetalle cdFacturaDetalle = new CD_FacturaDetalle();
        public int FacturaDetalleId { get; set; }

        public int FacturaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int ProductoId { get; set; }

        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public decimal SubtTotal { get; set; }
        public decimal Descuento { get; set; }


        public string Insertar()
        {
            cdFacturaDetalle.FacturaDetalleId = this.FacturaDetalleId;
            cdFacturaDetalle.FacturaId = this.FacturaId;
            cdFacturaDetalle.FechaCreacion = this.FechaCreacion;
            cdFacturaDetalle.ProductoId = this.ProductoId;
            cdFacturaDetalle.Precio = this.Precio;
            cdFacturaDetalle.Total = this.Total;
            cdFacturaDetalle.SubtTotal = this.SubtTotal;
            cdFacturaDetalle.Descuento = this.Descuento;

            string mensaje = cdFacturaDetalle.Insertar();

            return mensaje;
        }

        public string Modificar()
        {
            cdFacturaDetalle.FacturaDetalleId = this.FacturaDetalleId;
            cdFacturaDetalle.FacturaId = this.FacturaId;
            cdFacturaDetalle.FechaCreacion = this.FechaCreacion;
            cdFacturaDetalle.ProductoId = this.ProductoId;
            cdFacturaDetalle.Precio = this.Precio;
            cdFacturaDetalle.Total = this.Total;
            cdFacturaDetalle.SubtTotal = this.SubtTotal;
            cdFacturaDetalle.Descuento = this.Descuento;

            string mensaje = cdFacturaDetalle.Modificar();

            return mensaje;
        }

        public string Eliminar()
        {
            cdFacturaDetalle.FacturaDetalleId = this.FacturaDetalleId;
            return cdFacturaDetalle.Eliminar();
        }

        public DataSet Consultar()
        {
            cdFacturaDetalle.FacturaDetalleId = this.FacturaDetalleId;
            return cdFacturaDetalle.Consultar();
        }

        public DataSet Buscar()
        {
            cdFacturaDetalle.FacturaDetalleId = this.FacturaDetalleId;
            return cdFacturaDetalle.Buscar();
        }
    }
}
