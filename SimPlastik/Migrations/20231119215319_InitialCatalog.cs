using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimPlastik.Migrations
{
    public partial class InitialCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    about_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    about_text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_eng_text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_ar_text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.about_id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    contact_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    other_number_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    other_number_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    other_number_1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.contact_id);
                });

            migrationBuilder.CreateTable(
                name: "TopCategory",
                columns: table => new
                {
                    top_category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    top_category_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    top_category_name_en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    top_category_name_ar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopCategory", x => x.top_category_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_admin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name_en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category_name_ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    topCategorytop_category_id = table.Column<int>(type: "int", nullable: false),
                    top_category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_id);
                    table.ForeignKey(
                        name: "FK_Categories_TopCategory_topCategorytop_category_id",
                        column: x => x.topCategorytop_category_id,
                        principalTable: "TopCategory",
                        principalColumn: "top_category_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_name_en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_name_ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_desc_en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_desc_ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_info_piece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_info_box_weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_info_box_measurement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_info_shipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_info_shipment_en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_info_shipment_ar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_img_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_img_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_img_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_img_1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category_id1 = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_category_id1",
                        column: x => x.category_id1,
                        principalTable: "Categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_topCategorytop_category_id",
                table: "Categories",
                column: "topCategorytop_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_category_id1",
                table: "Products",
                column: "category_id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TopCategory");
        }
    }
}
