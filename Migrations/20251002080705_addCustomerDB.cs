using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_asp.Migrations
{
    /// <inheritdoc />
    public partial class addCustomerDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Customers",
                columns: table => new
                {
                    Cus_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cus_Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Customers", x => x.Cus_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Customers");
        }
    }
}
