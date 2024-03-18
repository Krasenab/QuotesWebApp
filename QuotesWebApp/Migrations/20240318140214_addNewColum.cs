using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuotesWebApp.Migrations
{
    /// <inheritdoc />
    public partial class addNewColum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PeopleReatingCount",
                table: "Authors",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeopleReatingCount",
                table: "Authors");
        }
    }
}
