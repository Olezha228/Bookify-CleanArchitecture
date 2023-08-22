﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookify.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class UserHasIdentityId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_users_identity_id",
                table: "users",
                column: "identity_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_users_identity_id",
                table: "users");
        }
    }
}
