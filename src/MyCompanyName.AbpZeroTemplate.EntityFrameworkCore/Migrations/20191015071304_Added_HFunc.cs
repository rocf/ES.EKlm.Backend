using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCompanyName.AbpZeroTemplate.Migrations
{
    public partial class Added_HFunc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HfFuncs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    HFuncId = table.Column<string>(maxLength: 5, nullable: false),
                    HFuncStatus = table.Column<int>(nullable: false),
                    HFuncName = table.Column<string>(nullable: true),
                    HFuncType = table.Column<int>(nullable: false),
                    TypeParameter = table.Column<string>(nullable: true),
                    DefaultValue = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RiskStatement = table.Column<string>(nullable: true),
                    OpenSQL = table.Column<string>(nullable: true),
                    CloseSQL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HfFuncs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HfProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<int>(nullable: false),
                    Version = table.Column<string>(nullable: true),
                    HiddenFuncId = table.Column<int>(nullable: true),
                    HFuncId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HfProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HfProducts_HfFuncs_HiddenFuncId",
                        column: x => x.HiddenFuncId,
                        principalTable: "HfFuncs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HfProducts_HiddenFuncId",
                table: "HfProducts",
                column: "HiddenFuncId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HfProducts");

            migrationBuilder.DropTable(
                name: "HfFuncs");
        }
    }
}
