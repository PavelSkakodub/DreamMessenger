using Microsoft.EntityFrameworkCore.Migrations;

namespace DreamMessenger.Migrations
{
    public partial class AddBlockedForever : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBlockedForever",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBlockedForever",
                table: "AspNetUsers");
        }
    }
}
