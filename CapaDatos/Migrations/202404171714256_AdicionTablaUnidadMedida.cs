namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablaUnidadMedida : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.UnidadMedida");
            AddColumn("dbo.UnidadMedida", "UnidadMedidaId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.UnidadMedida", "FechaModificacion", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.UnidadMedida", "UnidadMedidaId");
            DropColumn("dbo.UnidadMedida", "ClienteId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UnidadMedida", "ClienteId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.UnidadMedida");
            DropColumn("dbo.UnidadMedida", "FechaModificacion");
            DropColumn("dbo.UnidadMedida", "UnidadMedidaId");
            AddPrimaryKey("dbo.UnidadMedida", "ClienteId");
        }
    }
}
