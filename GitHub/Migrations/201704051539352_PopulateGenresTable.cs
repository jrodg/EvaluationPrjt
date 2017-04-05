namespace GitHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres(Id, name) Values(1, 'Jazz')");
            Sql("Insert into Genres(Id, name) Values(2, 'Pop')");
            Sql("Insert into Genres(Id, name) Values(3, 'Rock')");
            Sql("Insert into Genres(Id, name) Values(4, 'Salsa')");
        }
        
        public override void Down()
        {
            Sql("Delete From Genres Where Id In (1,2,3,4)");
        }
    }
}
