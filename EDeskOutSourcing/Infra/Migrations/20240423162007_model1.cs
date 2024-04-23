using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class model1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityTable_StateTable_StateId",
                table: "CityTable");

            migrationBuilder.DropForeignKey(
                name: "FK_StateTable_CountryTable_CountryId",
                table: "StateTable");

            migrationBuilder.CreateTable(
                name: "CompanyFAQTable",
                columns: table => new
                {
                    CompanyFAQId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FAQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyFAQTable", x => x.CompanyFAQId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTable",
                columns: table => new
                {
                    CompanyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTable", x => x.CompanyId);
                    table.ForeignKey(
                        name: "FK_CompanyTable_CityTable_CityId",
                        column: x => x.CityId,
                        principalTable: "CityTable",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationTable",
                columns: table => new
                {
                    EducationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTable", x => x.EducationId);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerFAQTable",
                columns: table => new
                {
                    FreelancerFAQId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FAQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerFAQTable", x => x.FreelancerFAQId);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerTable",
                columns: table => new
                {
                    FreelancerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerTable", x => x.FreelancerId);
                });

            migrationBuilder.CreateTable(
                name: "LocationTable",
                columns: table => new
                {
                    LocationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationTable", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_LocationTable_CityTable_CityId",
                        column: x => x.CityId,
                        principalTable: "CityTable",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentModeTable",
                columns: table => new
                {
                    PaymentModeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayMode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentModeTable", x => x.PaymentModeId);
                });

            migrationBuilder.CreateTable(
                name: "SkillCategoryTable",
                columns: table => new
                {
                    SkillCategoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillCategoryTable", x => x.SkillCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "TechnologiesTable",
                columns: table => new
                {
                    TechnologiesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechnologyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnologiesTable", x => x.TechnologiesId);
                });

            migrationBuilder.CreateTable(
                name: "TermsAndConditionsForCompany",
                columns: table => new
                {
                    TNCCompanyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyRule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermsAndConditionsForCompany", x => x.TNCCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "TermsAndConditionsForFreelancer",
                columns: table => new
                {
                    INCFreelancerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreelancerRule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermsAndConditionsForFreelancer", x => x.INCFreelancerId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTable",
                columns: table => new
                {
                    ProjectId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectTermsAndConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpectedCompletionDurationInDays = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTable", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_ProjectTable_CompanyTable_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "CompanyTable",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerCertificationTable",
                columns: table => new
                {
                    FreelancerCertificationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreelancerId = table.Column<long>(type: "bigint", nullable: false),
                    CertificateTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassingYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnivercityInstituteName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerCertificationTable", x => x.FreelancerCertificationId);
                    table.ForeignKey(
                        name: "FK_FreelancerCertificationTable_FreelancerTable_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "FreelancerTable",
                        principalColumn: "FreelancerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerEducationTable",
                columns: table => new
                {
                    FreelancerEducationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreelancerId = table.Column<long>(type: "bigint", nullable: false),
                    EducationId = table.Column<long>(type: "bigint", nullable: false),
                    PassingYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnivercityInstituteName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerEducationTable", x => x.FreelancerEducationId);
                    table.ForeignKey(
                        name: "FK_FreelancerEducationTable_EducationTable_EducationId",
                        column: x => x.EducationId,
                        principalTable: "EducationTable",
                        principalColumn: "EducationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FreelancerEducationTable_FreelancerTable_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "FreelancerTable",
                        principalColumn: "FreelancerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerExperienceTable",
                columns: table => new
                {
                    FreelancerExperienceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreelancerId = table.Column<long>(type: "bigint", nullable: false),
                    ExperienceInMonths = table.Column<int>(type: "int", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerExperienceTable", x => x.FreelancerExperienceId);
                    table.ForeignKey(
                        name: "FK_FreelancerExperienceTable_FreelancerTable_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "FreelancerTable",
                        principalColumn: "FreelancerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerPriviousProjectsTable",
                columns: table => new
                {
                    FreelancerPriviousProjectsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreelancerId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerPriviousProjectsTable", x => x.FreelancerPriviousProjectsId);
                    table.ForeignKey(
                        name: "FK_FreelancerPriviousProjectsTable_FreelancerTable_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "FreelancerTable",
                        principalColumn: "FreelancerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkillTable",
                columns: table => new
                {
                    SkillId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillCategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillTable", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_SkillTable_SkillCategoryTable_SkillCategoryId",
                        column: x => x.SkillCategoryId,
                        principalTable: "SkillCategoryTable",
                        principalColumn: "SkillCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FinishedProjectTable",
                columns: table => new
                {
                    FinishedProjectId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    FinishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishedRemark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishedProjectTable", x => x.FinishedProjectId);
                    table.ForeignKey(
                        name: "FK_FinishedProjectTable_ProjectTable_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectTable",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectApplicationsTable",
                columns: table => new
                {
                    ProjectApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreelancerId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectApplicationsTable", x => x.ProjectApplicationId);
                    table.ForeignKey(
                        name: "FK_ProjectApplicationsTable_FreelancerTable_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "FreelancerTable",
                        principalColumn: "FreelancerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectApplicationsTable_ProjectTable_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectTable",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDocumentTable",
                columns: table => new
                {
                    ProjectDocumentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    DocumentFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDocumentTable", x => x.ProjectDocumentId);
                    table.ForeignKey(
                        name: "FK_ProjectDocumentTable_ProjectTable_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectTable",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStagesTable",
                columns: table => new
                {
                    ProjectStageId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectStageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    DurationInHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStagesTable", x => x.ProjectStageId);
                    table.ForeignKey(
                        name: "FK_ProjectStagesTable_ProjectTable_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectTable",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskTable",
                columns: table => new
                {
                    ProjectTaskId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    TaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskTable", x => x.ProjectTaskId);
                    table.ForeignKey(
                        name: "FK_ProjectTaskTable_ProjectTable_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectTable",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TerminatedProjectTable",
                columns: table => new
                {
                    TerminatedProjectId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TerminationRemark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminatedProjectTable", x => x.TerminatedProjectId);
                    table.ForeignKey(
                        name: "FK_TerminatedProjectTable_ProjectTable_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectTable",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SelectedApplicationTable",
                columns: table => new
                {
                    SelectedApplicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectApplicationsProjectApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    SelectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NeedStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnyRemark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedApplicationTable", x => x.SelectedApplicationId);
                    table.ForeignKey(
                        name: "FK_SelectedApplicationTable_ProjectApplicationsTable_ProjectApplicationsProjectApplicationId",
                        column: x => x.ProjectApplicationsProjectApplicationId,
                        principalTable: "ProjectApplicationsTable",
                        principalColumn: "ProjectApplicationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskAssignmentTable",
                columns: table => new
                {
                    ProjectTaskAssignementId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTaskId = table.Column<long>(type: "bigint", nullable: false),
                    FreelancerId = table.Column<long>(type: "bigint", nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskAssignmentTable", x => x.ProjectTaskAssignementId);
                    table.ForeignKey(
                        name: "FK_ProjectTaskAssignmentTable_FreelancerTable_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "FreelancerTable",
                        principalColumn: "FreelancerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectTaskAssignmentTable_ProjectTaskTable_ProjectTaskId",
                        column: x => x.ProjectTaskId,
                        principalTable: "ProjectTaskTable",
                        principalColumn: "ProjectTaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskDocumentTable",
                columns: table => new
                {
                    ProjectTaskDocumentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTaskId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectDocumentFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskDocumentTable", x => x.ProjectTaskDocumentId);
                    table.ForeignKey(
                        name: "FK_ProjectTaskDocumentTable_ProjectTaskTable_ProjectTaskId",
                        column: x => x.ProjectTaskId,
                        principalTable: "ProjectTaskTable",
                        principalColumn: "ProjectTaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskQueryTable",
                columns: table => new
                {
                    ProjectTaskQueryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectTaskId = table.Column<long>(type: "bigint", nullable: false),
                    QueryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSolved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskQueryTable", x => x.ProjectTaskQueryId);
                    table.ForeignKey(
                        name: "FK_ProjectTaskQueryTable_ProjectTaskTable_ProjectTaskId",
                        column: x => x.ProjectTaskId,
                        principalTable: "ProjectTaskTable",
                        principalColumn: "ProjectTaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectAssignedTable",
                columns: table => new
                {
                    ProjectAssignedId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectedApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    SelectedApplicationsSelectedApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAssignedTable", x => x.ProjectAssignedId);
                    table.ForeignKey(
                        name: "FK_ProjectAssignedTable_ProjectTable_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectTable",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectAssignedTable_SelectedApplicationTable_SelectedApplicationsSelectedApplicationId",
                        column: x => x.SelectedApplicationsSelectedApplicationId,
                        principalTable: "SelectedApplicationTable",
                        principalColumn: "SelectedApplicationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskReportTable",
                columns: table => new
                {
                    ProjectTaskReportId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTaskAssignmentId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectTaskId = table.Column<long>(type: "bigint", nullable: false),
                    SourceFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReviewed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskReportTable", x => x.ProjectTaskReportId);
                    table.ForeignKey(
                        name: "FK_ProjectTaskReportTable_ProjectTaskAssignmentTable_ProjectTaskAssignmentId",
                        column: x => x.ProjectTaskAssignmentId,
                        principalTable: "ProjectTaskAssignmentTable",
                        principalColumn: "ProjectTaskAssignementId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectTaskReportTable_ProjectTaskTable_ProjectTaskId",
                        column: x => x.ProjectTaskId,
                        principalTable: "ProjectTaskTable",
                        principalColumn: "ProjectTaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskQuerySolutionTable",
                columns: table => new
                {
                    ProjectTaskQuerySolutionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolutionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectTaskQueryId = table.Column<long>(type: "bigint", nullable: false),
                    SolutionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskQuerySolutionTable", x => x.ProjectTaskQuerySolutionId);
                    table.ForeignKey(
                        name: "FK_ProjectTaskQuerySolutionTable_ProjectTaskQueryTable_ProjectTaskQueryId",
                        column: x => x.ProjectTaskQueryId,
                        principalTable: "ProjectTaskQueryTable",
                        principalColumn: "ProjectTaskQueryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskReportConflictTable",
                columns: table => new
                {
                    ProjectTaskReportConflictId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTaskReportId = table.Column<long>(type: "bigint", nullable: false),
                    ConflictDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConflictRemark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskReportConflictTable", x => x.ProjectTaskReportConflictId);
                    table.ForeignKey(
                        name: "FK_ProjectTaskReportConflictTable_ProjectTaskReportTable_ProjectTaskReportId",
                        column: x => x.ProjectTaskReportId,
                        principalTable: "ProjectTaskReportTable",
                        principalColumn: "ProjectTaskReportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskReportReleasePaymentConflictTable",
                columns: table => new
                {
                    ProjectTaskReportReleasePaymentConflictId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTaskReportId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskReportReleasePaymentConflictTable", x => x.ProjectTaskReportReleasePaymentConflictId);
                    table.ForeignKey(
                        name: "FK_ProjectTaskReportReleasePaymentConflictTable_ProjectTaskReportTable_ProjectTaskReportId",
                        column: x => x.ProjectTaskReportId,
                        principalTable: "ProjectTaskReportTable",
                        principalColumn: "ProjectTaskReportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskReportReleasePaymentTable",
                columns: table => new
                {
                    ProjectTaskReportReleasePaymentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTaskReportId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskReportReleasePaymentTable", x => x.ProjectTaskReportReleasePaymentId);
                    table.ForeignKey(
                        name: "FK_ProjectTaskReportReleasePaymentTable_ProjectTaskReportTable_ProjectTaskReportId",
                        column: x => x.ProjectTaskReportId,
                        principalTable: "ProjectTaskReportTable",
                        principalColumn: "ProjectTaskReportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskReportConflictSolutionTable",
                columns: table => new
                {
                    ProjectTaskReportConflictSolutionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTaskReportConflictId = table.Column<long>(type: "bigint", nullable: false),
                    SolutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolutionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskReportConflictSolutionTable", x => x.ProjectTaskReportConflictSolutionId);
                    table.ForeignKey(
                        name: "FK_ProjectTaskReportConflictSolutionTable_ProjectTaskReportConflictTable_ProjectTaskReportConflictId",
                        column: x => x.ProjectTaskReportConflictId,
                        principalTable: "ProjectTaskReportConflictTable",
                        principalColumn: "ProjectTaskReportConflictId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskReportReleasePaymentConflictSolutionTable",
                columns: table => new
                {
                    ProjectTaskReportReleasePaymentConflictSolutionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTaskReportReleasePaymentConflictId = table.Column<long>(type: "bigint", nullable: false),
                    SolutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolutionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskReportReleasePaymentConflictSolutionTable", x => x.ProjectTaskReportReleasePaymentConflictSolutionId);
                    table.ForeignKey(
                        name: "FK_ProjectTaskReportReleasePaymentConflictSolutionTable_ProjectTaskReportReleasePaymentConflictTable_ProjectTaskReportReleasePa~",
                        column: x => x.ProjectTaskReportReleasePaymentConflictId,
                        principalTable: "ProjectTaskReportReleasePaymentConflictTable",
                        principalColumn: "ProjectTaskReportReleasePaymentConflictId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTable_CityId",
                table: "CompanyTable",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_FinishedProjectTable_ProjectId",
                table: "FinishedProjectTable",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerCertificationTable_FreelancerId",
                table: "FreelancerCertificationTable",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerEducationTable_EducationId",
                table: "FreelancerEducationTable",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerEducationTable_FreelancerId",
                table: "FreelancerEducationTable",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerExperienceTable_FreelancerId",
                table: "FreelancerExperienceTable",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerPriviousProjectsTable_FreelancerId",
                table: "FreelancerPriviousProjectsTable",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationTable_CityId",
                table: "LocationTable",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApplicationsTable_FreelancerId",
                table: "ProjectApplicationsTable",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectApplicationsTable_ProjectId",
                table: "ProjectApplicationsTable",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAssignedTable_ProjectId",
                table: "ProjectAssignedTable",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAssignedTable_SelectedApplicationsSelectedApplicationId",
                table: "ProjectAssignedTable",
                column: "SelectedApplicationsSelectedApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentTable_ProjectId",
                table: "ProjectDocumentTable",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStagesTable_ProjectId",
                table: "ProjectStagesTable",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTable_CompanyId",
                table: "ProjectTable",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskAssignmentTable_FreelancerId",
                table: "ProjectTaskAssignmentTable",
                column: "FreelancerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskAssignmentTable_ProjectTaskId",
                table: "ProjectTaskAssignmentTable",
                column: "ProjectTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskDocumentTable_ProjectTaskId",
                table: "ProjectTaskDocumentTable",
                column: "ProjectTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskQuerySolutionTable_ProjectTaskQueryId",
                table: "ProjectTaskQuerySolutionTable",
                column: "ProjectTaskQueryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskQueryTable_ProjectTaskId",
                table: "ProjectTaskQueryTable",
                column: "ProjectTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskReportConflictSolutionTable_ProjectTaskReportConflictId",
                table: "ProjectTaskReportConflictSolutionTable",
                column: "ProjectTaskReportConflictId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskReportConflictTable_ProjectTaskReportId",
                table: "ProjectTaskReportConflictTable",
                column: "ProjectTaskReportId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskReportReleasePaymentConflictSolutionTable_ProjectTaskReportReleasePaymentConflictId",
                table: "ProjectTaskReportReleasePaymentConflictSolutionTable",
                column: "ProjectTaskReportReleasePaymentConflictId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskReportReleasePaymentConflictTable_ProjectTaskReportId",
                table: "ProjectTaskReportReleasePaymentConflictTable",
                column: "ProjectTaskReportId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskReportReleasePaymentTable_ProjectTaskReportId",
                table: "ProjectTaskReportReleasePaymentTable",
                column: "ProjectTaskReportId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskReportTable_ProjectTaskAssignmentId",
                table: "ProjectTaskReportTable",
                column: "ProjectTaskAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskReportTable_ProjectTaskId",
                table: "ProjectTaskReportTable",
                column: "ProjectTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskTable_ProjectId",
                table: "ProjectTaskTable",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedApplicationTable_ProjectApplicationsProjectApplicationId",
                table: "SelectedApplicationTable",
                column: "ProjectApplicationsProjectApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillTable_SkillCategoryId",
                table: "SkillTable",
                column: "SkillCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TerminatedProjectTable_ProjectId",
                table: "TerminatedProjectTable",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_CityTable_StateTable_StateId",
                table: "CityTable",
                column: "StateId",
                principalTable: "StateTable",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StateTable_CountryTable_CountryId",
                table: "StateTable",
                column: "CountryId",
                principalTable: "CountryTable",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityTable_StateTable_StateId",
                table: "CityTable");

            migrationBuilder.DropForeignKey(
                name: "FK_StateTable_CountryTable_CountryId",
                table: "StateTable");

            migrationBuilder.DropTable(
                name: "CompanyFAQTable");

            migrationBuilder.DropTable(
                name: "FinishedProjectTable");

            migrationBuilder.DropTable(
                name: "FreelancerCertificationTable");

            migrationBuilder.DropTable(
                name: "FreelancerEducationTable");

            migrationBuilder.DropTable(
                name: "FreelancerExperienceTable");

            migrationBuilder.DropTable(
                name: "FreelancerFAQTable");

            migrationBuilder.DropTable(
                name: "FreelancerPriviousProjectsTable");

            migrationBuilder.DropTable(
                name: "LocationTable");

            migrationBuilder.DropTable(
                name: "PaymentModeTable");

            migrationBuilder.DropTable(
                name: "ProjectAssignedTable");

            migrationBuilder.DropTable(
                name: "ProjectDocumentTable");

            migrationBuilder.DropTable(
                name: "ProjectStagesTable");

            migrationBuilder.DropTable(
                name: "ProjectTaskDocumentTable");

            migrationBuilder.DropTable(
                name: "ProjectTaskQuerySolutionTable");

            migrationBuilder.DropTable(
                name: "ProjectTaskReportConflictSolutionTable");

            migrationBuilder.DropTable(
                name: "ProjectTaskReportReleasePaymentConflictSolutionTable");

            migrationBuilder.DropTable(
                name: "ProjectTaskReportReleasePaymentTable");

            migrationBuilder.DropTable(
                name: "SkillTable");

            migrationBuilder.DropTable(
                name: "TechnologiesTable");

            migrationBuilder.DropTable(
                name: "TerminatedProjectTable");

            migrationBuilder.DropTable(
                name: "TermsAndConditionsForCompany");

            migrationBuilder.DropTable(
                name: "TermsAndConditionsForFreelancer");

            migrationBuilder.DropTable(
                name: "EducationTable");

            migrationBuilder.DropTable(
                name: "SelectedApplicationTable");

            migrationBuilder.DropTable(
                name: "ProjectTaskQueryTable");

            migrationBuilder.DropTable(
                name: "ProjectTaskReportConflictTable");

            migrationBuilder.DropTable(
                name: "ProjectTaskReportReleasePaymentConflictTable");

            migrationBuilder.DropTable(
                name: "SkillCategoryTable");

            migrationBuilder.DropTable(
                name: "ProjectApplicationsTable");

            migrationBuilder.DropTable(
                name: "ProjectTaskReportTable");

            migrationBuilder.DropTable(
                name: "ProjectTaskAssignmentTable");

            migrationBuilder.DropTable(
                name: "FreelancerTable");

            migrationBuilder.DropTable(
                name: "ProjectTaskTable");

            migrationBuilder.DropTable(
                name: "ProjectTable");

            migrationBuilder.DropTable(
                name: "CompanyTable");

            migrationBuilder.AddForeignKey(
                name: "FK_CityTable_StateTable_StateId",
                table: "CityTable",
                column: "StateId",
                principalTable: "StateTable",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StateTable_CountryTable_CountryId",
                table: "StateTable",
                column: "CountryId",
                principalTable: "CountryTable",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
