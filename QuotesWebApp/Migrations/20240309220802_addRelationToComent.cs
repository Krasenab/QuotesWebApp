using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuotesWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addRelationToComent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Quotes_QuotesId",
                table: "Comment");

            migrationBuilder.AlterColumn<int>(
                name: "QuotesId",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Quotes_QuotesId",
                table: "Comment",
                column: "QuotesId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Quotes_QuotesId",
                table: "Comment");

            migrationBuilder.AlterColumn<int>(
                name: "QuotesId",
                table: "Comment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Quotes_QuotesId",
                table: "Comment",
                column: "QuotesId",
                principalTable: "Quotes",
                principalColumn: "Id");
        }
    }
}
