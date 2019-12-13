namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes_part2 : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name = 'Quarterly' where Id = 3");
            Sql("update MembershipTypes set Name = 'Annual' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
