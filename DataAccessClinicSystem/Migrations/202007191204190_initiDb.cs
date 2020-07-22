namespace DataAccessClinicSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initiDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accesseds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Group_id = c.Int(nullable: false),
                        Module_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_id, cascadeDelete: true)
                .ForeignKey("dbo.Modules", t => t.Module_id, cascadeDelete: true)
                .Index(t => t.Group_id)
                .Index(t => t.Module_id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Int(nullable: false),
                        StatusDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Gender = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Profile_picture = c.String(),
                        Is_Doctor = c.Int(nullable: false),
                        Specialty_id = c.Int(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Effective_Date = c.DateTime(nullable: false),
                        Expiry_Date = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Status_Date = c.DateTime(nullable: false),
                        Group_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_id, cascadeDelete: true)
                .ForeignKey("dbo.Specialities", t => t.Specialty_id, cascadeDelete: true)
                .Index(t => t.Specialty_id)
                .Index(t => t.Group_id);
            
            CreateTable(
                "dbo.NewResrvations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Patint_id = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        User_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewPatints", t => t.Patint_id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_id, cascadeDelete: true)
                .Index(t => t.Patint_id)
                .Index(t => t.User_id);
            
            CreateTable(
                "dbo.NewPatints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                        Marital = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Country_id = c.Int(nullable: false),
                        City_id = c.Int(nullable: false),
                        Adress = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_id, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.Country_id, cascadeDelete: true)
                .Index(t => t.Country_id)
                .Index(t => t.City_id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_id, cascadeDelete: false)
                .Index(t => t.Country_id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NewVisits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Visit_Type = c.Int(nullable: false),
                        Visit_Reson = c.String(),
                        Doctor_report = c.String(),
                        Bp_Systolic = c.String(),
                        Bp_Diastolic = c.String(),
                        Tempruture = c.String(),
                        Respority_rate = c.String(),
                        Heigth = c.String(),
                        plus = c.String(),
                        Weigth = c.String(),
                        Patint_id = c.Int(nullable: false),
                        User_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewPatints", t => t.Patint_id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_id, cascadeDelete: true)
                .Index(t => t.Patint_id)
                .Index(t => t.User_id);
            
            CreateTable(
                "dbo.Diognostics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Diognostics_title = c.String(),
                        Diognostic = c.String(),
                        Visit_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewVisits", t => t.Visit_id, cascadeDelete: true)
                .Index(t => t.Visit_id);
            
            CreateTable(
                "dbo.Precviptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Drag_Name = c.String(),
                        Strength = c.String(),
                        Dirction_for_use = c.String(),
                        Quantity = c.String(),
                        Treatment_Details = c.String(),
                        Visit_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewVisits", t => t.Visit_id, cascadeDelete: true)
                .Index(t => t.Visit_id);
            
            CreateTable(
                "dbo.Symptoms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Symptoms_title = c.String(),
                        Symptom = c.String(),
                        Visit_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewVisits", t => t.Visit_id, cascadeDelete: true)
                .Index(t => t.Visit_id);
            
            CreateTable(
                "dbo.TestOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Test_Name = c.String(),
                        Test_Details = c.String(),
                        Test_Report = c.String(),
                        Visit_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewVisits", t => t.Visit_id, cascadeDelete: true)
                .Index(t => t.Visit_id);
            
            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortName = c.String(),
                        Order = c.Int(nullable: false),
                        Path = c.String(),
                        SubModule = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accesseds", "Module_id", "dbo.Modules");
            DropForeignKey("dbo.Accesseds", "Group_id", "dbo.Groups");
            DropForeignKey("dbo.Users", "Specialty_id", "dbo.Specialities");
            DropForeignKey("dbo.NewResrvations", "User_id", "dbo.Users");
            DropForeignKey("dbo.NewResrvations", "Patint_id", "dbo.NewPatints");
            DropForeignKey("dbo.NewVisits", "User_id", "dbo.Users");
            DropForeignKey("dbo.TestOrders", "Visit_id", "dbo.NewVisits");
            DropForeignKey("dbo.Symptoms", "Visit_id", "dbo.NewVisits");
            DropForeignKey("dbo.Precviptions", "Visit_id", "dbo.NewVisits");
            DropForeignKey("dbo.NewVisits", "Patint_id", "dbo.NewPatints");
            DropForeignKey("dbo.Diognostics", "Visit_id", "dbo.NewVisits");
            DropForeignKey("dbo.NewPatints", "Country_id", "dbo.Countries");
            DropForeignKey("dbo.NewPatints", "City_id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "Country_id", "dbo.Countries");
            DropForeignKey("dbo.Users", "Group_id", "dbo.Groups");
            DropIndex("dbo.TestOrders", new[] { "Visit_id" });
            DropIndex("dbo.Symptoms", new[] { "Visit_id" });
            DropIndex("dbo.Precviptions", new[] { "Visit_id" });
            DropIndex("dbo.Diognostics", new[] { "Visit_id" });
            DropIndex("dbo.NewVisits", new[] { "User_id" });
            DropIndex("dbo.NewVisits", new[] { "Patint_id" });
            DropIndex("dbo.Cities", new[] { "Country_id" });
            DropIndex("dbo.NewPatints", new[] { "City_id" });
            DropIndex("dbo.NewPatints", new[] { "Country_id" });
            DropIndex("dbo.NewResrvations", new[] { "User_id" });
            DropIndex("dbo.NewResrvations", new[] { "Patint_id" });
            DropIndex("dbo.Users", new[] { "Group_id" });
            DropIndex("dbo.Users", new[] { "Specialty_id" });
            DropIndex("dbo.Accesseds", new[] { "Module_id" });
            DropIndex("dbo.Accesseds", new[] { "Group_id" });
            DropTable("dbo.Modules");
            DropTable("dbo.Specialities");
            DropTable("dbo.TestOrders");
            DropTable("dbo.Symptoms");
            DropTable("dbo.Precviptions");
            DropTable("dbo.Diognostics");
            DropTable("dbo.NewVisits");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.NewPatints");
            DropTable("dbo.NewResrvations");
            DropTable("dbo.Users");
            DropTable("dbo.Groups");
            DropTable("dbo.Accesseds");
        }
    }
}
