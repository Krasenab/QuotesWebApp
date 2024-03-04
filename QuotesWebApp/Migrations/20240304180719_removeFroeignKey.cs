using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuotesWebApp.Migrations
{
    /// <inheritdoc />
    public partial class removeFroeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Comment_CommentId",
                table: "Quotes");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_CommentId",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Quotes");

            migrationBuilder.AddColumn<int>(
                name: "QuotesId",
                table: "Comment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_QuotesId",
                table: "Comment",
                column: "QuotesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Quotes_QuotesId",
                table: "Comment",
                column: "QuotesId",
                principalTable: "Quotes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Quotes_QuotesId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_QuotesId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "QuotesId",
                table: "Comment");

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Quotes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_CommentId",
                table: "Quotes",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Comment_CommentId",
                table: "Quotes",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id");
        }
    }
}
