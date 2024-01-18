using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi2.Migrations
{
    /// <inheritdoc />
    public partial class RentalMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "propRents",
                columns: table => new
                {
                    PropId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthlyRental = table.Column<int>(type: "int", nullable: false),
                    Tenure = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propRents", x => x.PropId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "propRents");
        }
    }
}
