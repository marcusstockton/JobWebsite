using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobWebsite.Data.Migrations
{
    public partial class InitialCommit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "JobTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "JobTypes",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 807, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "JobTypes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "JobTypes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Jobs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosingDate",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 807, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.AddColumn<bool>(
                name: "IsDraft",
                table: "Jobs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "JobCategoryId",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobPosistionId",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobTypeId",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxSalary",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinSalary",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedById",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserTypeId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JobBenefits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedById = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(1697)),
                    UpdatedById = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobBenefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobBenefits_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobBenefits_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedById = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(3596)),
                    UpdatedById = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobCategories_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobCategories_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobKeySkills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedById = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(5532)),
                    UpdatedById = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobKeySkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobKeySkills_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobKeySkills_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobPosistions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedById = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(7342)),
                    UpdatedById = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPosistions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPosistions_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobPosistions_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedById = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(7824)),
                    UpdatedById = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTypes_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserTypes_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobBenefitJob",
                columns: table => new
                {
                    JobId = table.Column<int>(nullable: false),
                    JobBenefitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobBenefitJob", x => new { x.JobId, x.JobBenefitId });
                    table.ForeignKey(
                        name: "FK_JobBenefitJob_JobBenefits_JobBenefitId",
                        column: x => x.JobBenefitId,
                        principalTable: "JobBenefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobBenefitJob_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobKeySkillsJob",
                columns: table => new
                {
                    JobId = table.Column<int>(nullable: false),
                    JobKeySkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobKeySkillsJob", x => new { x.JobId, x.JobKeySkillId });
                    table.ForeignKey(
                        name: "FK_JobKeySkillsJob_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobKeySkillsJob_JobKeySkills_JobKeySkillId",
                        column: x => x.JobKeySkillId,
                        principalTable: "JobKeySkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobTypes_UpdatedById",
                table: "JobTypes",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobCategoryId",
                table: "Jobs",
                column: "JobCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobPosistionId",
                table: "Jobs",
                column: "JobPosistionId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobTypeId",
                table: "Jobs",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_UpdatedById",
                table: "Jobs",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserTypeId",
                table: "AspNetUsers",
                column: "UserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobBenefitJob_JobBenefitId",
                table: "JobBenefitJob",
                column: "JobBenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_JobBenefits_CreatedById",
                table: "JobBenefits",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_JobBenefits_UpdatedById",
                table: "JobBenefits",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_JobCategories_CreatedById",
                table: "JobCategories",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_JobCategories_UpdatedById",
                table: "JobCategories",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_JobKeySkills_CreatedById",
                table: "JobKeySkills",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_JobKeySkills_UpdatedById",
                table: "JobKeySkills",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_JobKeySkillsJob_JobKeySkillId",
                table: "JobKeySkillsJob",
                column: "JobKeySkillId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosistions_CreatedById",
                table: "JobPosistions",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_JobPosistions_UpdatedById",
                table: "JobPosistions",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserTypes_CreatedById",
                table: "UserTypes",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserTypes_UpdatedById",
                table: "UserTypes",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserTypes_UserTypeId",
                table: "AspNetUsers",
                column: "UserTypeId",
                principalTable: "UserTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_JobCategories_JobCategoryId",
                table: "Jobs",
                column: "JobCategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_JobPosistions_JobPosistionId",
                table: "Jobs",
                column: "JobPosistionId",
                principalTable: "JobPosistions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_JobTypes_JobTypeId",
                table: "Jobs",
                column: "JobTypeId",
                principalTable: "JobTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_AspNetUsers_UpdatedById",
                table: "Jobs",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTypes_AspNetUsers_UpdatedById",
                table: "JobTypes",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserTypes_UserTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_JobCategories_JobCategoryId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_JobPosistions_JobPosistionId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_JobTypes_JobTypeId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_AspNetUsers_UpdatedById",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTypes_AspNetUsers_UpdatedById",
                table: "JobTypes");

            migrationBuilder.DropTable(
                name: "JobBenefitJob");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "JobKeySkillsJob");

            migrationBuilder.DropTable(
                name: "JobPosistions");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "JobBenefits");

            migrationBuilder.DropTable(
                name: "JobKeySkills");

            migrationBuilder.DropIndex(
                name: "IX_JobTypes_UpdatedById",
                table: "JobTypes");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_JobCategoryId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_JobPosistionId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_JobTypeId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_UpdatedById",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserTypeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "JobTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "JobTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "JobTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "JobTypes");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "ClosingDate",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "IsDraft",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobCategoryId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobPosistionId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobTypeId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "MaxSalary",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "MinSalary",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "UserTypeId",
                table: "AspNetUsers");
        }
    }
}
