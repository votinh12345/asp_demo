using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hienv_asp.Migrations
{
    /// <inheritdoc />
    public partial class V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "oc_country",
                columns: table => new
                {
                    country_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    iso_code_2 = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    iso_code_3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    address_format = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postcode_required = table.Column<short>(type: "smallint", nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oc_country", x => x.country_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "oc_country");
        }
    }
}
