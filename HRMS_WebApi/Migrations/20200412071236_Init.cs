using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRMS_WebApi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<string>(type: "varchar(4)", nullable: false),
                    MenuGroup = table.Column<string>(type: "varchar(2)", nullable: true),
                    MenuNameEng = table.Column<string>(type: "varchar(100)", nullable: true),
                    MenuNameTh = table.Column<string>(type: "varchar(100)", nullable: true),
                    ControllerID = table.Column<string>(type: "varchar(200)", nullable: true),
                    CreateBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    UpdateBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "SYSDATETIME()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "varchar(2)", nullable: false),
                    RoleName = table.Column<string>(type: "nchar(10)", nullable: true),
                    CreateBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    UpdateBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "SYSDATETIME()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    SiteId = table.Column<string>(type: "varchar(3)", nullable: false),
                    SiteName = table.Column<string>(type: "varchar(200)", nullable: true),
                    BillDay = table.Column<byte>(type: "tinyint", nullable: false),
                    CustomerCode = table.Column<string>(type: "varchar(200)", nullable: true),
                    WelcomeMessage = table.Column<string>(type: "varchar(1000)", nullable: true),
                    WarningMessage = table.Column<string>(type: "varchar(500)", nullable: true),
                    WarningTimes = table.Column<string>(type: "varchar(30)", nullable: true),
                    ExtendTime = table.Column<byte>(type: "tinyint", nullable: false),
                    LoginLockTimes = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.SiteId);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenu",
                columns: table => new
                {
                    RoleId = table.Column<string>(nullable: false),
                    MenuId = table.Column<string>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    UpdateBy = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "SYSDATETIME()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenu", x => new { x.RoleId, x.MenuId });
                    table.ForeignKey(
                        name: "FK_RoleMenu_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleMenu_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenu_MenuId",
                table: "RoleMenu",
                column: "MenuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleMenu");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
