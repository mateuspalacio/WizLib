using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib_DataAccess.Migrations
{
    public partial class rawcattotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO bl_category VALUES('Cat 1')");
            migrationBuilder.Sql("INSERT INTO bl_category VALUES('Cat 2')");
            migrationBuilder.Sql("INSERT INTO bl_category VALUES('Cat 3')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
