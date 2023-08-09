using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hienv_asp.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    parent_id = table.Column<int>(type: "int", nullable: false),
                    top = table.Column<int>(type: "int", nullable: false),
                    column = table.Column<int>(type: "int", nullable: false),
                    sort_order = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<short>(type: "smallint", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: true),
                    date_modified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "category_description",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    meta_description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    meta_keyword = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_description", x => new { x.category_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "category_to_layout",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false),
                    store_id = table.Column<int>(type: "int", nullable: false),
                    layout_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_to_layout", x => new { x.category_id, x.store_id });
                });

            migrationBuilder.CreateTable(
                name: "category_to_store",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false),
                    store_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_to_store", x => new { x.category_id, x.store_id });
                });

            migrationBuilder.CreateIndex(
                name: "idx_categories_name_zen",
                table: "category_description",
                column: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "category_description");

            migrationBuilder.DropTable(
                name: "category_to_layout");

            migrationBuilder.DropTable(
                name: "category_to_store");
        }
    }
}
