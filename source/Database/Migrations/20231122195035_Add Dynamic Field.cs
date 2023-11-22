using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Architecture.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddDynamicField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRANSLATION_VALUES_LANGUAGES_LANGUAGE_ID",
                schema: "Architecture",
                table: "TRANSLATION_VALUES");

            migrationBuilder.DropIndex(
                name: "IX_TRANSLATION_VALUES_LANGUAGE_ID",
                schema: "Architecture",
                table: "TRANSLATION_VALUES");

            migrationBuilder.DropColumn(
                name: "LOOKUP_CODE",
                schema: "Architecture",
                table: "LOOKUPS");

            migrationBuilder.DropColumn(
                name: "LOOKUP_VALUE_CODE",
                schema: "Architecture",
                table: "LOOKUP_VALUES");

            migrationBuilder.CreateTable(
                name: "DYNAMIC_FIELDS",
                schema: "Architecture",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_ID = table.Column<long>(type: "bigint", nullable: true),
                    ENTITY_TYPE_ID = table.Column<long>(type: "bigint", nullable: true),
                    DYNAMIC_FIELD_TYPE_ID = table.Column<long>(type: "bigint", nullable: true),
                    DYNAMIC_FIELD_REGEX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DYNAMIC_FIELD_MIN_VALUE = table.Column<long>(type: "bigint", nullable: true),
                    DYNAMIC_FIELD_MAX_VALUE = table.Column<long>(type: "bigint", nullable: true),
                    DYNAMIC_FIELD_LOOKUP_TYPE_ID = table.Column<long>(type: "bigint", nullable: true),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DYNAMIC_FIELDS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DYNAMIC_FIELDS_LOOKUP_VALUES_DYNAMIC_FIELD_LOOKUP_TYPE_ID",
                        column: x => x.DYNAMIC_FIELD_LOOKUP_TYPE_ID,
                        principalSchema: "Architecture",
                        principalTable: "LOOKUP_VALUES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DYNAMIC_FIELDS_LOOKUP_VALUES_DYNAMIC_FIELD_TYPE_ID",
                        column: x => x.DYNAMIC_FIELD_TYPE_ID,
                        principalSchema: "Architecture",
                        principalTable: "LOOKUP_VALUES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DYNAMIC_FIELDS_LOOKUP_VALUES_ENTITY_TYPE_ID",
                        column: x => x.ENTITY_TYPE_ID,
                        principalSchema: "Architecture",
                        principalTable: "LOOKUP_VALUES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DYNAMIC_FIELDS_TRANSLATIONS_NAME_ID",
                        column: x => x.NAME_ID,
                        principalSchema: "Architecture",
                        principalTable: "TRANSLATIONS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DYNAMIC_FIELDS_DYNAMIC_FIELD_LOOKUP_TYPE_ID",
                schema: "Architecture",
                table: "DYNAMIC_FIELDS",
                column: "DYNAMIC_FIELD_LOOKUP_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DYNAMIC_FIELDS_DYNAMIC_FIELD_TYPE_ID",
                schema: "Architecture",
                table: "DYNAMIC_FIELDS",
                column: "DYNAMIC_FIELD_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DYNAMIC_FIELDS_ENTITY_TYPE_ID",
                schema: "Architecture",
                table: "DYNAMIC_FIELDS",
                column: "ENTITY_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DYNAMIC_FIELDS_NAME_ID",
                schema: "Architecture",
                table: "DYNAMIC_FIELDS",
                column: "NAME_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DYNAMIC_FIELDS",
                schema: "Architecture");

            migrationBuilder.AddColumn<string>(
                name: "LOOKUP_CODE",
                schema: "Architecture",
                table: "LOOKUPS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LOOKUP_VALUE_CODE",
                schema: "Architecture",
                table: "LOOKUP_VALUES",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TRANSLATION_VALUES_LANGUAGE_ID",
                schema: "Architecture",
                table: "TRANSLATION_VALUES",
                column: "LANGUAGE_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TRANSLATION_VALUES_LANGUAGES_LANGUAGE_ID",
                schema: "Architecture",
                table: "TRANSLATION_VALUES",
                column: "LANGUAGE_ID",
                principalSchema: "Architecture",
                principalTable: "LANGUAGES",
                principalColumn: "ID");
        }
    }
}
