using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Application : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a47e1356-c2b3-4f40-ba01-be10bf9524ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e10997bf-51f9-4a0c-8f0f-47a1f400726f"));

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "CarState",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ModelYear",
                table: "Cars",
                newName: "ModelYearr");

            migrationBuilder.AlterColumn<decimal>(
                name: "DailyPrice",
                table: "Models",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<short>(
                name: "ModelYearr",
                table: "Cars",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Plate",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("cf975797-36fc-45db-b320-518dbb57a8ef"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 78, 12, 190, 125, 115, 27, 210, 134, 201, 10, 134, 245, 184, 45, 40, 163, 49, 132, 98, 49, 215, 42, 231, 163, 135, 14, 174, 42, 93, 75, 212, 125, 185, 24, 150, 11, 239, 34, 185, 3, 191, 191, 219, 134, 238, 125, 220, 64, 182, 144, 24, 160, 102, 216, 45, 254, 64, 191, 21, 54, 206, 112, 179, 84 }, new byte[] { 217, 243, 241, 52, 145, 249, 252, 137, 215, 171, 138, 29, 76, 69, 244, 166, 75, 112, 160, 32, 198, 208, 156, 221, 176, 102, 113, 49, 133, 218, 13, 231, 194, 97, 32, 217, 245, 82, 99, 95, 206, 14, 82, 226, 17, 37, 255, 19, 45, 60, 146, 101, 131, 222, 101, 218, 13, 168, 144, 249, 7, 138, 130, 127, 16, 65, 91, 152, 226, 160, 161, 30, 79, 197, 187, 95, 218, 112, 110, 206, 31, 184, 240, 245, 92, 212, 138, 13, 74, 116, 92, 244, 242, 239, 2, 24, 125, 169, 38, 215, 104, 92, 247, 205, 34, 101, 16, 133, 245, 189, 201, 90, 67, 92, 178, 129, 216, 198, 71, 51, 41, 160, 171, 182, 123, 183, 174, 231 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c90d05ae-3f25-4715-9089-acf5e79a492d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("cf975797-36fc-45db-b320-518dbb57a8ef") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c90d05ae-3f25-4715-9089-acf5e79a492d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf975797-36fc-45db-b320-518dbb57a8ef"));

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Plate",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ModelYearr",
                table: "Cars",
                newName: "ModelYear");

            migrationBuilder.AlterColumn<double>(
                name: "DailyPrice",
                table: "Models",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<short>(
                name: "Year",
                table: "Models",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AlterColumn<int>(
                name: "ModelYear",
                table: "Cars",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<int>(
                name: "CarState",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ColorId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("e10997bf-51f9-4a0c-8f0f-47a1f400726f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 202, 20, 194, 69, 209, 185, 65, 86, 95, 14, 33, 230, 136, 86, 226, 156, 96, 238, 48, 172, 224, 21, 81, 213, 167, 232, 5, 46, 12, 68, 30, 192, 27, 196, 77, 7, 53, 79, 182, 128, 180, 149, 134, 48, 94, 140, 228, 2, 42, 72, 111, 149, 149, 211, 168, 59, 173, 7, 25, 131, 219, 183, 214, 177 }, new byte[] { 244, 10, 74, 194, 171, 255, 241, 200, 134, 194, 194, 221, 165, 65, 108, 176, 107, 84, 164, 29, 174, 4, 1, 67, 214, 154, 161, 221, 143, 201, 123, 106, 64, 131, 203, 52, 177, 124, 109, 175, 247, 86, 27, 253, 51, 78, 155, 238, 209, 39, 110, 87, 24, 171, 23, 123, 254, 113, 13, 51, 238, 28, 77, 201, 158, 186, 96, 242, 119, 180, 79, 208, 50, 134, 67, 35, 235, 44, 29, 139, 209, 114, 64, 22, 187, 186, 99, 205, 35, 101, 149, 252, 40, 126, 16, 97, 171, 188, 229, 63, 152, 131, 172, 170, 156, 204, 19, 74, 108, 72, 191, 25, 65, 180, 147, 47, 116, 251, 30, 72, 179, 0, 188, 9, 183, 102, 146, 111 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("a47e1356-c2b3-4f40-ba01-be10bf9524ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("e10997bf-51f9-4a0c-8f0f-47a1f400726f") });
        }
    }
}
