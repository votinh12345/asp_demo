using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hienv_asp.Migrations
{
    /// <inheritdoc />
    public partial class V5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "oc_currency",
                columns: table => new
                {
                    currency_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    symbol_left = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    symbol_right = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    decimal_place = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    value = table.Column<decimal>(type: "decimal(15,8)", precision: 15, scale: 8, nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: false),
                    date_modified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_currency", x => x.currency_id);
                });

            migrationBuilder.CreateTable(
                name: "oc_language",
                columns: table => new
                {
                    language_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    code = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    locale = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    image = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    directory = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    filename = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    sort_order = table.Column<short>(type: "smallint", nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_language", x => x.language_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "oc_currency");

            migrationBuilder.DropTable(
                name: "oc_language");
        }
    }
}
