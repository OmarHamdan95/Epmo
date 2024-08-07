﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Epmo.Database.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EPMO");

            migrationBuilder.CreateTable(
                name: "ATTACHMENT_GROUPS",
                schema: "EPMO",
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
                name: "DYNAMIC_FIELDS",
                schema: "EPMO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "EXAMPLES",
                schema: "EPMO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EXAMPLES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LANGUAGES",
                schema: "EPMO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LANG_FLAG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VALID_FROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VALID_TO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LANGUAGES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LOOKUPS",
                schema: "EPMO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PARENT_ID = table.Column<long>(type: "bigint", nullable: true),
                    LINKS = table.Column<long>(type: "bigint", nullable: true),
                    IS_SYSTEM = table.Column<bool>(type: "bit", nullable: false),
                    DATA_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VALID_FROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VALID_TO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TRANSLATION = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUPS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LOOKUPS_LOOKUPS_PARENT_ID",
                        column: x => x.PARENT_ID,
                        principalSchema: "EPMO",
                        principalTable: "LOOKUPS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SYSTEM_MENUS",
                schema: "EPMO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalSchema: "EPMO",
                        principalTable: "SYSTEM_MENUS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TRANSLATIONS",
                schema: "EPMO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSLATIONS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USERS",
                schema: "EPMO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ATTACHMENTS",
                schema: "EPMO",
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
                        principalSchema: "EPMO",
                        principalTable: "ATTACHMENT_GROUPS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "LOOKUP_VALUES",
                schema: "EPMO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOOKUP_ID = table.Column<long>(type: "bigint", nullable: true),
                    PARENT_ID = table.Column<long>(type: "bigint", nullable: true),
                    ORDER = table.Column<long>(type: "bigint", nullable: true),
                    IS_SYSTEM = table.Column<bool>(type: "bit", nullable: false),
                    COLOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VALID_FROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VALID_TO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TRANSLATION = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUP_VALUES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LOOKUP_VALUES_LOOKUPS_LOOKUP_ID",
                        column: x => x.LOOKUP_ID,
                        principalSchema: "EPMO",
                        principalTable: "LOOKUPS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_LOOKUP_VALUES_LOOKUP_VALUES_PARENT_ID",
                        column: x => x.PARENT_ID,
                        principalSchema: "EPMO",
                        principalTable: "LOOKUP_VALUES",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TRANSLATION_VALUES",
                schema: "EPMO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRANSLATION_ID = table.Column<long>(type: "bigint", nullable: true),
                    TRANSALTION_VALUE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LANGUAGE_ID = table.Column<long>(type: "bigint", nullable: true),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSLATION_VALUES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TRANSLATION_VALUES_LANGUAGES_LANGUAGE_ID",
                        column: x => x.LANGUAGE_ID,
                        principalSchema: "EPMO",
                        principalTable: "LANGUAGES",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TRANSLATION_VALUES_TRANSLATIONS_TRANSLATION_ID",
                        column: x => x.TRANSLATION_ID,
                        principalSchema: "EPMO",
                        principalTable: "TRANSLATIONS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AUTHS",
                schema: "EPMO",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOGIN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PASSWORD = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SALT = table.Column<Guid>(type: "uniqueidentifier", maxLength: 1000, nullable: false),
                    ROLES = table.Column<int>(type: "int", nullable: false),
                    USER_ID = table.Column<long>(type: "bigint", nullable: false),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MODIFIED_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUTHS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AUTHS_USERS_USER_ID",
                        column: x => x.USER_ID,
                        principalSchema: "EPMO",
                        principalTable: "USERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "EPMO",
                table: "USERS",
                columns: new[] { "ID", "CODE", "CREATED_BY", "CREATED_DATE", "EMAIL", "IS_DELETED", "MODIFIED_BY", "MODIFIED_DATE", "NAME", "STATUS" },
                values: new object[] { 1L, null, null, null, "administrator@administrator.com", false, null, null, "Administrator", 1 });

            migrationBuilder.InsertData(
                schema: "EPMO",
                table: "AUTHS",
                columns: new[] { "ID", "CODE", "CREATED_BY", "CREATED_DATE", "IS_DELETED", "LOGIN", "MODIFIED_BY", "MODIFIED_DATE", "PASSWORD", "ROLES", "SALT", "USER_ID" },
                values: new object[] { 1L, null, null, null, false, "admin", null, null, "O34uMN1Vho2IYcSM7nlXEqn57RZ8VEUsJwH++sFr0i3MSHJVx8J3PQGjhLR3s5i4l0XWUnCnymQ/EbRmzvLy8uMWREZu7vZI+BqebjAl5upYKMMQvlEcBeyLcRRTTBpYpv80m/YCZQmpig4XFVfIViLLZY/Kr5gBN5dkQf25rK+u88gtSXAyPDkW+hVS+dW4AmxrnaNFZks0Zzcd5xlb12wcF/q96cc4htHFzvOH9jtN98N5EBIXSvdUVnFc9kBuRTVytATZA7gITbs//hkxvNQ3eody5U9hjdH6D+AP0vVt5unZlTZ+gInn8Ze7AC5o6mn0Y3ylGO1CBJSHU9c/BcFY9oknn+XYk9ySCoDGctMqDbvOBcvSTBkKcrCzev2KnX7xYmC3yNz1Q5oPVKgnq4mc1iuldMlCxse/IDGMJB2FRdTCLV5KNS4IZ1GB+dw3tMvcEEtmXmgT2zKN5+kUkOxhlv5g1ZLgXzWjVJeKb5uZpsn3WK5kt8T+kzMoxHd5i8HxsU2uvy9GopxAnaV0WNsBPqTGkRllSxARl4ZN3hJqUla553RT49tJxbs+N03OmkYhjq+L0aKJ1AC+7G+rdjegiAQZB+3mdE7a2Pne2kYtpMoCmNMKdm9jOOVpfXJqZMQul9ltJSlAY6LPrHFUB3mw61JBNzx+sZgYN29GfDY=", 3, new Guid("79005744-e69a-4b09-996b-08fe0b70cbb9"), 1L });

            migrationBuilder.CreateIndex(
                name: "IX_ATTACHMENTS_ATTACHMENT_GROUP_ID",
                schema: "EPMO",
                table: "ATTACHMENTS",
                column: "ATTACHMENT_GROUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AUTHS_LOGIN",
                schema: "EPMO",
                table: "AUTHS",
                column: "LOGIN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AUTHS_SALT",
                schema: "EPMO",
                table: "AUTHS",
                column: "SALT",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AUTHS_USER_ID",
                schema: "EPMO",
                table: "AUTHS",
                column: "USER_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LOOKUP_VALUES_LOOKUP_ID",
                schema: "EPMO",
                table: "LOOKUP_VALUES",
                column: "LOOKUP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LOOKUP_VALUES_PARENT_ID",
                schema: "EPMO",
                table: "LOOKUP_VALUES",
                column: "PARENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LOOKUPS_PARENT_ID",
                schema: "EPMO",
                table: "LOOKUPS",
                column: "PARENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SYSTEM_MENUS_PARENT_ID",
                schema: "EPMO",
                table: "SYSTEM_MENUS",
                column: "PARENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TRANSLATION_VALUES_LANGUAGE_ID",
                schema: "EPMO",
                table: "TRANSLATION_VALUES",
                column: "LANGUAGE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TRANSLATION_VALUES_TRANSLATION_ID",
                schema: "EPMO",
                table: "TRANSLATION_VALUES",
                column: "TRANSLATION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USERS_EMAIL",
                schema: "EPMO",
                table: "USERS",
                column: "EMAIL",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ATTACHMENTS",
                schema: "EPMO");

            migrationBuilder.DropTable(
                name: "AUTHS",
                schema: "EPMO");

            migrationBuilder.DropTable(
                name: "DYNAMIC_FIELDS",
                schema: "EPMO");

            migrationBuilder.DropTable(
                name: "EXAMPLES",
                schema: "EPMO");

            migrationBuilder.DropTable(
                name: "LOOKUP_VALUES",
                schema: "EPMO");

            migrationBuilder.DropTable(
                name: "SYSTEM_MENUS",
                schema: "EPMO");

            migrationBuilder.DropTable(
                name: "TRANSLATION_VALUES",
                schema: "EPMO");

            migrationBuilder.DropTable(
                name: "ATTACHMENT_GROUPS",
                schema: "EPMO");

            migrationBuilder.DropTable(
                name: "USERS",
                schema: "EPMO");

            migrationBuilder.DropTable(
                name: "LOOKUPS",
                schema: "EPMO");

            migrationBuilder.DropTable(
                name: "LANGUAGES",
                schema: "EPMO");

            migrationBuilder.DropTable(
                name: "TRANSLATIONS",
                schema: "EPMO");
        }
    }
}
