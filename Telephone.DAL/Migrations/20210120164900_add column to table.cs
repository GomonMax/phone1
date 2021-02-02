using Microsoft.EntityFrameworkCore.Migrations;

namespace Telephone.DAL.Migrations
{
    public partial class addcolumntotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "telNummer",
                table: "tblTelBookPersons",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "telNummer",
                table: "tblTelBookPersons");
        }
    }
}
