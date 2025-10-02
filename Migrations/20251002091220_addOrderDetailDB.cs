using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_asp.Migrations
{
    /// <inheritdoc />
    public partial class addOrderDetailDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_OrderDetail",
                columns: table => new
                {
                    Order_Id_Detail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Id = table.Column<int>(type: "int", nullable: false),
                    Pro_Id = table.Column<int>(type: "int", nullable: false),
                    Pro_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pro_Price = table.Column<int>(type: "int", nullable: false),
                    Order_Quantity = table.Column<int>(type: "int", nullable: false),
                    Order_Price_Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_OrderDetail", x => x.Order_Id_Detail);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_OrderDetail");
        }
    }
}
