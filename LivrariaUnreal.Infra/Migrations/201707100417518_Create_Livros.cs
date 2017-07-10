namespace LivrariaUnreal.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Livros : DbMigration
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
                        TipoLivro = c.Int(nullable: false),
                        DataCriação = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Livro");
        }
    }
}
