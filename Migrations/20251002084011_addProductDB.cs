using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_asp.Migrations
{
    /// <inheritdoc />
    public partial class addProductDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Product",
                columns: table => new
                {
                    Pro_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pro_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pro_Price = table.Column<int>(type: "int", nullable: false),
                    Pro_Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pro_Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pro_Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Product", x => x.Pro_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Product");
        }
    }
}
