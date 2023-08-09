using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hienv_asp.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    address_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    firstname = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    company = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    address_1 = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    address_2 = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    city = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    postcode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    country_id = table.Column<int>(type: "int", nullable: false),
                    zone_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.address_id);
                });

            migrationBuilder.CreateTable(
                name: "affiliate",
                columns: table => new
                {
                    affiliate_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    email = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    fax = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    password = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    company = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    website = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    address_1 = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    address_2 = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    city = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    postcode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    country_id = table.Column<int>(type: "int", nullable: false),
                    zone_id = table.Column<int>(type: "int", nullable: false),
                    code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    commission = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    tax = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    payment = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    cheque = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    paypal = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    bank_name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    bank_branch_number = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    bank_swift_code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    bank_account_name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    bank_account_number = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ip = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: false),
                    approved = table.Column<short>(type: "smallint", nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_affiliate", x => x.affiliate_id);
                });

            migrationBuilder.CreateTable(
                name: "affiliate_transaction",
                columns: table => new
                {
                    affiliate_transaction_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    affiliate_id = table.Column<int>(type: "int", nullable: false),
                    order_id = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(15,4)", precision: 15, scale: 4, nullable: false),
                    date_added = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_affiliate_transaction", x => x.affiliate_transaction_id);
                });

            migrationBuilder.CreateTable(
                name: "attribute",
                columns: table => new
                {
                    attribute_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    attribute_group_id = table.Column<int>(type: "int", nullable: false),
                    sort_order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attribute", x => x.attribute_id);
                });

            migrationBuilder.CreateTable(
                name: "attribute_description",
                columns: table => new
                {
                    attribute_id = table.Column<int>(type: "int", nullable: false),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attribute_description", x => new { x.attribute_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "attribute_group",
                columns: table => new
                {
                    attribute_group_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sort_order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attribute_group", x => x.attribute_group_id);
                });

            migrationBuilder.CreateTable(
                name: "attribute_group_description",
                columns: table => new
                {
                    attribute_group_id = table.Column<int>(type: "int", nullable: false),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attribute_group_description", x => new { x.attribute_group_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "banner",
                columns: table => new
                {
                    banner_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    status = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banner", x => x.banner_id);
                });

            migrationBuilder.CreateTable(
                name: "banner_image",
                columns: table => new
                {
                    banner_image_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    banner_id = table.Column<int>(type: "int", nullable: false),
                    link = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    image = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banner_image", x => x.banner_image_id);
                });

            migrationBuilder.CreateTable(
                name: "banner_image_description",
                columns: table => new
                {
                    banner_image_id = table.Column<int>(type: "int", nullable: false),
                    language_id = table.Column<int>(type: "int", nullable: false),
                    banner_id = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banner_image_description", x => new { x.banner_image_id, x.language_id });
                });

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(191)", maxLength: 191, nullable: false),
                    body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "idx_customer_id",
                table: "address",
                column: "customer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "affiliate");

            migrationBuilder.DropTable(
                name: "affiliate_transaction");

            migrationBuilder.DropTable(
                name: "attribute");

            migrationBuilder.DropTable(
                name: "attribute_description");

            migrationBuilder.DropTable(
                name: "attribute_group");

            migrationBuilder.DropTable(
                name: "attribute_group_description");

            migrationBuilder.DropTable(
                name: "banner");

            migrationBuilder.DropTable(
                name: "banner_image");

            migrationBuilder.DropTable(
                name: "banner_image_description");

            migrationBuilder.DropTable(
                name: "blogs");
        }
    }
}
