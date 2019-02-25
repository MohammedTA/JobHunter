using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobHunter.Presentation.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    ProfileId = table.Column<int>(nullable: true),
                    EmployerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
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
                    UserId = table.Column<int>(nullable: false)
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
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
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
                    UserId = table.Column<int>(nullable: false),
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
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messengers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    ProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messengers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messengers_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbersPayments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    ProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbersPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumbersPayments_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    ResumeFile = table.Column<string>(nullable: true),
                    Video = table.Column<string>(nullable: true),
                    AgreementSpam = table.Column<bool>(nullable: false),
                    ProfileId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resumes_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LogoURL = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    OrganisationCredentialId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    ResumeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employers_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResumeCountry",
                columns: table => new
                {
                    ResumeId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeCountry", x => new { x.ResumeId, x.CountryId });
                    table.ForeignKey(
                        name: "FK_ResumeCountry_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumeCountry_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyRates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rate = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    EmployerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyRates_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyRates_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteResumes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ResumeId = table.Column<int>(nullable: true),
                    EmployerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteResumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteResumes_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteResumes_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrganisationCredentials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Type = table.Column<byte>(nullable: false),
                    EmployerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganisationCredentials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganisationCredentials_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    EmployerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ViewCount = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    ExpirationStatusDate = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Gender = table.Column<byte>(nullable: false),
                    WorkExperience = table.Column<string>(nullable: true),
                    Accomodation = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(nullable: true),
                    Visa = table.Column<bool>(nullable: false),
                    SalaryComment = table.Column<string>(nullable: true),
                    AgreementSpam = table.Column<bool>(nullable: false),
                    LanguageId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    EmployerId = table.Column<int>(nullable: true),
                    JobTypeId = table.Column<int>(nullable: true),
                    CurrencyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacancies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vacancies_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vacancies_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vacancies_Employers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vacancies_JobTypes_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vacancies_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Auctions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VacancyId = table.Column<int>(nullable: false),
                    ShowCount = table.Column<int>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auctions_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    LogDate = table.Column<DateTime>(nullable: false),
                    VacancyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationLogs_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    VacancyId = table.Column<int>(nullable: true),
                    ResumeId = table.Column<int>(nullable: true),
                    AddDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responses_Resumes_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Responses_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VacancyComplaints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VacancyId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyComplaints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacancyComplaints_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacancyComplaints_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VacancyFeedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descritpion = table.Column<string>(nullable: true),
                    VacancyId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Screenshot = table.Column<string>(nullable: true),
                    ParentVacancyFeedbacksd = table.Column<int>(nullable: true),
                    ParentVacancyFeedbackId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyFeedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacancyFeedbacks_VacancyFeedbacks_ParentVacancyFeedbackId",
                        column: x => x.ParentVacancyFeedbackId,
                        principalTable: "VacancyFeedbacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VacancyFeedbacks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacancyFeedbacks_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VacancyStatus",
                columns: table => new
                {
                    VacancyId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyStatus", x => new { x.VacancyId, x.StatusId });
                    table.ForeignKey(
                        name: "FK_VacancyStatus_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacancyStatus_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacancyCommentRates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rate = table.Column<int>(nullable: false),
                    VacancyFeedbackId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Like = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyCommentRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacancyCommentRates_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacancyCommentRates_VacancyFeedbacks_VacancyFeedbackId",
                        column: x => x.VacancyFeedbackId,
                        principalTable: "VacancyFeedbacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 5, "bf303acf-5e7e-40a9-a79c-9e17ddf67c6e", "moderator", "MODERATOR" },
                    { 3, "e113e27c-e2ef-4c10-85bb-3b84f267d6a8", "worker", "WORKER" },
                    { 2, "2eb859b1-42e3-469c-a61b-5de945c86777", "manager", "MANAGER" },
                    { 1, "1523d71c-e42e-40e2-b393-e90e27d38c6f", "admin", "ADMIN" },
                    { 4, "c1c0e493-25aa-4c49-974b-eb82507b0123", "employer", "EMPLOYER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 25, "jobs-auto-transport" },
                    { 24, "jobs-management-executive" },
                    { 23, "jobs-telecommunications" },
                    { 22, "jobs-customer-service" },
                    { 20, "jobs-agriculture" },
                    { 19, "jobs-office-secretarial" },
                    { 18, "jobs-retail" },
                    { 17, "jobs-production-engineering" },
                    { 16, "jobs-sales" },
                    { 21, "jobs-insurance" },
                    { 14, "jobs-education-scientific" },
                    { 2, "jobs-construction-architecture" },
                    { 3, "jobs-accounting" },
                    { 4, "jobs-administration" },
                    { 15, "jobs-security" },
                    { 5, "jobs-hotel-restaurant-tourism" },
                    { 6, "jobs-design-art" },
                    { 1, "jobs-it" },
                    { 8, "jobs-beauty-sports" },
                    { 9, "jobs-culture-music-showbiz" },
                    { 13, "jobs-real-estate" },
                    { 12, "jobs-healthcare" },
                    { 11, "jobs-marketing-advertising-pr" },
                    { 10, "jobs-logistic-supply-chain" },
                    { 7, "jobs-publishing-media" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Ukraine" },
                    { 3, "Germany" },
                    { 2, "Russian Federation" },
                    { 1, "Poland" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Russian" },
                    { 1, "English" },
                    { 5, "German" },
                    { 6, "Spanish" },
                    { 2, "Polish" },
                    { 4, "Ukrainian" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "HOT" },
                    { 2, "VIP" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Warszawa" },
                    { 29, 4, "Dnipro" },
                    { 28, 4, "Kharkiv" },
                    { 27, 4, "Rivne" },
                    { 26, 4, "Lviv" },
                    { 25, 4, "Kyiv" },
                    { 24, 3, "Bremen" },
                    { 23, 3, "Dusseldorf" },
                    { 22, 3, "Dortmund" },
                    { 21, 3, "Essen" },
                    { 20, 3, "Frankfurt" },
                    { 19, 3, "Koln" },
                    { 18, 3, "Munchen" },
                    { 17, 3, "Hamburg" },
                    { 30, 4, "Poltava" },
                    { 16, 3, "Berlin" },
                    { 14, 2, "Rostov-on-Don" },
                    { 13, 2, "Chelyabinsk" },
                    { 12, 2, "Samara" },
                    { 11, 2, "Yekaterinburg" },
                    { 10, 2, "Novosibirsk" },
                    { 9, 2, "Saint Petersburg" },
                    { 8, 2, "Moscow" },
                    { 7, 1, "Gdynia" },
                    { 6, 1, "Lublin" },
                    { 5, 1, "Gdansk" },
                    { 4, 1, "Poznan" },
                    { 3, 1, "Wroclaw" },
                    { 2, 1, "Krakow" },
                    { 15, 2, "Voronezh" },
                    { 31, 4, "Chernihiv" }
                });

            migrationBuilder.InsertData(
                table: "Employers",
                columns: new[] { "Id", "Address", "CityId", "CompanyName", "Description", "LogoURL", "OrganisationCredentialId", "ResumeId", "Site", "UserId" },
                values: new object[,]
                {
                    { 9, null, 1, "Get JOB LTD", "Factory", null, null, null, null, null },
                    { 8, null, 2, "Ocean Galaxy Marine", "Factory", null, null, null, null, null },
                    { 10, null, 3, "Get JOB LTD", "Factory", null, null, null, null, null },
                    { 11, null, 4, "Get JOB LTD", "Factory", null, null, null, null, null },
                    { 13, null, 18, "NORIU DIRBTI Recruitment Agency", "Factory", null, null, null, null, null },
                    { 12, null, 23, "NORIU DIRBTI Recruitment Agency", "Factory", null, null, null, null, null },
                    { 6, "Slovatskoho, 4", 26, "Bodo", "Sales-company", null, null, null, null, null },
                    { 7, "Sadova, 4", 26, "SoftServe", "IT-company", null, null, null, null, null },
                    { 1, "Slovatskoho, 4", 27, "SoftServe", "IT-company", null, null, null, null, null },
                    { 2, "Soborna, 102", 27, "Boro", "Sales-company", null, null, null, null, null },
                    { 3, "Soborna, 255", 27, "Toro", "Sales-company", null, null, null, null, null },
                    { 4, "Soborna, 177", 27, "Solo", "Sales-company", null, null, null, null, null },
                    { 5, "Slovatskoho, 4", 27, "AB Games", "IT-company", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Vacancies",
                columns: new[] { "Id", "Accomodation", "AgreementSpam", "CategoryId", "CityId", "Cost", "CreationDate", "CurrencyId", "Description", "EmployerId", "ExpirationDate", "ExpirationStatusDate", "Gender", "JobTypeId", "LanguageId", "Name", "Salary", "SalaryComment", "ViewCount", "Visa", "WorkExperience" },
                values: new object[,]
                {
                    { 13, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rough laying blocks, brick Concreting of armopoyas, crossing points", 9, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "Masters", 20000m, null, 0, true, null },
                    { 24, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with clients, gave them full info about products and support", 4, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "New business manager", 10000m, null, 0, false, null },
                    { 23, null, true, null, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with clients, gave them full info about products and support", 4, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, null, null, "New business manager", 11000m, null, 0, false, null },
                    { 22, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with clients, gave them full info about products and support", 4, new DateTime(2019, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "New business manager", 13000m, null, 0, false, null },
                    { 10, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with clients, gave them full info about products and support", 4, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "New business manager", 10000m, null, 0, false, null },
                    { 9, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with clients, gave them full info about products and support", 4, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "New business manager", 9000m, null, 0, false, null },
                    { 8, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with clients, gave them full info about products and support", 3, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, null, null, "New business manager", 11000m, null, 0, false, null },
                    { 7, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with clients, gave them full info about products and support", 3, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "New business manager", 12000m, null, 0, false, null },
                    { 25, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with clients, gave them full info about products and support", 2, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "New business manager", 8000m, null, 0, false, null },
                    { 6, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with clients, gave them full info about products and support", 2, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, null, null, "New business manager", 12000m, null, 0, false, null },
                    { 5, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with clients, gave them full info about products and support", 2, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "New business manager", 12000m, null, 0, false, null },
                    { 11, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "create modern apps with Unity 3D game engine", 5, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "Unity3D Game developer", 12000m, null, 0, false, null },
                    { 2, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with .NET, SQL", 1, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, ".NET developer", 16000m, null, 0, false, null },
                    { 21, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rough laying blocks, brick Concreting of armopoyas, crossing points", 7, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, null, null, "Masters", 16000m, null, 0, true, null },
                    { 20, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rough laying blocks, brick Concreting of armopoyas, crossing points", 7, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "Masters", 19000m, null, 0, true, null },
                    { 4, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with .NET, SQL", 7, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)0, null, null, ".NET developer", 16000m, null, 0, false, null },
                    { 3, null, true, null, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with HTML5, Sass, angular7", 7, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "FrontEnd developer", 15000m, null, 0, false, null },
                    { 15, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rough laying blocks, brick Concreting of armopoyas, crossing points", 8, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, null, null, "Masters", 18000m, null, 0, true, null },
                    { 14, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rough laying blocks, brick Concreting of armopoyas, crossing points", 8, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "Masters", 15000m, null, 0, true, null },
                    { 19, null, true, null, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rough laying blocks, brick Concreting of armopoyas, crossing points", 9, new DateTime(2019, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "Masters", 23000m, null, 0, true, null },
                    { 18, null, true, null, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rough laying blocks, brick Concreting of armopoyas, crossing points", 9, new DateTime(2019, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "Masters", 24000m, null, 0, true, null },
                    { 17, null, true, null, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rough laying blocks, brick Concreting of armopoyas, crossing points", 9, new DateTime(2019, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "Masters", 22000m, null, 0, true, null },
                    { 16, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rough laying blocks, brick Concreting of armopoyas, crossing points", 9, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, null, null, "Masters", 17000m, null, 0, true, null },
                    { 1, null, true, null, null, null, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "work with HTML5, Sass, angular7", 1, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, null, null, "FrontEnd developer", 15000m, null, 0, false, null },
                    { 12, null, true, null, null, null, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "create modern apps with Unity 3D game engine", 5, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, null, null, "Unity3D Game developer", 16000m, null, 0, false, null }
                });

            migrationBuilder.InsertData(
                table: "VacancyStatus",
                columns: new[] { "VacancyId", "StatusId" },
                values: new object[,]
                {
                    { 13, 1 },
                    { 9, 1 },
                    { 8, 1 },
                    { 6, 2 },
                    { 6, 1 },
                    { 5, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 1, 1 },
                    { 4, 1 },
                    { 3, 1 },
                    { 14, 1 },
                    { 19, 2 },
                    { 19, 1 },
                    { 18, 1 },
                    { 13, 2 },
                    { 23, 1 },
                    { 24, 1 }
                });

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
                name: "IX_Auctions_VacancyId",
                table: "Auctions",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRates_EmployerId",
                table: "CompanyRates",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRates_UserId",
                table: "CompanyRates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ProfileId",
                table: "Emails",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_CityId",
                table: "Employers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_ResumeId",
                table: "Employers",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_UserId",
                table: "Employers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteResumes_EmployerId",
                table: "FavoriteResumes",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteResumes_ResumeId",
                table: "FavoriteResumes",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Messengers_ProfileId",
                table: "Messengers",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationLogs_VacancyId",
                table: "OperationLogs",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganisationCredentials_EmployerId",
                table: "OrganisationCredentials",
                column: "EmployerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_EmployerId",
                table: "Payments",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbersPayments_ProfileId",
                table: "PhoneNumbersPayments",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Responses_ResumeId",
                table: "Responses",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_VacancyId",
                table: "Responses",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeCountry_CountryId",
                table: "ResumeCountry",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CategoryId",
                table: "Resumes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_ProfileId",
                table: "Resumes",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_CategoryId",
                table: "Vacancies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_CityId",
                table: "Vacancies",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_CurrencyId",
                table: "Vacancies",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_EmployerId",
                table: "Vacancies",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_JobTypeId",
                table: "Vacancies",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_LanguageId",
                table: "Vacancies",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyCommentRates_UserId",
                table: "VacancyCommentRates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyCommentRates_VacancyFeedbackId",
                table: "VacancyCommentRates",
                column: "VacancyFeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyComplaints_UserId",
                table: "VacancyComplaints",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyComplaints_VacancyId",
                table: "VacancyComplaints",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyFeedbacks_ParentVacancyFeedbackId",
                table: "VacancyFeedbacks",
                column: "ParentVacancyFeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyFeedbacks_UserId",
                table: "VacancyFeedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyFeedbacks_VacancyId",
                table: "VacancyFeedbacks",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyStatus_StatusId",
                table: "VacancyStatus",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Auctions");

            migrationBuilder.DropTable(
                name: "CompanyRates");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "FavoriteResumes");

            migrationBuilder.DropTable(
                name: "Messengers");

            migrationBuilder.DropTable(
                name: "OperationLogs");

            migrationBuilder.DropTable(
                name: "OrganisationCredentials");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PhoneNumbersPayments");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "ResumeCountry");

            migrationBuilder.DropTable(
                name: "VacancyCommentRates");

            migrationBuilder.DropTable(
                name: "VacancyComplaints");

            migrationBuilder.DropTable(
                name: "VacancyStatus");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "VacancyFeedbacks");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
