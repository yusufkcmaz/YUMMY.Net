﻿namespace YUMMY.Net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_table_admin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
