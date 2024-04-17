namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablaDetallePedido : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetallePedidos",
                c => new
                    {
                        PedidoDetalleId = c.Int(nullable: false, identity: true),
                        PedidoId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PedidoDetalleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DetallePedidos");
        }
    }
}
