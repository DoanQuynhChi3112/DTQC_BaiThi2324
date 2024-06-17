using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTQC_BaiThi2324.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_DTQC114Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DTQC114Employee",
                columns: table => new
                {
                    DTQC114PersonID = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTQC114Employee", x => x.DTQC114PersonID);
                    table.ForeignKey(
                        name: "FK_DTQC114Employee_DTQC114Person_DTQC114PersonID",
                        column: x => x.DTQC114PersonID,
                        principalTable: "DTQC114Person",
                        principalColumn: "DTQC114PersonID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DTQC114Employee");
        }
    }
}
