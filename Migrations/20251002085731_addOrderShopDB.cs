using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_asp.Migrations
{
    /// <inheritdoc />
    public partial class addOrderShopDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_OrderShop",
                columns: table => new
                {
                    Order_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Price_Total = table.Column<int>(type: "int", nullable: false),
                    Order_Cus_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_OrderShop", x => x.Order_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_OrderShop");
        }
    }
}
