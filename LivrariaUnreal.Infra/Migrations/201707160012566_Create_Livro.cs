namespace LivrariaUnreal.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Livro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                        Isbn = c.String(maxLength: 100, unicode: false),
                        Titulo = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Livro");
        }
    }
}
