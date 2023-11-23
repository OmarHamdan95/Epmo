using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Architecture.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddAttachmentEntityandSystemMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ATTACHMENT_GROUPS",
                schema: "Architecture",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IS_ACTIVE = table.Column<bool>(type: "bit", nullable: false),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATTACHMENT_GROUPS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SYSTEM_MENUS",
                schema: "Architecture",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_ID = table.Column<long>(type: "bigint", nullable: true),
                    ICON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROUTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PERMISSION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARENT_ID = table.Column<long>(type: "bigint", nullable: true),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSTEM_MENUS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SYSTEM_MENUS_SYSTEM_MENUS_PARENT_ID",
                        column: x => x.PARENT_ID,
                        principalSchema: "Architecture",
                        principalTable: "SYSTEM_MENUS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SYSTEM_MENUS_TRANSLATIONS_NAME_ID",
                        column: x => x.NAME_ID,
                        principalSchema: "Architecture",
                        principalTable: "TRANSLATIONS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ATTACHMENTS",
                schema: "Architecture",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ATTACHMENT_GROUP_ID = table.Column<long>(type: "bigint", nullable: true),
                    FILE_KEY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FILE_SIZE = table.Column<long>(type: "bigint", nullable: true),
                    FILE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENTITY_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FILE_PATH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATTACHMENTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ATTACHMENTS_ATTACHMENT_GROUPS_ATTACHMENT_GROUP_ID",
                        column: x => x.ATTACHMENT_GROUP_ID,
                        principalSchema: "Architecture",
                        principalTable: "ATTACHMENT_GROUPS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ATTACHMENTS_ATTACHMENT_GROUP_ID",
                schema: "Architecture",
                table: "ATTACHMENTS",
                column: "ATTACHMENT_GROUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SYSTEM_MENUS_NAME_ID",
                schema: "Architecture",
                table: "SYSTEM_MENUS",
                column: "NAME_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SYSTEM_MENUS_PARENT_ID",
                schema: "Architecture",
                table: "SYSTEM_MENUS",
                column: "PARENT_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ATTACHMENTS",
                schema: "Architecture");

            migrationBuilder.DropTable(
                name: "SYSTEM_MENUS",
                schema: "Architecture");

            migrationBuilder.DropTable(
                name: "ATTACHMENT_GROUPS",
                schema: "Architecture");
        }
    }
}
