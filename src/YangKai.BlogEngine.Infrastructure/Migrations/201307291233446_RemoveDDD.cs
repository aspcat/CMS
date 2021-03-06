namespace YangKai.BlogEngine.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDDD : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Posts", "PubAdminId", "dbo.Users");
            //DropForeignKey("dbo.Tags", "PostId", "dbo.Posts");
            DropIndex("dbo.Posts", new[] { "PubAdminId" });
            DropIndex("dbo.Tags", new[] { "PostId" });
            RenameColumn(table: "dbo.Posts", name: "PubAdminId", newName: "PubAdmin_UserId");
            RenameColumn(table: "dbo.Posts", name: "EditAdminId", newName: "EditAdmin_UserId");
            RenameColumn(table: "dbo.Tags", name: "PostId", newName: "Post_PostId");
            AddColumn("dbo.Users", "Avatar", c => c.String());
            AddColumn("dbo.Users", "CreateUser", c => c.String());
            AddColumn("dbo.Users", "LastEditUser", c => c.String());
            AddColumn("dbo.Users", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.Users", "OrderId", c => c.Int());
            AddColumn("dbo.Users", "Remark", c => c.String());
            AddColumn("dbo.Logs", "CreateUser", c => c.String());
            AddColumn("dbo.Logs", "LastEditUser", c => c.String());
            AddColumn("dbo.Logs", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.Logs", "OrderId", c => c.Int());
            AddColumn("dbo.Logs", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Logs", "Remark", c => c.String());
            AddColumn("dbo.Channels", "CreateUser", c => c.String());
            AddColumn("dbo.Channels", "LastEditUser", c => c.String());
            AddColumn("dbo.Channels", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.Channels", "Remark", c => c.String());
            AddColumn("dbo.Groups", "CreateUser", c => c.String());
            AddColumn("dbo.Groups", "LastEditUser", c => c.String());
            AddColumn("dbo.Groups", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.Groups", "Remark", c => c.String());
            AddColumn("dbo.Categories", "CreateUser", c => c.String());
            AddColumn("dbo.Categories", "LastEditUser", c => c.String());
            AddColumn("dbo.Categories", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.Categories", "Remark", c => c.String());
            AddColumn("dbo.Posts", "CreateUser", c => c.String());
            AddColumn("dbo.Posts", "LastEditUser", c => c.String());
            AddColumn("dbo.Posts", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.Posts", "OrderId", c => c.Int());
            AddColumn("dbo.Posts", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Posts", "Remark", c => c.String());
            AddColumn("dbo.Tags", "CreateUser", c => c.String());
            AddColumn("dbo.Tags", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tags", "LastEditUser", c => c.String());
            AddColumn("dbo.Tags", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.Tags", "OrderId", c => c.Int());
            AddColumn("dbo.Tags", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tags", "Remark", c => c.String());
            AddColumn("dbo.Comments", "CreateUser", c => c.String());
            AddColumn("dbo.Comments", "LastEditUser", c => c.String());
            AddColumn("dbo.Comments", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.Comments", "OrderId", c => c.Int());
            AddColumn("dbo.Comments", "Remark", c => c.String());
            AddColumn("dbo.QrCodes", "CreateUser", c => c.String());
            AddColumn("dbo.QrCodes", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.QrCodes", "LastEditUser", c => c.String());
            AddColumn("dbo.QrCodes", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.QrCodes", "OrderId", c => c.Int());
            AddColumn("dbo.QrCodes", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.QrCodes", "Remark", c => c.String());
            AddColumn("dbo.Sources", "CreateUser", c => c.String());
            AddColumn("dbo.Sources", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Sources", "LastEditUser", c => c.String());
            AddColumn("dbo.Sources", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.Sources", "OrderId", c => c.Int());
            AddColumn("dbo.Sources", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sources", "Remark", c => c.String());
            AddColumn("dbo.Thumbnails", "CreateUser", c => c.String());
            AddColumn("dbo.Thumbnails", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Thumbnails", "LastEditUser", c => c.String());
            AddColumn("dbo.Thumbnails", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.Thumbnails", "OrderId", c => c.Int());
            AddColumn("dbo.Thumbnails", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Thumbnails", "Remark", c => c.String());
            AddColumn("dbo.Boards", "CreateUser", c => c.String());
            AddColumn("dbo.Boards", "LastEditUser", c => c.String());
            AddColumn("dbo.Boards", "LastEditDate", c => c.DateTime());
            AddColumn("dbo.Boards", "OrderId", c => c.Int());
            AddColumn("dbo.Boards", "Remark", c => c.String());
            AlterColumn("dbo.Users", "UserName", c => c.String());
            AlterColumn("dbo.Users", "LoginName", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Logs", "AppName", c => c.String());
            AlterColumn("dbo.Logs", "ModuleName", c => c.String());
            AlterColumn("dbo.Logs", "ActionType", c => c.String());
            AlterColumn("dbo.Logs", "Description", c => c.String());
            AlterColumn("dbo.Logs", "User", c => c.String());
            AlterColumn("dbo.Logs", "Ip", c => c.String());
            AlterColumn("dbo.Logs", "Address", c => c.String());
            AlterColumn("dbo.Logs", "Os", c => c.String());
            AlterColumn("dbo.Logs", "MachineName", c => c.String());
            AlterColumn("dbo.Logs", "MacAddress", c => c.String());
            AlterColumn("dbo.Channels", "Name", c => c.String());
            AlterColumn("dbo.Channels", "Url", c => c.String());
            AlterColumn("dbo.Channels", "Description", c => c.String());
            AlterColumn("dbo.Channels", "StyleConfigurePath", c => c.String());
            AlterColumn("dbo.Channels", "OrderId", c => c.Int());
            AlterColumn("dbo.Groups", "Name", c => c.String());
            AlterColumn("dbo.Groups", "Url", c => c.String());
            AlterColumn("dbo.Groups", "Description", c => c.String());
            AlterColumn("dbo.Groups", "OrderId", c => c.Int());
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Url", c => c.String());
            AlterColumn("dbo.Categories", "Description", c => c.String());
            AlterColumn("dbo.Categories", "OrderId", c => c.Int());
            AlterColumn("dbo.Posts", "Url", c => c.String());
            AlterColumn("dbo.Posts", "Title", c => c.String());
            AlterColumn("dbo.Posts", "Description", c => c.String());
            AlterColumn("dbo.Posts", "Password", c => c.String());
            AlterColumn("dbo.Posts", "PubIp", c => c.String());
            AlterColumn("dbo.Posts", "PubAddress", c => c.String());
            AlterColumn("dbo.Posts", "EditIp", c => c.String());
            AlterColumn("dbo.Posts", "EditAddress", c => c.String());
            AlterColumn("dbo.Tags", "Name", c => c.String());
            AlterColumn("dbo.Comments", "Content", c => c.String());
            AlterColumn("dbo.Comments", "Author", c => c.String());
            AlterColumn("dbo.Comments", "Email", c => c.String());
            AlterColumn("dbo.Comments", "Url", c => c.String());
            AlterColumn("dbo.Comments", "Ip", c => c.String());
            AlterColumn("dbo.Comments", "Address", c => c.String());
            AlterColumn("dbo.Comments", "Pic", c => c.String());
            AlterColumn("dbo.Comments", "PublicMode", c => c.String());
            AlterColumn("dbo.QrCodes", "Content", c => c.String());
            AlterColumn("dbo.QrCodes", "Url", c => c.String());
            AlterColumn("dbo.Sources", "Title", c => c.String());
            AlterColumn("dbo.Sources", "Url", c => c.String());
            AlterColumn("dbo.Thumbnails", "Title", c => c.String());
            AlterColumn("dbo.Thumbnails", "Url", c => c.String());
            AlterColumn("dbo.Boards", "Content", c => c.String());
            AlterColumn("dbo.Boards", "Author", c => c.String());
            AlterColumn("dbo.Boards", "Ip", c => c.String());
            AlterColumn("dbo.Boards", "Address", c => c.String());
            AddForeignKey("dbo.Posts", "PubAdmin_UserId", "dbo.Users", "UserId");
            AddForeignKey("dbo.Tags", "Post_PostId", "dbo.Posts", "PostId");
            CreateIndex("dbo.Posts", "PubAdmin_UserId");
            CreateIndex("dbo.Tags", "Post_PostId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Tags", new[] { "Post_PostId" });
            DropIndex("dbo.Posts", new[] { "PubAdmin_UserId" });
            DropForeignKey("dbo.Tags", "Post_PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "PubAdmin_UserId", "dbo.Users");
            AlterColumn("dbo.Boards", "Address", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Boards", "Ip", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Boards", "Author", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Boards", "Content", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Thumbnails", "Url", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Thumbnails", "Title", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Sources", "Url", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Sources", "Title", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.QrCodes", "Url", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.QrCodes", "Content", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Comments", "PublicMode", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Comments", "Pic", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Comments", "Address", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Comments", "Ip", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Comments", "Url", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Comments", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Comments", "Author", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Comments", "Content", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Tags", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Posts", "EditAddress", c => c.String(maxLength: 100));
            AlterColumn("dbo.Posts", "EditIp", c => c.String(maxLength: 100));
            AlterColumn("dbo.Posts", "PubAddress", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Posts", "PubIp", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Posts", "Password", c => c.String(maxLength: 100));
            AlterColumn("dbo.Posts", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Posts", "Url", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Categories", "OrderId", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Categories", "Url", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Groups", "OrderId", c => c.Int(nullable: false));
            AlterColumn("dbo.Groups", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Groups", "Url", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Groups", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Channels", "OrderId", c => c.Int(nullable: false));
            AlterColumn("dbo.Channels", "StyleConfigurePath", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Channels", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Channels", "Url", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Channels", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Logs", "MacAddress", c => c.String(maxLength: 100));
            AlterColumn("dbo.Logs", "MachineName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Logs", "Os", c => c.String(maxLength: 100));
            AlterColumn("dbo.Logs", "Address", c => c.String(maxLength: 100));
            AlterColumn("dbo.Logs", "Ip", c => c.String(maxLength: 100));
            AlterColumn("dbo.Logs", "User", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Logs", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Logs", "ActionType", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Logs", "ModuleName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Logs", "AppName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "LoginName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Boards", "Remark");
            DropColumn("dbo.Boards", "OrderId");
            DropColumn("dbo.Boards", "LastEditDate");
            DropColumn("dbo.Boards", "LastEditUser");
            DropColumn("dbo.Boards", "CreateUser");
            DropColumn("dbo.Thumbnails", "Remark");
            DropColumn("dbo.Thumbnails", "IsDeleted");
            DropColumn("dbo.Thumbnails", "OrderId");
            DropColumn("dbo.Thumbnails", "LastEditDate");
            DropColumn("dbo.Thumbnails", "LastEditUser");
            DropColumn("dbo.Thumbnails", "CreateDate");
            DropColumn("dbo.Thumbnails", "CreateUser");
            DropColumn("dbo.Sources", "Remark");
            DropColumn("dbo.Sources", "IsDeleted");
            DropColumn("dbo.Sources", "OrderId");
            DropColumn("dbo.Sources", "LastEditDate");
            DropColumn("dbo.Sources", "LastEditUser");
            DropColumn("dbo.Sources", "CreateDate");
            DropColumn("dbo.Sources", "CreateUser");
            DropColumn("dbo.QrCodes", "Remark");
            DropColumn("dbo.QrCodes", "IsDeleted");
            DropColumn("dbo.QrCodes", "OrderId");
            DropColumn("dbo.QrCodes", "LastEditDate");
            DropColumn("dbo.QrCodes", "LastEditUser");
            DropColumn("dbo.QrCodes", "CreateDate");
            DropColumn("dbo.QrCodes", "CreateUser");
            DropColumn("dbo.Comments", "Remark");
            DropColumn("dbo.Comments", "OrderId");
            DropColumn("dbo.Comments", "LastEditDate");
            DropColumn("dbo.Comments", "LastEditUser");
            DropColumn("dbo.Comments", "CreateUser");
            DropColumn("dbo.Tags", "Remark");
            DropColumn("dbo.Tags", "IsDeleted");
            DropColumn("dbo.Tags", "OrderId");
            DropColumn("dbo.Tags", "LastEditDate");
            DropColumn("dbo.Tags", "LastEditUser");
            DropColumn("dbo.Tags", "CreateDate");
            DropColumn("dbo.Tags", "CreateUser");
            DropColumn("dbo.Posts", "Remark");
            DropColumn("dbo.Posts", "IsDeleted");
            DropColumn("dbo.Posts", "OrderId");
            DropColumn("dbo.Posts", "LastEditDate");
            DropColumn("dbo.Posts", "LastEditUser");
            DropColumn("dbo.Posts", "CreateUser");
            DropColumn("dbo.Categories", "Remark");
            DropColumn("dbo.Categories", "LastEditDate");
            DropColumn("dbo.Categories", "LastEditUser");
            DropColumn("dbo.Categories", "CreateUser");
            DropColumn("dbo.Groups", "Remark");
            DropColumn("dbo.Groups", "LastEditDate");
            DropColumn("dbo.Groups", "LastEditUser");
            DropColumn("dbo.Groups", "CreateUser");
            DropColumn("dbo.Channels", "Remark");
            DropColumn("dbo.Channels", "LastEditDate");
            DropColumn("dbo.Channels", "LastEditUser");
            DropColumn("dbo.Channels", "CreateUser");
            DropColumn("dbo.Logs", "Remark");
            DropColumn("dbo.Logs", "IsDeleted");
            DropColumn("dbo.Logs", "OrderId");
            DropColumn("dbo.Logs", "LastEditDate");
            DropColumn("dbo.Logs", "LastEditUser");
            DropColumn("dbo.Logs", "CreateUser");
            DropColumn("dbo.Users", "Remark");
            DropColumn("dbo.Users", "OrderId");
            DropColumn("dbo.Users", "LastEditDate");
            DropColumn("dbo.Users", "LastEditUser");
            DropColumn("dbo.Users", "CreateUser");
            DropColumn("dbo.Users", "Avatar");
            RenameColumn(table: "dbo.Tags", name: "Post_PostId", newName: "PostId");
            RenameColumn(table: "dbo.Posts", name: "EditAdmin_UserId", newName: "EditAdminId");
            RenameColumn(table: "dbo.Posts", name: "PubAdmin_UserId", newName: "PubAdminId");
            CreateIndex("dbo.Tags", "PostId");
            CreateIndex("dbo.Posts", "PubAdminId");
            //AddForeignKey("dbo.Tags", "PostId", "dbo.Posts", "PostId", cascadeDelete: true);
            //AddForeignKey("dbo.Posts", "PubAdminId", "dbo.Users", "UserId", cascadeDelete: true);
        }
    }
}
