using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hienv_asp.Migrations
{
    /// <inheritdoc />
    public partial class V6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "oc_language",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "filename",
                table: "oc_language",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "directory",
                table: "oc_language",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.CreateTable(
                name: "oc_length_class",
                columns: table => new
                {
                    length_class_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<decimal>(type: "decimal(15,8)", precision: 15, scale: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_length_class", x => x.length_class_id);
                });

            migrationBuilder.CreateTable(
                name: "oc_length_class_description",
                columns: table => new
                {
                    length_class_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    unit = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_length_class_description", x => new { x.length_class_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "oc_order_status",
                columns: table => new
                {
                    order_status_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_order_status", x => new { x.order_status_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "oc_return_action",
                columns: table => new
                {
                    return_action_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_return_action", x => new { x.return_action_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "oc_return_reason",
                columns: table => new
                {
                    return_action_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_return_reason", x => new { x.return_action_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "oc_return_status",
                columns: table => new
                {
                    return_status_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_return_status", x => new { x.return_status_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "oc_stock_status",
                columns: table => new
                {
                    stock_status_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_stock_status", x => new { x.stock_status_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "oc_store",
                columns: table => new
                {
                    store_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ssl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_store", x => x.store_id);
                });

            migrationBuilder.CreateTable(
                name: "oc_user",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_group_id = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    firstname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    code = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    ip = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_user", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "oc_user_group",
                columns: table => new
                {
                    user_group_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    permission = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_user_group", x => x.user_group_id);
                });

            migrationBuilder.CreateTable(
                name: "oc_weight_class",
                columns: table => new
                {
                    weight_class_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<decimal>(type: "decimal(15,8)", precision: 15, scale: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_weight_class", x => x.weight_class_id);
                });

            migrationBuilder.CreateTable(
                name: "oc_weight_class_description",
                columns: table => new
                {
                    weight_class_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    unit = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_weight_class_description", x => new { x.weight_class_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "oc_zone_to_geo_zone",
                columns: table => new
                {
                    zone_to_geo_zone_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    country_id = table.Column<int>(type: "int", nullable: false),
                    zone_id = table.Column<int>(type: "int", nullable: false),
                    geo_zone_id = table.Column<int>(type: "int", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: true),
                    date_modified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_zone_to_geo_zone", x => x.zone_to_geo_zone_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "oc_length_class");

            migrationBuilder.DropTable(
                name: "oc_length_class_description");

            migrationBuilder.DropTable(
                name: "oc_order_status");

            migrationBuilder.DropTable(
                name: "oc_return_action");

            migrationBuilder.DropTable(
                name: "oc_return_reason");

            migrationBuilder.DropTable(
                name: "oc_return_status");

            migrationBuilder.DropTable(
                name: "oc_stock_status");

            migrationBuilder.DropTable(
                name: "oc_store");

            migrationBuilder.DropTable(
                name: "oc_user");

            migrationBuilder.DropTable(
                name: "oc_user_group");

            migrationBuilder.DropTable(
                name: "oc_weight_class");

            migrationBuilder.DropTable(
                name: "oc_weight_class_description");

            migrationBuilder.DropTable(
                name: "oc_zone_to_geo_zone");

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "oc_language",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "filename",
                table: "oc_language",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "directory",
                table: "oc_language",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldNullable: true);
        }
    }
}
