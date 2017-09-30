namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("insert into Categories values(1, 'Web Development')");
            Sql("insert into Categories values(2, 'Programming Languages')");

        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
