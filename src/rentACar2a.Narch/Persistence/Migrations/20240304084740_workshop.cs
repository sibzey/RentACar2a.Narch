using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class workshop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c7774692-79c5-4922-889d-2d43d6ff5c2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("104b6e62-9925-439a-b384-bbd1bb7c7972"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("d0bc16a0-1264-44bc-b11e-0992d6cfd718"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 178, 84, 28, 85, 89, 9, 54, 35, 219, 185, 127, 229, 67, 167, 44, 200, 29, 201, 39, 173, 225, 165, 243, 3, 20, 52, 95, 244, 185, 120, 84, 48, 235, 2, 132, 7, 51, 36, 249, 134, 2, 55, 165, 231, 2, 178, 179, 67, 101, 136, 140, 115, 67, 109, 249, 81, 167, 48, 178, 43, 44, 109, 62, 80 }, new byte[] { 164, 123, 242, 106, 192, 129, 127, 107, 253, 200, 201, 253, 51, 17, 125, 91, 163, 187, 228, 24, 94, 114, 153, 227, 183, 44, 16, 16, 237, 110, 234, 7, 158, 98, 172, 177, 208, 113, 91, 211, 158, 25, 84, 240, 64, 130, 244, 248, 147, 102, 207, 11, 196, 241, 187, 173, 11, 175, 193, 36, 180, 138, 23, 137, 160, 117, 125, 215, 207, 69, 136, 71, 45, 189, 5, 109, 109, 21, 111, 71, 21, 0, 235, 60, 185, 172, 193, 76, 9, 118, 35, 80, 19, 125, 61, 114, 117, 196, 69, 164, 23, 252, 194, 143, 230, 120, 248, 148, 154, 46, 173, 216, 144, 230, 253, 197, 197, 252, 221, 29, 112, 111, 110, 27, 29, 174, 22, 91 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("11683a11-3675-4f6b-9ba4-c37cc295adf1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d0bc16a0-1264-44bc-b11e-0992d6cfd718") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("11683a11-3675-4f6b-9ba4-c37cc295adf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0bc16a0-1264-44bc-b11e-0992d6cfd718"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("104b6e62-9925-439a-b384-bbd1bb7c7972"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 15, 31, 103, 42, 49, 61, 87, 208, 156, 164, 154, 64, 67, 96, 105, 29, 77, 229, 110, 58, 6, 228, 138, 209, 3, 194, 214, 164, 133, 101, 108, 137, 196, 190, 170, 43, 120, 74, 92, 58, 76, 223, 75, 41, 52, 63, 177, 27, 225, 228, 27, 149, 203, 9, 135, 113, 195, 61, 62, 135, 57, 50, 86, 150 }, new byte[] { 180, 1, 39, 226, 63, 132, 195, 160, 219, 243, 108, 88, 185, 250, 24, 208, 133, 78, 118, 51, 239, 105, 199, 233, 110, 90, 126, 41, 205, 32, 246, 170, 204, 235, 42, 53, 98, 28, 122, 125, 74, 9, 188, 58, 246, 37, 180, 24, 178, 170, 160, 210, 184, 144, 112, 185, 117, 194, 162, 196, 155, 214, 19, 138, 46, 121, 248, 12, 148, 239, 8, 100, 120, 30, 49, 213, 189, 148, 238, 174, 84, 215, 33, 146, 143, 186, 30, 152, 247, 194, 107, 130, 91, 99, 110, 234, 206, 44, 2, 37, 38, 176, 161, 166, 158, 43, 166, 71, 188, 135, 85, 154, 141, 64, 14, 31, 182, 69, 72, 211, 22, 204, 86, 45, 107, 194, 165, 41 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c7774692-79c5-4922-889d-2d43d6ff5c2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("104b6e62-9925-439a-b384-bbd1bb7c7972") });
        }
    }
}
