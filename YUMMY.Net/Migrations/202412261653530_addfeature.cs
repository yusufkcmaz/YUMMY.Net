﻿namespace YUMMY.Net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfeature : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Features", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Features", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Features", "Description", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Features", "VideoUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Features", "VideoUrl", c => c.String());
            AlterColumn("dbo.Features", "Description", c => c.String());
            AlterColumn("dbo.Features", "Title", c => c.String());
            AlterColumn("dbo.Features", "ImageUrl", c => c.String());
        }
    }
}
