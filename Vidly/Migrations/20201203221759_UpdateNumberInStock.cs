using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class UpdateNumberInStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE INTO Movies (NumberInStock) (20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
