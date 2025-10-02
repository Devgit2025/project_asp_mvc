using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_asp.Migrations
{
    /// <inheritdoc />
    public partial class addAdminDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Admin",
                columns: table => new
                {
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admin_Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admin_Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Admin", x => x.Admin_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Admin");
        }
    }
}
