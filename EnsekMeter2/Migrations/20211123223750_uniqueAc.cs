using Microsoft.EntityFrameworkCore.Migrations;

namespace EnsekMeter2.Migrations
{
    public partial class uniqueAc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Account_AccountId",
                table: "Account",
                column: "AccountId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Account_AccountId",
                table: "Account");
        }
    }
}
