namespace web_api.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;
    using System;

    namespace Project.Migrations
    {
        public partial class InitialCreate : Migration
        {
            protected override void Up(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.CreateTable(
                    name: "Projects",
                    columns: table => new
                    {
                        Id = table.Column<int>(type: "int", nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                        Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Projects", x => x.Id);
                    });

                migrationBuilder.CreateTable(
                    name: "ProjectVersions",
                    columns: table => new
                    {
                        Id = table.Column<int>(type: "int", nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                        ProjectId = table.Column<int>(type: "int", nullable: false),
                        Version = table.Column<string>(type: "nvarchar(max)", nullable: true)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_ProjectVersions", x => x.Id);
                        table.ForeignKey(
                            name: "FK_ProjectVersions_Projects_ProjectId",
                            column: x => x.ProjectId,
                            principalTable: "Projects",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade);
                    });

                migrationBuilder.CreateIndex(
                    name: "IX_ProjectVersions_ProjectId",
                    table: "ProjectVersions",
                    column: "ProjectId");
            }

            protected override void Down(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.DropTable(
                    name: "ProjectVersions");

                migrationBuilder.DropTable(
                    name: "Projects");
            }
        }
    }

}
