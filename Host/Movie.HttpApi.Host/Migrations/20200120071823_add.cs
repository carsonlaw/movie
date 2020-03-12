using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movie.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieCollection",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    BaseUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCollection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieMovie",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    TitleSub = table.Column<string>(nullable: true),
                    TitleEn = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Tip = table.Column<string>(nullable: true),
                    TitleLetter = table.Column<string>(nullable: true),
                    Rating = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true),
                    ImgBanner = table.Column<string>(nullable: true),
                    DatePub = table.Column<string>(nullable: true),
                    CateGoryId = table.Column<Guid>(nullable: true),
                    PropertyCountry_Name = table.Column<string>(nullable: true),
                    PropertyYear_Name = table.Column<string>(nullable: true),
                    PropertyLang_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieMovie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieMovie_MovieCategory_CateGoryId",
                        column: x => x.CateGoryId,
                        principalTable: "MovieCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CollectionCategory",
                columns: table => new
                {
                    CollectionId = table.Column<Guid>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<Guid>(nullable: true),
                    CategoryCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionCategory", x => new { x.CollectionId, x.Id });
                    table.ForeignKey(
                        name: "FK_CollectionCategory_MovieCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "MovieCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CollectionCategory_MovieCollection_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "MovieCollection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieDowner",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    From = table.Column<string>(nullable: true),
                    Server = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDowner", x => new { x.MovieId, x.Id });
                    table.ForeignKey(
                        name: "FK_MovieDowner_MovieMovie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "MovieMovie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoviePerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NameEn = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Country_Name = table.Column<string>(nullable: true),
                    IsActor = table.Column<bool>(nullable: false),
                    IsDirector = table.Column<bool>(nullable: false),
                    MovieId = table.Column<Guid>(nullable: true),
                    MovieId1 = table.Column<Guid>(nullable: true),
                    MovieId2 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoviePerson_MovieMovie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "MovieMovie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MoviePerson_MovieMovie_MovieId1",
                        column: x => x.MovieId1,
                        principalTable: "MovieMovie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MoviePerson_MovieMovie_MovieId2",
                        column: x => x.MovieId2,
                        principalTable: "MovieMovie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MoviePlayer",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    From = table.Column<string>(nullable: true),
                    Server = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePlayer", x => new { x.MovieId, x.Id });
                    table.ForeignKey(
                        name: "FK_MoviePlayer_MovieMovie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "MovieMovie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieType",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieType", x => new { x.MovieId, x.Id });
                    table.ForeignKey(
                        name: "FK_MovieType_MovieMovie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "MovieMovie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollectionCategory_CategoryId",
                table: "CollectionCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieMovie_CateGoryId",
                table: "MovieMovie",
                column: "CateGoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePerson_MovieId",
                table: "MoviePerson",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePerson_MovieId1",
                table: "MoviePerson",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePerson_MovieId2",
                table: "MoviePerson",
                column: "MovieId2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollectionCategory");

            migrationBuilder.DropTable(
                name: "MovieDowner");

            migrationBuilder.DropTable(
                name: "MoviePerson");

            migrationBuilder.DropTable(
                name: "MoviePlayer");

            migrationBuilder.DropTable(
                name: "MovieType");

            migrationBuilder.DropTable(
                name: "MovieCollection");

            migrationBuilder.DropTable(
                name: "MovieMovie");
        }
    }
}
