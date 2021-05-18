using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddMembershipFKtoCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Membership_Code",
                table: "T_Customer",
                type: "varchar(6)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Customer_Membership_Code",
                table: "T_Customer",
                column: "Membership_Code");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Customer_T_Membership_Membership_Code",
                table: "T_Customer",
                column: "Membership_Code",
                principalTable: "T_Membership",
                principalColumn: "Membership_Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Customer_T_Membership_Membership_Code",
                table: "T_Customer");

            migrationBuilder.DropIndex(
                name: "IX_T_Customer_Membership_Code",
                table: "T_Customer");

            migrationBuilder.DropColumn(
                name: "Membership_Code",
                table: "T_Customer");
        }
    }
}
