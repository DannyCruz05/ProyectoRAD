using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Factura
    {
        CD_Facturas cdFactura = new CD_Facturas();
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
        public string Insertar()
        {
            cdFactura.FacturaId = this.FacturaId;
            cdFactura.ClienteId = this.ClienteId;
            cdFactura.PedidoId = this.PedidoId;
            cdFactura.FechaCreacion = this.FechaCreacion;
            cdFactura.FechaFactura = this.FechaFactura;
            cdFactura.Estado = this.Estado;
            cdFactura.Total = this.Total;
            cdFactura.SubTotal = this.SubTotal;
            cdFactura.Descuento = this.Descuento;

            string mensaje = cdFactura.InsertarFactura();

            return mensaje;
        }

        public string Modificar()
        {
            cdFactura.FacturaId = this.FacturaId;
            cdFactura.ClienteId = this.ClienteId;
            cdFactura.PedidoId = this.PedidoId;
            cdFactura.FechaCreacion = this.FechaCreacion;
            cdFactura.FechaFactura = this.FechaFactura;
            cdFactura.Estado = this.Estado;
            cdFactura.Total = this.Total;
            cdFactura.SubTotal = this.SubTotal;
            cdFactura.Descuento = this.Descuento;

            string mensaje = cdFactura.ModificarFactura();

            return mensaje;
        }

        public string Eliminar()
        {
            cdFactura.FacturaId = this.FacturaId;
            return cdFactura.EliminarFactura();
        }

        //public DataSet Consultar()
        //{
        //    cdFactura.FacturaId = this.FacturaId;
        //    return cdFactura.ConsultarFactura();
        //}

        //public DataSet Buscar()
        //{
        //    cdFactura.FacturaId = this.FacturaId;
        //    return cdFactura.BuscarFactura();
        //}
    }
}
