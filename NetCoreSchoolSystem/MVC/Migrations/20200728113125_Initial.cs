using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    IdentificationNumber = table.Column<string>(maxLength: 11, nullable: true),
                    SchoolNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    BranchName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LessonHours",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    StartHour = table.Column<TimeSpan>(nullable: false),
                    FinishHour = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonHours", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    LessonName = table.Column<string>(nullable: true),
                    SubLessonName = table.Column<string>(nullable: true),
                    LessonCategory = table.Column<int>(nullable: false),
                    WeeklyLessonHour = table.Column<int>(nullable: false),
                    MidTermNoteWeight1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MidTermNoteWeight2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinalExamNoteWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PeriodInformations",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    LessonYear = table.Column<string>(nullable: true),
                    PeriodName = table.Column<string>(nullable: true),
                    PeriodStartDate = table.Column<DateTime>(type: "Datetime2", nullable: false),
                    PeriodFinishDate = table.Column<DateTime>(type: "Datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodInformations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SuccessDocumentIdentifications",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    DocumentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuccessDocumentIdentifications", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    BranchID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Teachers_Branches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SyllabusTables",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    WeekDays = table.Column<int>(nullable: false),
                    LessonHourID = table.Column<Guid>(nullable: true),
                    LessonNameID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SyllabusTables", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SyllabusTables_LessonHours_LessonHourID",
                        column: x => x.LessonHourID,
                        principalTable: "LessonHours",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SyllabusTables_Lessons_LessonNameID",
                        column: x => x.LessonNameID,
                        principalTable: "Lessons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassDefinations",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    LessonYearID = table.Column<Guid>(nullable: true),
                    FloorLocation = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassDefinations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClassDefinations_PeriodInformations_LessonYearID",
                        column: x => x.LessonYearID,
                        principalTable: "PeriodInformations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuccessDocuments",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    LessonYearID = table.Column<Guid>(nullable: true),
                    PeriodNameID = table.Column<Guid>(nullable: true),
                    DocumentNameID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuccessDocuments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SuccessDocuments_SuccessDocumentIdentifications_DocumentNameID",
                        column: x => x.DocumentNameID,
                        principalTable: "SuccessDocumentIdentifications",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuccessDocuments_PeriodInformations_LessonYearID",
                        column: x => x.LessonYearID,
                        principalTable: "PeriodInformations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuccessDocuments_PeriodInformations_PeriodNameID",
                        column: x => x.PeriodNameID,
                        principalTable: "PeriodInformations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeacherLessons",
                columns: table => new
                {
                    TeacherID = table.Column<Guid>(nullable: false),
                    LessonID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherLessons", x => new { x.TeacherID, x.LessonID });
                    table.ForeignKey(
                        name: "FK_TeacherLessons_Lessons_LessonID",
                        column: x => x.LessonID,
                        principalTable: "Lessons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherLessons_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSyllabusTables",
                columns: table => new
                {
                    TeacherID = table.Column<Guid>(nullable: false),
                    SyllabusTableID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSyllabusTables", x => new { x.TeacherID, x.SyllabusTableID });
                    table.ForeignKey(
                        name: "FK_TeacherSyllabusTables_SyllabusTables_SyllabusTableID",
                        column: x => x.SyllabusTableID,
                        principalTable: "SyllabusTables",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSyllabusTables_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassRooms",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Room = table.Column<string>(nullable: true),
                    ClassDepartment = table.Column<string>(nullable: true),
                    ClassDefinationID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClassRooms_ClassDefinations_ClassDefinationID",
                        column: x => x.ClassDefinationID,
                        principalTable: "ClassDefinations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreRegistrations",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    PreSchoolNumber = table.Column<string>(nullable: true),
                    TheEndSchool = table.Column<string>(nullable: true),
                    LastGradeAverage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ParentName = table.Column<string>(nullable: true),
                    ParentCellPhone = table.Column<string>(nullable: true),
                    ClassAssignment = table.Column<bool>(nullable: false),
                    PeriodInformationID = table.Column<Guid>(nullable: false),
                    ClassRoomID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreRegistrations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PreRegistrations_ClassRooms_ClassRoomID",
                        column: x => x.ClassRoomID,
                        principalTable: "ClassRooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreRegistrations_PeriodInformations_PeriodInformationID",
                        column: x => x.PeriodInformationID,
                        principalTable: "PeriodInformations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    SchoolNumber = table.Column<string>(nullable: true),
                    LessonYearID = table.Column<Guid>(nullable: true),
                    YearEndAverage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GeneralAverage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ParentName = table.Column<string>(nullable: true),
                    JobPhone = table.Column<string>(nullable: true),
                    ClassRoomID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Students_ClassRooms_ClassRoomID",
                        column: x => x.ClassRoomID,
                        principalTable: "ClassRooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_PeriodInformations_LessonYearID",
                        column: x => x.LessonYearID,
                        principalTable: "PeriodInformations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeacherClassRooms",
                columns: table => new
                {
                    TeacherID = table.Column<Guid>(nullable: false),
                    ClassRoomID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherClassRooms", x => new { x.TeacherID, x.ClassRoomID });
                    table.ForeignKey(
                        name: "FK_TeacherClassRooms_ClassRooms_ClassRoomID",
                        column: x => x.ClassRoomID,
                        principalTable: "ClassRooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherClassRooms_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Absenteeisms",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ClassRoomID = table.Column<Guid>(nullable: true),
                    ClassDepartmentID = table.Column<Guid>(nullable: true),
                    IsReported = table.Column<bool>(nullable: false),
                    ReportStartDate = table.Column<DateTime>(type: "Datetime2", nullable: false),
                    ReportFinishDate = table.Column<DateTime>(type: "Datetime2", nullable: false),
                    NumberOfDaysWithReport = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsGuardStudent = table.Column<bool>(nullable: false),
                    NumberOfDaysWithGuardStudent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StudentID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absenteeisms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Absenteeisms_ClassRooms_ClassDepartmentID",
                        column: x => x.ClassDepartmentID,
                        principalTable: "ClassRooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Absenteeisms_ClassRooms_ClassRoomID",
                        column: x => x.ClassRoomID,
                        principalTable: "ClassRooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Absenteeisms_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NoteEntries",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    IdentificationNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CellPhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIP = table.Column<string>(nullable: true),
                    CreatedAdUserName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedComputerName = table.Column<string>(nullable: true),
                    ModifiedIP = table.Column<string>(nullable: true),
                    ModifiedAdUserName = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    SchoolNumberID = table.Column<Guid>(nullable: true),
                    ClassRoomID = table.Column<Guid>(nullable: true),
                    ClassDepartmentID = table.Column<Guid>(nullable: true),
                    StudentNameID = table.Column<Guid>(nullable: true),
                    StudentSurNameID = table.Column<Guid>(nullable: true),
                    LessonNameID = table.Column<Guid>(nullable: true),
                    LessonYearID = table.Column<Guid>(nullable: true),
                    PeriodNameID = table.Column<Guid>(nullable: true),
                    ExamType = table.Column<string>(nullable: true),
                    LessonScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TeacherFirstNameID = table.Column<Guid>(nullable: true),
                    TeacherSurNameID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteEntries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NoteEntries_ClassRooms_ClassDepartmentID",
                        column: x => x.ClassDepartmentID,
                        principalTable: "ClassRooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NoteEntries_ClassRooms_ClassRoomID",
                        column: x => x.ClassRoomID,
                        principalTable: "ClassRooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NoteEntries_Lessons_LessonNameID",
                        column: x => x.LessonNameID,
                        principalTable: "Lessons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NoteEntries_PeriodInformations_LessonYearID",
                        column: x => x.LessonYearID,
                        principalTable: "PeriodInformations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NoteEntries_PeriodInformations_PeriodNameID",
                        column: x => x.PeriodNameID,
                        principalTable: "PeriodInformations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NoteEntries_Students_SchoolNumberID",
                        column: x => x.SchoolNumberID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NoteEntries_Students_StudentNameID",
                        column: x => x.StudentNameID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NoteEntries_Students_StudentSurNameID",
                        column: x => x.StudentSurNameID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NoteEntries_Teachers_TeacherFirstNameID",
                        column: x => x.TeacherFirstNameID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NoteEntries_Teachers_TeacherSurNameID",
                        column: x => x.TeacherSurNameID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentLessons",
                columns: table => new
                {
                    StudentID = table.Column<Guid>(nullable: false),
                    LessonID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLessons", x => new { x.StudentID, x.LessonID });
                    table.ForeignKey(
                        name: "FK_StudentLessons_Lessons_LessonID",
                        column: x => x.LessonID,
                        principalTable: "Lessons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentLessons_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentSuccessDocuments",
                columns: table => new
                {
                    StudentID = table.Column<Guid>(nullable: false),
                    SuccessDocumentID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSuccessDocuments", x => new { x.StudentID, x.SuccessDocumentID });
                    table.ForeignKey(
                        name: "FK_StudentSuccessDocuments_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSuccessDocuments_SuccessDocuments_SuccessDocumentID",
                        column: x => x.SuccessDocumentID,
                        principalTable: "SuccessDocuments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentSyllabusTables",
                columns: table => new
                {
                    StudentID = table.Column<Guid>(nullable: false),
                    SyllabusTableID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSyllabusTables", x => new { x.StudentID, x.SyllabusTableID });
                    table.ForeignKey(
                        name: "FK_StudentSyllabusTables_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSyllabusTables_SyllabusTables_SyllabusTableID",
                        column: x => x.SyllabusTableID,
                        principalTable: "SyllabusTables",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentTeachers",
                columns: table => new
                {
                    StudentID = table.Column<Guid>(nullable: false),
                    TeacherID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTeachers", x => new { x.StudentID, x.TeacherID });
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherNoteEntries",
                columns: table => new
                {
                    TeacherID = table.Column<Guid>(nullable: false),
                    NoteEntryID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherNoteEntries", x => new { x.TeacherID, x.NoteEntryID });
                    table.ForeignKey(
                        name: "FK_TeacherNoteEntries_NoteEntries_NoteEntryID",
                        column: x => x.NoteEntryID,
                        principalTable: "NoteEntries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherNoteEntries_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Absenteeisms_ClassDepartmentID",
                table: "Absenteeisms",
                column: "ClassDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Absenteeisms_ClassRoomID",
                table: "Absenteeisms",
                column: "ClassRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Absenteeisms_StudentID",
                table: "Absenteeisms",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClassDefinations_LessonYearID",
                table: "ClassDefinations",
                column: "LessonYearID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRooms_ClassDefinationID",
                table: "ClassRooms",
                column: "ClassDefinationID");

            migrationBuilder.CreateIndex(
                name: "IX_NoteEntries_ClassDepartmentID",
                table: "NoteEntries",
                column: "ClassDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_NoteEntries_ClassRoomID",
                table: "NoteEntries",
                column: "ClassRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_NoteEntries_LessonNameID",
                table: "NoteEntries",
                column: "LessonNameID");

            migrationBuilder.CreateIndex(
                name: "IX_NoteEntries_LessonYearID",
                table: "NoteEntries",
                column: "LessonYearID");

            migrationBuilder.CreateIndex(
                name: "IX_NoteEntries_PeriodNameID",
                table: "NoteEntries",
                column: "PeriodNameID");

            migrationBuilder.CreateIndex(
                name: "IX_NoteEntries_SchoolNumberID",
                table: "NoteEntries",
                column: "SchoolNumberID");

            migrationBuilder.CreateIndex(
                name: "IX_NoteEntries_StudentNameID",
                table: "NoteEntries",
                column: "StudentNameID");

            migrationBuilder.CreateIndex(
                name: "IX_NoteEntries_StudentSurNameID",
                table: "NoteEntries",
                column: "StudentSurNameID");

            migrationBuilder.CreateIndex(
                name: "IX_NoteEntries_TeacherFirstNameID",
                table: "NoteEntries",
                column: "TeacherFirstNameID");

            migrationBuilder.CreateIndex(
                name: "IX_NoteEntries_TeacherSurNameID",
                table: "NoteEntries",
                column: "TeacherSurNameID");

            migrationBuilder.CreateIndex(
                name: "IX_PreRegistrations_ClassRoomID",
                table: "PreRegistrations",
                column: "ClassRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_PreRegistrations_PeriodInformationID",
                table: "PreRegistrations",
                column: "PeriodInformationID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentLessons_LessonID",
                table: "StudentLessons",
                column: "LessonID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassRoomID",
                table: "Students",
                column: "ClassRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LessonYearID",
                table: "Students",
                column: "LessonYearID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSuccessDocuments_SuccessDocumentID",
                table: "StudentSuccessDocuments",
                column: "SuccessDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSyllabusTables_SyllabusTableID",
                table: "StudentSyllabusTables",
                column: "SyllabusTableID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTeachers_TeacherID",
                table: "StudentTeachers",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_SuccessDocuments_DocumentNameID",
                table: "SuccessDocuments",
                column: "DocumentNameID");

            migrationBuilder.CreateIndex(
                name: "IX_SuccessDocuments_LessonYearID",
                table: "SuccessDocuments",
                column: "LessonYearID");

            migrationBuilder.CreateIndex(
                name: "IX_SuccessDocuments_PeriodNameID",
                table: "SuccessDocuments",
                column: "PeriodNameID");

            migrationBuilder.CreateIndex(
                name: "IX_SyllabusTables_LessonHourID",
                table: "SyllabusTables",
                column: "LessonHourID");

            migrationBuilder.CreateIndex(
                name: "IX_SyllabusTables_LessonNameID",
                table: "SyllabusTables",
                column: "LessonNameID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherClassRooms_ClassRoomID",
                table: "TeacherClassRooms",
                column: "ClassRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLessons_LessonID",
                table: "TeacherLessons",
                column: "LessonID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherNoteEntries_NoteEntryID",
                table: "TeacherNoteEntries",
                column: "NoteEntryID");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_BranchID",
                table: "Teachers",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSyllabusTables_SyllabusTableID",
                table: "TeacherSyllabusTables",
                column: "SyllabusTableID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Absenteeisms");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PreRegistrations");

            migrationBuilder.DropTable(
                name: "StudentLessons");

            migrationBuilder.DropTable(
                name: "StudentSuccessDocuments");

            migrationBuilder.DropTable(
                name: "StudentSyllabusTables");

            migrationBuilder.DropTable(
                name: "StudentTeachers");

            migrationBuilder.DropTable(
                name: "TeacherClassRooms");

            migrationBuilder.DropTable(
                name: "TeacherLessons");

            migrationBuilder.DropTable(
                name: "TeacherNoteEntries");

            migrationBuilder.DropTable(
                name: "TeacherSyllabusTables");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SuccessDocuments");

            migrationBuilder.DropTable(
                name: "NoteEntries");

            migrationBuilder.DropTable(
                name: "SyllabusTables");

            migrationBuilder.DropTable(
                name: "SuccessDocumentIdentifications");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "LessonHours");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "ClassRooms");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "ClassDefinations");

            migrationBuilder.DropTable(
                name: "PeriodInformations");
        }
    }
}
