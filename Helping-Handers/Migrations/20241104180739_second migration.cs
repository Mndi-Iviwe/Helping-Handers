using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Helping_Handers.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "helping_Users");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "helping_Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "helping_Users",
                newName: "user_password");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "helping_Users",
                newName: "user_lastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "helping_Users",
                newName: "user_firstName");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "helping_Users",
                newName: "user_age");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "helping_Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "user_email",
                table: "helping_Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user_email",
                table: "helping_Users");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "helping_Users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "user_password",
                table: "helping_Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "user_lastName",
                table: "helping_Users",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "user_firstName",
                table: "helping_Users",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "user_age",
                table: "helping_Users",
                newName: "age");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "helping_Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "helping_Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
