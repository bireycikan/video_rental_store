namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'242d479c-7201-4c6c-b0e6-101f4f1745ca', N'guest@vidly.com', 0, N'AA+/2p3tATN3dGhrrZ4r4bzb8STSQv0CWvXUhSxFf1asaGHgEzBKjV1xgO4Bpj6KUw==', N'062a79f4-723f-455c-b024-350edf554bb2', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9b56a41f-1165-4fca-a6a7-0595e7148756', N'admin@vidly.com', 0, N'AINWaHe9RdeY35Ka5SaXS1Cpmd47gVUdSw0307I2cPXbM6SiEACBWIMcCi/B86a7Jw==', N'969a3605-8632-41b5-a9a5-de4abaf3f08f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'75aefa49-f78d-4951-b5f2-5b787fe00b29', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9b56a41f-1165-4fca-a6a7-0595e7148756', N'75aefa49-f78d-4951-b5f2-5b787fe00b29')

");
        }
        
        public override void Down()
        {
        }
    }
}
