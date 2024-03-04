using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class app : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c90d05ae-3f25-4715-9089-acf5e79a492d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf975797-36fc-45db-b320-518dbb57a8ef"));

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cars",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "Kilometer",
                table: "Cars",
                newName: "Km");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Cars",
                newName: "Renk");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("a2d06ab6-a785-4d57-92db-1fab3385e51d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 238, 115, 210, 13, 178, 235, 207, 210, 223, 13, 237, 110, 62, 213, 22, 28, 63, 6, 229, 151, 112, 69, 93, 8, 161, 37, 176, 42, 169, 24, 3, 56, 162, 52, 157, 41, 64, 115, 31, 155, 216, 241, 121, 57, 96, 94, 159, 65, 253, 223, 181, 136, 202, 91, 86, 194, 230, 171, 49, 148, 236, 103, 28, 49 }, new byte[] { 48, 14, 184, 59, 8, 23, 188, 91, 255, 20, 30, 239, 250, 6, 178, 212, 158, 14, 15, 162, 101, 195, 235, 206, 143, 100, 133, 116, 116, 128, 56, 170, 250, 152, 61, 95, 244, 188, 203, 243, 106, 173, 3, 138, 31, 127, 238, 124, 191, 132, 216, 121, 214, 18, 208, 98, 143, 20, 159, 38, 5, 223, 43, 197, 23, 84, 66, 44, 219, 159, 51, 54, 153, 189, 42, 202, 90, 234, 121, 223, 74, 137, 220, 210, 232, 219, 160, 47, 109, 21, 131, 189, 116, 212, 198, 62, 97, 74, 158, 134, 168, 180, 106, 139, 72, 219, 39, 224, 47, 143, 18, 126, 244, 10, 112, 137, 212, 216, 251, 19, 41, 75, 243, 72, 184, 31, 63, 176 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("645af0af-3598-4175-8507-7358e01e3d68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("a2d06ab6-a785-4d57-92db-1fab3385e51d") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("645af0af-3598-4175-8507-7358e01e3d68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2d06ab6-a785-4d57-92db-1fab3385e51d"));

            migrationBuilder.RenameColumn(
                name: "Renk",
                table: "Cars",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "Km",
                table: "Cars",
                newName: "Kilometer");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "Cars",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("cf975797-36fc-45db-b320-518dbb57a8ef"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 78, 12, 190, 125, 115, 27, 210, 134, 201, 10, 134, 245, 184, 45, 40, 163, 49, 132, 98, 49, 215, 42, 231, 163, 135, 14, 174, 42, 93, 75, 212, 125, 185, 24, 150, 11, 239, 34, 185, 3, 191, 191, 219, 134, 238, 125, 220, 64, 182, 144, 24, 160, 102, 216, 45, 254, 64, 191, 21, 54, 206, 112, 179, 84 }, new byte[] { 217, 243, 241, 52, 145, 249, 252, 137, 215, 171, 138, 29, 76, 69, 244, 166, 75, 112, 160, 32, 198, 208, 156, 221, 176, 102, 113, 49, 133, 218, 13, 231, 194, 97, 32, 217, 245, 82, 99, 95, 206, 14, 82, 226, 17, 37, 255, 19, 45, 60, 146, 101, 131, 222, 101, 218, 13, 168, 144, 249, 7, 138, 130, 127, 16, 65, 91, 152, 226, 160, 161, 30, 79, 197, 187, 95, 218, 112, 110, 206, 31, 184, 240, 245, 92, 212, 138, 13, 74, 116, 92, 244, 242, 239, 2, 24, 125, 169, 38, 215, 104, 92, 247, 205, 34, 101, 16, 133, 245, 189, 201, 90, 67, 92, 178, 129, 216, 198, 71, 51, 41, 160, 171, 182, 123, 183, 174, 231 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c90d05ae-3f25-4715-9089-acf5e79a492d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("cf975797-36fc-45db-b320-518dbb57a8ef") });
        }
    }
}
