namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablaEmpleados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        idempleado = c.Int(nullable: false, identity: true),
                        razonsocial = c.String(nullable: false),
                        fechanacimiento = c.DateTime(storeType: "date"),
                        edad = c.Int(),
                        salario = c.Single(),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idempleado);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleados");
        }
    }
}
