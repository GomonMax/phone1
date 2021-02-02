using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Telephone.DAL.Migrations
{
    public partial class addtabletoDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblTelBookPersons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    SecondName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Gender = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTelBookPersons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblTelBookPersons");
        }
    }
}
