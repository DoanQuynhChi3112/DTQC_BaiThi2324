using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DTQC_BaiThi2324.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_DTQC114Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DTQC114Person",
                columns: table => new
                {
                    DTQC114PersonID = table.Column<string>(type: "TEXT", nullable: false),
                    DTQC114Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DTQC114Ngaysinh = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTQC114Person", x => x.DTQC114PersonID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DTQC114Person");
        }
    }
}
