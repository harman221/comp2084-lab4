﻿namespace PhoneAppliation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        ManufacturerID = c.Int(nullable: false, identity: true),
                        ManufacturerName = c.String(),
                        URL = c.String(),
                        DateReleased = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ManufacturerID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneID = c.Int(nullable: false, identity: true),
                        ManufacturerID = c.Int(nullable: false),
                        MSRP = c.Int(nullable: false),
                        ScreenSize = c.Int(nullable: false),
                        PhoneName = c.String(),
                        DateReleased = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneID)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerID, cascadeDelete: true)
                .Index(t => t.ManufacturerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "ManufacturerID", "dbo.Manufacturers");
            DropIndex("dbo.Phones", new[] { "ManufacturerID" });
            DropTable("dbo.Phones");
            DropTable("dbo.Manufacturers");
        }
    }
}
