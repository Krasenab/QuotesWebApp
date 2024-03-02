using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuotesWebApp.Migrations
{
    /// <inheritdoc />
    public partial class changeValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Comment_CommentId",
                table: "Quotes");

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "Quotes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Comment_CommentId",
                table: "Quotes",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Comment_CommentId",
                table: "Quotes");

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "Quotes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Comment_CommentId",
                table: "Quotes",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
