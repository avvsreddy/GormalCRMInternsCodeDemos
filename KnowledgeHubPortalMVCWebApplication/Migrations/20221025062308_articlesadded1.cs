using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnowledgeHubPortalMVCWebApplication.Migrations
{
    public partial class articlesadded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Catagory",
                table: "Articles");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CatagoryID",
                table: "Articles",
                column: "CatagoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Catagories_CatagoryID",
                table: "Articles",
                column: "CatagoryID",
                principalTable: "Catagories",
                principalColumn: "CatagoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Catagories_CatagoryID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CatagoryID",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "Catagory",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
