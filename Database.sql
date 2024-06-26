USE [EDeskOutSourcing]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdminTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminTable](
	[AdminId] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Mobile] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_AdminTable] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CityTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CityTable](
	[CityId] [bigint] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](max) NULL,
	[StateId] [bigint] NOT NULL,
 CONSTRAINT [PK_CityTable] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyFAQTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyFAQTable](
	[CompanyFAQId] [bigint] IDENTITY(1,1) NOT NULL,
	[FAQ] [nvarchar](max) NULL,
	[Answer] [nvarchar](max) NULL,
	[AddedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_CompanyFAQTable] PRIMARY KEY CLUSTERED 
(
	[CompanyFAQId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyTable](
	[CompanyId] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[EmailId] [nvarchar](max) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[ContactPersonName] [nvarchar](max) NULL,
	[CityId] [bigint] NOT NULL,
	[JoinedDate] [datetime2](7) NOT NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_CompanyTable] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CountryTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CountryTable](
	[CountryId] [bigint] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_CountryTable] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EducationTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationTable](
	[EducationId] [bigint] IDENTITY(1,1) NOT NULL,
	[EducationName] [nvarchar](max) NULL,
	[EducationType] [int] NOT NULL,
 CONSTRAINT [PK_EducationTable] PRIMARY KEY CLUSTERED 
(
	[EducationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinishedProjectTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinishedProjectTable](
	[FinishedProjectId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectId] [bigint] NOT NULL,
	[FinishedDate] [datetime2](7) NOT NULL,
	[FinishedRemark] [nvarchar](max) NULL,
 CONSTRAINT [PK_FinishedProjectTable] PRIMARY KEY CLUSTERED 
(
	[FinishedProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FreelancerCertificationTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreelancerCertificationTable](
	[FreelancerCertificationId] [bigint] IDENTITY(1,1) NOT NULL,
	[FreelancerId] [bigint] NOT NULL,
	[CertificateTitle] [nvarchar](max) NULL,
	[PassingYear] [nvarchar](max) NULL,
	[UnivercityInstituteName] [nvarchar](max) NULL,
 CONSTRAINT [PK_FreelancerCertificationTable] PRIMARY KEY CLUSTERED 
(
	[FreelancerCertificationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FreelancerEducationTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreelancerEducationTable](
	[FreelancerEducationId] [bigint] IDENTITY(1,1) NOT NULL,
	[FreelancerId] [bigint] NOT NULL,
	[EducationId] [bigint] NOT NULL,
	[PassingYear] [nvarchar](max) NULL,
	[UnivercityInstituteName] [nvarchar](max) NULL,
 CONSTRAINT [PK_FreelancerEducationTable] PRIMARY KEY CLUSTERED 
(
	[FreelancerEducationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FreelancerExperienceTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreelancerExperienceTable](
	[FreelancerExperienceId] [bigint] IDENTITY(1,1) NOT NULL,
	[FreelancerId] [bigint] NOT NULL,
	[ExperienceInMonths] [int] NOT NULL,
	[RoleName] [nvarchar](max) NULL,
	[CompanyName] [nvarchar](max) NULL,
	[FromDate] [datetime2](7) NOT NULL,
	[ToDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_FreelancerExperienceTable] PRIMARY KEY CLUSTERED 
(
	[FreelancerExperienceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FreelancerFAQTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreelancerFAQTable](
	[FreelancerFAQId] [bigint] IDENTITY(1,1) NOT NULL,
	[FAQ] [nvarchar](max) NULL,
	[Answer] [nvarchar](max) NULL,
	[AddedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_FreelancerFAQTable] PRIMARY KEY CLUSTERED 
(
	[FreelancerFAQId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FreelancerPriviousProjectsTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreelancerPriviousProjectsTable](
	[FreelancerPriviousProjectsId] [bigint] IDENTITY(1,1) NOT NULL,
	[FreelancerId] [bigint] NOT NULL,
	[ProjectTitle] [nvarchar](max) NULL,
	[ProjectDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_FreelancerPriviousProjectsTable] PRIMARY KEY CLUSTERED 
(
	[FreelancerPriviousProjectsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FreelancerTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreelancerTable](
	[FreelancerId] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[EmailId] [nvarchar](max) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_FreelancerTable] PRIMARY KEY CLUSTERED 
(
	[FreelancerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LocationTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocationTable](
	[LocationId] [bigint] IDENTITY(1,1) NOT NULL,
	[LocationName] [nvarchar](max) NULL,
	[CityId] [bigint] NOT NULL,
 CONSTRAINT [PK_LocationTable] PRIMARY KEY CLUSTERED 
(
	[LocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentModeTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentModeTable](
	[PaymentModeId] [bigint] IDENTITY(1,1) NOT NULL,
	[PayMode] [nvarchar](max) NULL,
 CONSTRAINT [PK_PaymentModeTable] PRIMARY KEY CLUSTERED 
(
	[PaymentModeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectApplicationsTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectApplicationsTable](
	[ProjectApplicationId] [bigint] IDENTITY(1,1) NOT NULL,
	[FreelancerId] [bigint] NOT NULL,
	[ProjectId] [bigint] NOT NULL,
	[ApplicationDate] [datetime2](7) NOT NULL,
	[ApplicationTitle] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProjectApplicationsTable] PRIMARY KEY CLUSTERED 
(
	[ProjectApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectAssignedTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectAssignedTable](
	[ProjectAssignedId] [bigint] IDENTITY(1,1) NOT NULL,
	[SelectedApplicationId] [bigint] NOT NULL,
	[SelectedApplicationsSelectedApplicationId] [bigint] NULL,
	[ProjectId] [bigint] NOT NULL,
	[ApplicationDate] [datetime2](7) NOT NULL,
	[ApplicationTitle] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProjectAssignedTable] PRIMARY KEY CLUSTERED 
(
	[ProjectAssignedId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectDocumentTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectDocumentTable](
	[ProjectDocumentId] [bigint] IDENTITY(1,1) NOT NULL,
	[DocName] [nvarchar](max) NULL,
	[ProjectId] [bigint] NOT NULL,
	[DocumentFilePath] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProjectDocumentTable] PRIMARY KEY CLUSTERED 
(
	[ProjectDocumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectSkillTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectSkillTable](
	[ProjectSkillId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectId] [bigint] NOT NULL,
	[SkillId] [bigint] NOT NULL,
 CONSTRAINT [PK_ProjectSkillTable] PRIMARY KEY CLUSTERED 
(
	[ProjectSkillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectStagesTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectStagesTable](
	[ProjectStageId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectStageName] [nvarchar](max) NULL,
	[ProjectId] [bigint] NOT NULL,
	[DurationInHours] [int] NOT NULL,
	[StageDescription] [nvarchar](max) NULL,
	[ProjectStageId1] [bigint] NULL,
 CONSTRAINT [PK_ProjectStagesTable] PRIMARY KEY CLUSTERED 
(
	[ProjectStageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTable](
	[ProjectId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectName] [nvarchar](max) NULL,
	[ProjectDescription] [nvarchar](max) NULL,
	[CompanyId] [bigint] NOT NULL,
	[ProjectStatus] [int] NOT NULL,
	[ProjectPaymentTerms] [int] NOT NULL,
	[ProjectTermsAndConditions] [nvarchar](max) NULL,
	[Budget] [decimal](18, 2) NOT NULL,
	[ExpectedCompletionDurationInDays] [int] NOT NULL,
 CONSTRAINT [PK_ProjectTable] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTaskAssignmentTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTaskAssignmentTable](
	[ProjectTaskAssignementId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectTaskId] [bigint] NOT NULL,
	[FreelancerId] [bigint] NOT NULL,
	[AssignedDate] [datetime2](7) NOT NULL,
	[ExpectedCompletionDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProjectTaskAssignmentTable] PRIMARY KEY CLUSTERED 
(
	[ProjectTaskAssignementId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTaskDocumentTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTaskDocumentTable](
	[ProjectTaskDocumentId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectTaskId] [bigint] NOT NULL,
	[ProjectDocumentFilePath] [nvarchar](max) NULL,
	[DocName] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProjectTaskDocumentTable] PRIMARY KEY CLUSTERED 
(
	[ProjectTaskDocumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTaskQuerySolutionTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTaskQuerySolutionTable](
	[ProjectTaskQuerySolutionId] [bigint] IDENTITY(1,1) NOT NULL,
	[SolutionTitle] [nvarchar](max) NULL,
	[ProjectTaskQueryId] [bigint] NOT NULL,
	[SolutionDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProjectTaskQuerySolutionTable] PRIMARY KEY CLUSTERED 
(
	[ProjectTaskQuerySolutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTaskQueryTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTaskQueryTable](
	[ProjectTaskQueryId] [bigint] IDENTITY(1,1) NOT NULL,
	[QueryTitle] [nvarchar](max) NULL,
	[ProjectTaskId] [bigint] NOT NULL,
	[QueryDescription] [nvarchar](max) NULL,
	[IsSolved] [bit] NOT NULL,
 CONSTRAINT [PK_ProjectTaskQueryTable] PRIMARY KEY CLUSTERED 
(
	[ProjectTaskQueryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTaskReportConflictSolutionTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTaskReportConflictSolutionTable](
	[ProjectTaskReportConflictSolutionId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectTaskReportConflictId] [bigint] NOT NULL,
	[SolutionDate] [datetime2](7) NOT NULL,
	[SolutionDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProjectTaskReportConflictSolutionTable] PRIMARY KEY CLUSTERED 
(
	[ProjectTaskReportConflictSolutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTaskReportConflictTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTaskReportConflictTable](
	[ProjectTaskReportConflictId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectTaskReportId] [bigint] NOT NULL,
	[ConflictDate] [datetime2](7) NOT NULL,
	[ConflictRemark] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProjectTaskReportConflictTable] PRIMARY KEY CLUSTERED 
(
	[ProjectTaskReportConflictId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTaskReportReleasePaymentConflictSolutionTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTaskReportReleasePaymentConflictSolutionTable](
	[ProjectTaskReportReleasePaymentConflictSolutionId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectTaskReportReleasePaymentConflictId] [bigint] NOT NULL,
	[SolutionDate] [datetime2](7) NOT NULL,
	[SolutionDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProjectTaskReportReleasePaymentConflictSolutionTable] PRIMARY KEY CLUSTERED 
(
	[ProjectTaskReportReleasePaymentConflictSolutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTaskReportReleasePaymentConflictTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTaskReportReleasePaymentConflictTable](
	[ProjectTaskReportReleasePaymentConflictId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectTaskReportId] [bigint] NOT NULL,
	[PaymentAmount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_ProjectTaskReportReleasePaymentConflictTable] PRIMARY KEY CLUSTERED 
(
	[ProjectTaskReportReleasePaymentConflictId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTaskReportReleasePaymentTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTaskReportReleasePaymentTable](
	[ProjectTaskReportReleasePaymentId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectTaskReportId] [bigint] NOT NULL,
	[PaymentAmount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_ProjectTaskReportReleasePaymentTable] PRIMARY KEY CLUSTERED 
(
	[ProjectTaskReportReleasePaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTaskReportTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTaskReportTable](
	[ProjectTaskReportId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectTaskAssignmentId] [bigint] NOT NULL,
	[ProjectTaskId] [bigint] NOT NULL,
	[SourceFilePath] [nvarchar](max) NULL,
	[IsReviewed] [bit] NOT NULL,
 CONSTRAINT [PK_ProjectTaskReportTable] PRIMARY KEY CLUSTERED 
(
	[ProjectTaskReportId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTaskTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTaskTable](
	[ProjectTaskId] [bigint] IDENTITY(1,1) NOT NULL,
	[TaskTitle] [nvarchar](max) NULL,
	[ProjectId] [bigint] NOT NULL,
	[TaskDescription] [nvarchar](max) NULL,
	[TaskAmount] [decimal](18, 2) NOT NULL,
	[TaskStatus] [int] NOT NULL,
 CONSTRAINT [PK_ProjectTaskTable] PRIMARY KEY CLUSTERED 
(
	[ProjectTaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTechnology]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTechnology](
	[ProjectTechnologyId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectId] [bigint] NOT NULL,
	[TechnologiesId] [bigint] NOT NULL,
 CONSTRAINT [PK_ProjectTechnology] PRIMARY KEY CLUSTERED 
(
	[ProjectTechnologyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SelectedApplicationTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SelectedApplicationTable](
	[SelectedApplicationId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectApplicationId] [bigint] NOT NULL,
	[ProjectApplicationsProjectApplicationId] [bigint] NULL,
	[SelectionDate] [datetime2](7) NOT NULL,
	[NeedStartDate] [datetime2](7) NOT NULL,
	[AnyRemark] [nvarchar](max) NULL,
 CONSTRAINT [PK_SelectedApplicationTable] PRIMARY KEY CLUSTERED 
(
	[SelectedApplicationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SkillCategoryTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SkillCategoryTable](
	[SkillCategoryId] [bigint] IDENTITY(1,1) NOT NULL,
	[SkillCategoryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_SkillCategoryTable] PRIMARY KEY CLUSTERED 
(
	[SkillCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SkillTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SkillTable](
	[SkillId] [bigint] IDENTITY(1,1) NOT NULL,
	[SkillName] [nvarchar](max) NULL,
	[SkillCategoryId] [bigint] NOT NULL,
 CONSTRAINT [PK_SkillTable] PRIMARY KEY CLUSTERED 
(
	[SkillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StateTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StateTable](
	[StateId] [bigint] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](max) NULL,
	[CountryId] [bigint] NOT NULL,
 CONSTRAINT [PK_StateTable] PRIMARY KEY CLUSTERED 
(
	[StateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechnologiesTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnologiesTable](
	[TechnologiesId] [bigint] IDENTITY(1,1) NOT NULL,
	[TechnologyName] [nvarchar](max) NULL,
 CONSTRAINT [PK_TechnologiesTable] PRIMARY KEY CLUSTERED 
(
	[TechnologiesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TerminatedProjectTable]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TerminatedProjectTable](
	[TerminatedProjectId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectId] [bigint] NOT NULL,
	[TerminationDate] [datetime2](7) NOT NULL,
	[TerminationRemark] [nvarchar](max) NULL,
 CONSTRAINT [PK_TerminatedProjectTable] PRIMARY KEY CLUSTERED 
(
	[TerminatedProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TermsAndConditionsForCompany]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TermsAndConditionsForCompany](
	[TNCCompanyId] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyRule] [nvarchar](max) NULL,
	[AddedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TermsAndConditionsForCompany] PRIMARY KEY CLUSTERED 
(
	[TNCCompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TermsAndConditionsForFreelancer]    Script Date: 20-06-2024 18:05:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TermsAndConditionsForFreelancer](
	[TNCFreelancerId] [bigint] IDENTITY(1,1) NOT NULL,
	[FreelancerRule] [nvarchar](max) NULL,
	[AddedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TermsAndConditionsForFreelancer] PRIMARY KEY CLUSTERED 
(
	[TNCFreelancerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240425113004_init', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240429123923_init4', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240430045229_s', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240430055209_id', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240430065713_int', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240501121511_IForm', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240504033009_Experience', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240505125717_projectskilltech', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240506070110_newclass1', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240508091551_DaysNum', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240509095758_ApplicationBody', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240511150758_dateapplication', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240512130824_DocName', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240602114643_RemovedApplicationBody', N'7.0.18')
GO
SET IDENTITY_INSERT [dbo].[AdminTable] ON 

INSERT [dbo].[AdminTable] ([AdminId], [FirstName], [LastName], [Email], [Mobile], [Password]) VALUES (1, N'Tony', N'Stark', N'Admin@gmail.com', N'9922334455', N'Admin')
SET IDENTITY_INSERT [dbo].[AdminTable] OFF
GO
SET IDENTITY_INSERT [dbo].[CityTable] ON 

INSERT [dbo].[CityTable] ([CityId], [CityName], [StateId]) VALUES (1, N'Houston', 12)
INSERT [dbo].[CityTable] ([CityId], [CityName], [StateId]) VALUES (4, N'New York City', 5)
INSERT [dbo].[CityTable] ([CityId], [CityName], [StateId]) VALUES (5, N'Los Angels', 14)
INSERT [dbo].[CityTable] ([CityId], [CityName], [StateId]) VALUES (6, N'London', 14)
INSERT [dbo].[CityTable] ([CityId], [CityName], [StateId]) VALUES (7, N'Edinburgh', 9)
INSERT [dbo].[CityTable] ([CityId], [CityName], [StateId]) VALUES (8, N'Osaka', 12)
INSERT [dbo].[CityTable] ([CityId], [CityName], [StateId]) VALUES (10, N'Melbourne', 15)
INSERT [dbo].[CityTable] ([CityId], [CityName], [StateId]) VALUES (11, N'Sydeny', 14)
SET IDENTITY_INSERT [dbo].[CityTable] OFF
GO
SET IDENTITY_INSERT [dbo].[CompanyFAQTable] ON 

INSERT [dbo].[CompanyFAQTable] ([CompanyFAQId], [FAQ], [Answer], [AddedDate]) VALUES (1, N'How much you pay', N'150 rs', CAST(N'2024-04-25T18:17:17.7225754' AS DateTime2))
SET IDENTITY_INSERT [dbo].[CompanyFAQTable] OFF
GO
SET IDENTITY_INSERT [dbo].[CompanyTable] ON 

INSERT [dbo].[CompanyTable] ([CompanyId], [CompanyName], [Address], [EmailId], [MobileNo], [ContactPersonName], [CityId], [JoinedDate], [Password]) VALUES (2, N'Revolution Infosystems', N'Akurdi, Pune', N'Company@gmail.com', N'9922334455', N'David Goggnins', 1, CAST(N'2024-04-25T18:17:33.0457069' AS DateTime2), N'Company')
INSERT [dbo].[CompanyTable] ([CompanyId], [CompanyName], [Address], [EmailId], [MobileNo], [ContactPersonName], [CityId], [JoinedDate], [Password]) VALUES (19, N'Three Builds', N'Pune', N'threebuilds@gmail.com', N'7020285895', N'Rushikesh Sanjay Kadam', 4, CAST(N'2024-05-20T13:54:27.3918139' AS DateTime2), N'abcd')
SET IDENTITY_INSERT [dbo].[CompanyTable] OFF
GO
SET IDENTITY_INSERT [dbo].[CountryTable] ON 

INSERT [dbo].[CountryTable] ([CountryId], [CountryName]) VALUES (2, N'USA')
INSERT [dbo].[CountryTable] ([CountryId], [CountryName]) VALUES (3, N'UK')
INSERT [dbo].[CountryTable] ([CountryId], [CountryName]) VALUES (4, N'Japan')
INSERT [dbo].[CountryTable] ([CountryId], [CountryName]) VALUES (5, N'Australia')
SET IDENTITY_INSERT [dbo].[CountryTable] OFF
GO
SET IDENTITY_INSERT [dbo].[EducationTable] ON 

INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (3, N'MS', 4)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (4, N'MBA', 1)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (5, N'Bachelor of Arts (BA)', 1)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (6, N'Bachelor of Science (BSc)', 1)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (7, N'Bachelor of Business Administration (BBA)', 1)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (8, N'Bachelor of Engineering (BEng)', 1)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (9, N'Bachelor of Technology (BTech)', 1)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (10, N'Master of Arts (MA)', 2)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (11, N'Master of Science (MSc)', 2)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (12, N'Master of Business Administration (MBA)', 2)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (13, N'Master of Engineering (MEng)', 2)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (14, N'Master of Technology (MTech)', 2)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (15, N'Project Management Professional (PMP)', 3)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (16, N'Certified Public Accountant (CPA)', 3)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (17, N'Certified Information Systems Security Professional (CISSP)', 3)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (18, N'Certified ScrumMaster (CSM)', 3)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (19, N'Google Analytics Individual Qualification (GAIQ)', 3)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (20, N'Doctor of Philosophy (PhD)', 4)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (21, N'Doctor of Medicine (MD)', 4)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (22, N'Doctor of Engineering (DEng)', 4)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (23, N'Doctor of Business Administration (DBA)', 4)
INSERT [dbo].[EducationTable] ([EducationId], [EducationName], [EducationType]) VALUES (24, N'Master of Laws (LLM)', 4)
SET IDENTITY_INSERT [dbo].[EducationTable] OFF
GO
SET IDENTITY_INSERT [dbo].[FreelancerCertificationTable] ON 

INSERT [dbo].[FreelancerCertificationTable] ([FreelancerCertificationId], [FreelancerId], [CertificateTitle], [PassingYear], [UnivercityInstituteName]) VALUES (1, 1, N'PowerBI Specialist', N'2014', N'RGI Pune')
INSERT [dbo].[FreelancerCertificationTable] ([FreelancerCertificationId], [FreelancerId], [CertificateTitle], [PassingYear], [UnivercityInstituteName]) VALUES (2, 1, N'Graphics Designer', N'2019', N'MIT Pune')
INSERT [dbo].[FreelancerCertificationTable] ([FreelancerCertificationId], [FreelancerId], [CertificateTitle], [PassingYear], [UnivercityInstituteName]) VALUES (3, 1, N'Social Media Influiencer', N'2016', N'RI-Tech Pune')
INSERT [dbo].[FreelancerCertificationTable] ([FreelancerCertificationId], [FreelancerId], [CertificateTitle], [PassingYear], [UnivercityInstituteName]) VALUES (4, 1, N'Techie', N'2023', N'Symbosis Pune')
SET IDENTITY_INSERT [dbo].[FreelancerCertificationTable] OFF
GO
SET IDENTITY_INSERT [dbo].[FreelancerEducationTable] ON 

INSERT [dbo].[FreelancerEducationTable] ([FreelancerEducationId], [FreelancerId], [EducationId], [PassingYear], [UnivercityInstituteName]) VALUES (1, 1, 3, N'2024', N'Raisoni Pune')
INSERT [dbo].[FreelancerEducationTable] ([FreelancerEducationId], [FreelancerId], [EducationId], [PassingYear], [UnivercityInstituteName]) VALUES (3, 1, 4, N'2024', N'Raisoni Pune')
INSERT [dbo].[FreelancerEducationTable] ([FreelancerEducationId], [FreelancerId], [EducationId], [PassingYear], [UnivercityInstituteName]) VALUES (4, 1, 3, N'2013', N'BVM Parbhani')
INSERT [dbo].[FreelancerEducationTable] ([FreelancerEducationId], [FreelancerId], [EducationId], [PassingYear], [UnivercityInstituteName]) VALUES (6, 1, 3, N'2019', N'SSPI')
INSERT [dbo].[FreelancerEducationTable] ([FreelancerEducationId], [FreelancerId], [EducationId], [PassingYear], [UnivercityInstituteName]) VALUES (7, 1, 4, N'2024', N'RI-Tech')
SET IDENTITY_INSERT [dbo].[FreelancerEducationTable] OFF
GO
SET IDENTITY_INSERT [dbo].[FreelancerExperienceTable] ON 

INSERT [dbo].[FreelancerExperienceTable] ([FreelancerExperienceId], [FreelancerId], [ExperienceInMonths], [RoleName], [CompanyName], [FromDate], [ToDate]) VALUES (16, 1, 2, N'Senior Manager', N'Revolution Infosystems', CAST(N'2024-04-09T00:00:00.0000000' AS DateTime2), CAST(N'2024-05-30T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[FreelancerExperienceTable] ([FreelancerExperienceId], [FreelancerId], [ExperienceInMonths], [RoleName], [CompanyName], [FromDate], [ToDate]) VALUES (17, 1, 4, N'Keeper', N'ABCD Infotech', CAST(N'2024-04-29T00:00:00.0000000' AS DateTime2), CAST(N'2024-05-29T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[FreelancerExperienceTable] ([FreelancerExperienceId], [FreelancerId], [ExperienceInMonths], [RoleName], [CompanyName], [FromDate], [ToDate]) VALUES (18, 1, 3, N'Helper', N'XYZ Infosix', CAST(N'2024-04-30T00:00:00.0000000' AS DateTime2), CAST(N'2024-05-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[FreelancerExperienceTable] ([FreelancerExperienceId], [FreelancerId], [ExperienceInMonths], [RoleName], [CompanyName], [FromDate], [ToDate]) VALUES (19, 1, 5, N'Devoloper', N'SuperNova', CAST(N'2024-04-30T00:00:00.0000000' AS DateTime2), CAST(N'2024-05-16T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[FreelancerExperienceTable] ([FreelancerExperienceId], [FreelancerId], [ExperienceInMonths], [RoleName], [CompanyName], [FromDate], [ToDate]) VALUES (20, 1, 6, N'Cashier', N'Climaxtech', CAST(N'2024-04-30T00:00:00.0000000' AS DateTime2), CAST(N'2024-05-13T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[FreelancerExperienceTable] OFF
GO
SET IDENTITY_INSERT [dbo].[FreelancerFAQTable] ON 

INSERT [dbo].[FreelancerFAQTable] ([FreelancerFAQId], [FAQ], [Answer], [AddedDate]) VALUES (1, N'What is your name', N'Mike', CAST(N'2024-04-25T18:17:33.0457069' AS DateTime2))
SET IDENTITY_INSERT [dbo].[FreelancerFAQTable] OFF
GO
SET IDENTITY_INSERT [dbo].[FreelancerPriviousProjectsTable] ON 

INSERT [dbo].[FreelancerPriviousProjectsTable] ([FreelancerPriviousProjectsId], [FreelancerId], [ProjectTitle], [ProjectDescription]) VALUES (1, 1, N'ERP', N'Enterprise Resource Planning')
INSERT [dbo].[FreelancerPriviousProjectsTable] ([FreelancerPriviousProjectsId], [FreelancerId], [ProjectTitle], [ProjectDescription]) VALUES (2, 1, N'DL', N'Deep Leanring')
INSERT [dbo].[FreelancerPriviousProjectsTable] ([FreelancerPriviousProjectsId], [FreelancerId], [ProjectTitle], [ProjectDescription]) VALUES (3, 1, N'GenAI', N'Genrative Artificial Intelligence')
INSERT [dbo].[FreelancerPriviousProjectsTable] ([FreelancerPriviousProjectsId], [FreelancerId], [ProjectTitle], [ProjectDescription]) VALUES (5, 1, N'ML', N'Machine Learning')
SET IDENTITY_INSERT [dbo].[FreelancerPriviousProjectsTable] OFF
GO
SET IDENTITY_INSERT [dbo].[FreelancerTable] ON 

INSERT [dbo].[FreelancerTable] ([FreelancerId], [FirstName], [LastName], [EmailId], [MobileNo], [Address], [Password]) VALUES (1, N'Chris', N'Bumstead', N'Freelancer@gmail.com', N'9922334455', N'Akurdi,Pune', N'Freelancer')
INSERT [dbo].[FreelancerTable] ([FreelancerId], [FirstName], [LastName], [EmailId], [MobileNo], [Address], [Password]) VALUES (2, N'Shivam', N'Ingle', N'shivam@gmail.com', NULL, NULL, N'abcd')
SET IDENTITY_INSERT [dbo].[FreelancerTable] OFF
GO
SET IDENTITY_INSERT [dbo].[LocationTable] ON 

INSERT [dbo].[LocationTable] ([LocationId], [LocationName], [CityId]) VALUES (1, N'Yao', 8)
INSERT [dbo].[LocationTable] ([LocationId], [LocationName], [CityId]) VALUES (2, N'Hoboken', 4)
INSERT [dbo].[LocationTable] ([LocationId], [LocationName], [CityId]) VALUES (3, N'Harrow', 6)
INSERT [dbo].[LocationTable] ([LocationId], [LocationName], [CityId]) VALUES (4, N'Edison', 4)
INSERT [dbo].[LocationTable] ([LocationId], [LocationName], [CityId]) VALUES (5, N'Yahate', 5)
INSERT [dbo].[LocationTable] ([LocationId], [LocationName], [CityId]) VALUES (6, N'Yemma', 6)
INSERT [dbo].[LocationTable] ([LocationId], [LocationName], [CityId]) VALUES (7, N'Calton hill', 7)
INSERT [dbo].[LocationTable] ([LocationId], [LocationName], [CityId]) VALUES (8, N'Humble', 1)
INSERT [dbo].[LocationTable] ([LocationId], [LocationName], [CityId]) VALUES (9, N'Royal Mile', 7)
INSERT [dbo].[LocationTable] ([LocationId], [LocationName], [CityId]) VALUES (11, N'Yao', 11)
SET IDENTITY_INSERT [dbo].[LocationTable] OFF
GO
SET IDENTITY_INSERT [dbo].[PaymentModeTable] ON 

INSERT [dbo].[PaymentModeTable] ([PaymentModeId], [PayMode]) VALUES (4, N'Credit Card')
INSERT [dbo].[PaymentModeTable] ([PaymentModeId], [PayMode]) VALUES (5, N'PayPal')
INSERT [dbo].[PaymentModeTable] ([PaymentModeId], [PayMode]) VALUES (6, N'Bank Transfer')
INSERT [dbo].[PaymentModeTable] ([PaymentModeId], [PayMode]) VALUES (7, N'Online Payment Gateway')
INSERT [dbo].[PaymentModeTable] ([PaymentModeId], [PayMode]) VALUES (8, N'Cryptocurrency')
SET IDENTITY_INSERT [dbo].[PaymentModeTable] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectApplicationsTable] ON 

INSERT [dbo].[ProjectApplicationsTable] ([ProjectApplicationId], [FreelancerId], [ProjectId], [ApplicationDate], [ApplicationTitle]) VALUES (1, 1, 17, CAST(N'2024-05-10T19:14:15.9581446' AS DateTime2), N'Digital Marckerting job')
INSERT [dbo].[ProjectApplicationsTable] ([ProjectApplicationId], [FreelancerId], [ProjectId], [ApplicationDate], [ApplicationTitle]) VALUES (2, 2, 15, CAST(N'2024-05-10T19:16:18.3358702' AS DateTime2), N'Corporate Blog')
INSERT [dbo].[ProjectApplicationsTable] ([ProjectApplicationId], [FreelancerId], [ProjectId], [ApplicationDate], [ApplicationTitle]) VALUES (5, 1, 14, CAST(N'2024-05-16T17:28:33.9459157' AS DateTime2), N'Task Management System')
INSERT [dbo].[ProjectApplicationsTable] ([ProjectApplicationId], [FreelancerId], [ProjectId], [ApplicationDate], [ApplicationTitle]) VALUES (6, 2, 17, CAST(N'2024-05-16T17:30:04.2006609' AS DateTime2), N'Digital Marketing Campain')
INSERT [dbo].[ProjectApplicationsTable] ([ProjectApplicationId], [FreelancerId], [ProjectId], [ApplicationDate], [ApplicationTitle]) VALUES (16, 1, 21, CAST(N'2024-05-25T17:07:53.9182533' AS DateTime2), N'E-Learning System')
INSERT [dbo].[ProjectApplicationsTable] ([ProjectApplicationId], [FreelancerId], [ProjectId], [ApplicationDate], [ApplicationTitle]) VALUES (17, 1, 10, CAST(N'2024-06-02T17:51:02.0860322' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[ProjectApplicationsTable] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectAssignedTable] ON 

INSERT [dbo].[ProjectAssignedTable] ([ProjectAssignedId], [SelectedApplicationId], [SelectedApplicationsSelectedApplicationId], [ProjectId], [ApplicationDate], [ApplicationTitle]) VALUES (3, 6, NULL, 17, CAST(N'2024-05-15T00:00:00.0000000' AS DateTime2), N'Test Application 1')
INSERT [dbo].[ProjectAssignedTable] ([ProjectAssignedId], [SelectedApplicationId], [SelectedApplicationsSelectedApplicationId], [ProjectId], [ApplicationDate], [ApplicationTitle]) VALUES (4, 11, NULL, 17, CAST(N'2024-05-30T00:00:00.0000000' AS DateTime2), N'Task Management System')
SET IDENTITY_INSERT [dbo].[ProjectAssignedTable] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectDocumentTable] ON 

INSERT [dbo].[ProjectDocumentTable] ([ProjectDocumentId], [DocName], [ProjectId], [DocumentFilePath]) VALUES (71, N'ATM Architecture', 10, N'\ProjectDocument\Diagram ATM.png')
SET IDENTITY_INSERT [dbo].[ProjectDocumentTable] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectSkillTable] ON 

INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (1, 10, 1)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (3, 10, 4)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (4, 10, 10)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (5, 11, 3)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (7, 11, 30)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (8, 21, 24)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (9, 21, 31)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (10, 21, 37)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (11, 21, 44)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (12, 12, 1)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (13, 21, 23)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (14, 21, 32)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (15, 21, 52)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (16, 17, 3)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (17, 17, 52)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (18, 12, 12)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (19, 12, 17)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (20, 12, 32)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (21, 12, 49)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (22, 15, 1)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (23, 15, 5)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (24, 15, 12)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (25, 15, 30)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (26, 15, 46)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (27, 15, 52)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (28, 15, 4)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (29, 15, 13)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (30, 15, 20)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (31, 15, 40)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (32, 15, 51)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (33, 21, 26)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (34, 21, 46)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (35, 17, 5)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (36, 17, 9)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (37, 17, 40)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (38, 17, 45)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (39, 17, 51)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (40, 11, 1)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (41, 11, 5)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (42, 11, 11)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (43, 11, 12)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (44, 11, 28)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (45, 11, 52)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (46, 13, 1)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (47, 13, 4)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (48, 13, 5)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (49, 13, 16)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (50, 13, 39)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (51, 13, 46)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (52, 13, 51)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (53, 16, 8)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (54, 16, 25)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (55, 16, 45)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (56, 16, 49)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (57, 16, 52)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (58, 20, 5)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (59, 20, 11)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (60, 20, 12)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (61, 20, 17)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (62, 20, 51)
INSERT [dbo].[ProjectSkillTable] ([ProjectSkillId], [ProjectId], [SkillId]) VALUES (63, 20, 52)
SET IDENTITY_INSERT [dbo].[ProjectSkillTable] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectStagesTable] ON 

INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (109, N' Requirement Analysis', 12, 15, N'Conduct meetings with ABC Bank stakeholders to gather detailed requirements. Document all functional and non-functional requirements.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (110, N'System and UI Design', 12, 15, N'Design the software architecture and user interface. Create detailed design documents and prototypes for client approval.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (112, N'Planning', 13, 40, N'Define project objectives, scope, and requirements. Conduct market research and competitor analysis.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (113, N'Design', 13, 80, N'Create wireframes, mockups, and prototypes for website layout, user interface, and navigation.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (114, N'Development	', 13, 160, N'Write code for frontend and backend functionalities. Implement features like product catalog, shopping cart, etc.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (115, N'Testing', 13, 40, N'Conduct thorough testing to identify and fix bugs, ensure functionality across different devices and browsers.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (116, N'Deployment', 13, 20, N'Prepare the website for launch, configure hosting, domain setup, and deploy the final version of the e-commerce site.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (117, N'Planning', 14, 60, N'Define project goals, user requirements, and technical specifications. Conduct user research and create a project plan.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (120, N'Testing	', 14, 60, N'Conduct extensive testing to identify and fix bugs, ensure usability, performance, and compatibility across devices.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (121, N'Deployment', 14, 40, N'Prepare the app for release, configure app store listings, and deploy the final version of the task management app.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (127, N'Planning', 15, 30, N'Define campaign goals, target audience, messaging strategy, and budget allocation for social media promotion', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (128, N'Content Creation', 15, 60, N'Develop engaging and relevant content for social media platforms including posts, graphics, videos, and promotional copy.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (130, N'Campaign Management', 15, 80, N'Monitor campaign performance, optimize ad creatives, adjust targeting, and manage budget allocation based on results.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (132, N'Planning', 16, 50, N'Define project objectives, gather requirements from stakeholders, and create a detailed project plan for the inventory management system.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (133, N'Design', 16, 80, N'Design the user interface (UI), database schema, and system architecture for the inventory management system. This includes creating wireframes, mockups, and ER diagrams.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (134, N'Development', 16, 200, N'Develop the frontend and backend components of the inventory management system, including features such as product management, inventory tracking, and reporting functionalities.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (135, N'Testing', 16, 70, N'Conduct thorough testing of the inventory management system to identify and fix bugs, ensure functionality, and validate against user requirements.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (136, N'Deployment', 16, 50, N'Prepare the inventory management system for deployment, configure servers, and deploy the system to production environment. Conduct final checks to ensure everything is running smoothly.', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (137, N'Stage1', 10, 12, N'ABCD', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (138, N'Statge2', 10, 13, N'EFGH', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (139, N'Stage3', 10, 14, N'JKLM', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (142, N'Planning', 21, 13, N'test1', NULL)
INSERT [dbo].[ProjectStagesTable] ([ProjectStageId], [ProjectStageName], [ProjectId], [DurationInHours], [StageDescription], [ProjectStageId1]) VALUES (144, N'Discussion', 21, 15, N'test3', NULL)
SET IDENTITY_INSERT [dbo].[ProjectStagesTable] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectTable] ON 

INSERT [dbo].[ProjectTable] ([ProjectId], [ProjectName], [ProjectDescription], [CompanyId], [ProjectStatus], [ProjectPaymentTerms], [ProjectTermsAndConditions], [Budget], [ExpectedCompletionDurationInDays]) VALUES (10, N'ATM Software Development', N'Develop secure and efficient software for a new generation of ATMs for ABC Bank. The software should support basic transactions like withdrawals, deposits, balance inquiries, and fund transfers, as well as advanced features such as check scanning and mobile wallet integration.', 2, 3, 1, N'The software must comply with all industry security standards and regulations.
Regular updates and maintenance must be provided post-deployment.
Payments will be made upon the successful completion of each stage.
Any additional features requested mid-project will require a new agreement.
The software code will be the property of ABC Bank.', CAST(50000.00 AS Decimal(18, 2)), 120)
INSERT [dbo].[ProjectTable] ([ProjectId], [ProjectName], [ProjectDescription], [CompanyId], [ProjectStatus], [ProjectPaymentTerms], [ProjectTermsAndConditions], [Budget], [ExpectedCompletionDurationInDays]) VALUES (11, N'School Bus Management System', N'Develop a comprehensive and user-friendly website for managing school bus operations. The system should include features for route planning, real-time bus tracking, student management, and communication with parents and school administrators.', 19, 2, 3, N'Develop a comprehensive and user-friendly website for managing school bus operations. The system should include features for route planning, real-time bus tracking, student management, and communication with parents and school administrators.', CAST(75000.00 AS Decimal(18, 2)), 90)
INSERT [dbo].[ProjectTable] ([ProjectId], [ProjectName], [ProjectDescription], [CompanyId], [ProjectStatus], [ProjectPaymentTerms], [ProjectTermsAndConditions], [Budget], [ExpectedCompletionDurationInDays]) VALUES (12, N'Event Management Software', N'Develop a comprehensive and user-friendly software solution for managing events. The system should include features for event scheduling, attendee registration, ticketing, venue management, communication with attendees, and analytics.', 2, 3, 1, N'All deliverables must be approved by the client.
Payments will be made upon the successful completion of each project stage.
Any changes or additional features requested by the client after the initial agreement may incur additional charges.
Confidentiality must be maintained for all project-related information.
The software code and all intellectual property developed during the project will belong to the client.', CAST(200000.00 AS Decimal(18, 2)), 120)
INSERT [dbo].[ProjectTable] ([ProjectId], [ProjectName], [ProjectDescription], [CompanyId], [ProjectStatus], [ProjectPaymentTerms], [ProjectTermsAndConditions], [Budget], [ExpectedCompletionDurationInDays]) VALUES (13, N'E-Commerce Website Development', N'Develop a responsive e-commerce website for selling fashion apparel and accessories. The website should include features such as product catalog, user authentication, shopping cart, checkout, and integration with payment gateway for secure transactions.', 19, 1, 3, N'All deliverables must meet the specified requirements outlined in the project scope.
Any changes to the project scope must be approved in writing and may result in adjustments to the project timeline and budget.
The client will provide necessary assets such as logos, images, and content for the website.
Payment will be made in three installments: 30% upfront, 30% upon completion of design phase, and 40% upon final project delivery.', CAST(100000.00 AS Decimal(18, 2)), 60)
INSERT [dbo].[ProjectTable] ([ProjectId], [ProjectName], [ProjectDescription], [CompanyId], [ProjectStatus], [ProjectPaymentTerms], [ProjectTermsAndConditions], [Budget], [ExpectedCompletionDurationInDays]) VALUES (14, N'Task Management System Application', N' Develop a mobile application for task management, allowing users to create, assign, and track tasks within teams. The app should have features like task categorization, deadline reminders, user roles and permissions, and synchronization across devices.', 2, 2, 2, N'The application should be compatible with both iOS and Android platforms.
Regular progress updates and demonstrations are required every two weeks.
Any bugs or issues discovered during testing should be resolved promptly.
Payment will be made in four installments: 25% upfront, 25% upon completion of UI design, 25% upon completion of development, and 25% upon successful testing and deployment.', CAST(200000.00 AS Decimal(18, 2)), 90)
INSERT [dbo].[ProjectTable] ([ProjectId], [ProjectName], [ProjectDescription], [CompanyId], [ProjectStatus], [ProjectPaymentTerms], [ProjectTermsAndConditions], [Budget], [ExpectedCompletionDurationInDays]) VALUES (15, N'Corporate Blog Website', N'Redesign an existing corporate blog website to improve user experience and modernize the design. The new website should have a clean and intuitive interface, optimized for desktop and mobile devices, with features like content categorization, social media integration, and SEO-friendly structure.', 2, 2, 2, N'he redesign should maintain the branding consistency of the company.
The website should be built on a content management system (CMS) for easy content updates by the client.
All existing content and URLs should be migrated seamlessly to the new website.
Payment will be made in two installments: 50% upfront and 50% upon final website launch and acceptance.', CAST(80000.00 AS Decimal(18, 2)), 45)
INSERT [dbo].[ProjectTable] ([ProjectId], [ProjectName], [ProjectDescription], [CompanyId], [ProjectStatus], [ProjectPaymentTerms], [ProjectTermsAndConditions], [Budget], [ExpectedCompletionDurationInDays]) VALUES (16, N'Inventory Management System Software', N'Develop a comprehensive inventory management system for a retail business. The system should track inventory levels, manage product information, handle purchase orders, generate sales reports, and integrate with barcode scanners for efficient stock management.', 19, 5, 3, N'The system should support multiple user roles with customizable permissions.
Integration with existing accounting software for seamless financial reporting is required.
User training and documentation should be provided upon system deployment.
Payment will be made in three installments: 30% upfront, 40% upon completion of core functionalities, and 30% upon successful system testing and implementation.', CAST(15000.00 AS Decimal(18, 2)), 75)
INSERT [dbo].[ProjectTable] ([ProjectId], [ProjectName], [ProjectDescription], [CompanyId], [ProjectStatus], [ProjectPaymentTerms], [ProjectTermsAndConditions], [Budget], [ExpectedCompletionDurationInDays]) VALUES (17, N'Social Media Promotion Website', N'reate and execute a digital marketing campaign to promote a new product launch on social media platforms. The campaign should include strategies for content creation, audience targeting, engagement tracking, and performance analysis across platforms like Facebook, Instagram, Twitter, and LinkedIn.', 2, 3, 3, N'The campaign should align with the brand''s messaging and positioning.
Regular performance reports and analytics insights should be provided throughout the campaign.
Ad spend and campaign budget allocation should be optimized for maximum ROI.
Payment will be made in two installments: 50% upfront and 50% upon completion of the campaign and delivery of performance metrics.', CAST(50000.00 AS Decimal(18, 2)), 30)
INSERT [dbo].[ProjectTable] ([ProjectId], [ProjectName], [ProjectDescription], [CompanyId], [ProjectStatus], [ProjectPaymentTerms], [ProjectTermsAndConditions], [Budget], [ExpectedCompletionDurationInDays]) VALUES (20, N'ERP Website Development', N'This project involves the design, development, and deployment of an Enterprise Resource Planning (ERP) website. The website will feature modules for inventory management, customer relationship management (CRM), human resources (HR), accounting, and sales. The goal is to create a comprehensive, user-friendly platform that integrates all essential business processes to enhance efficiency and data management.', 19, 2, 1, N'Scope of Work: The project scope includes website design, development, testing, and deployment. Any additional features or changes requested beyond the initial requirements will be subject to additional charges.
Confidentiality: Both parties agree to keep all information exchanged during the project confidential.
Ownership: Upon final payment, the client will own all rights to the website, including source code and documentation.
Maintenance and Support: Post-deployment support will be provided for 3 months to fix any bugs or issues. Extended support and maintenance contracts can be negotiated separately.
Project Delays: Any delays caused by the client (e.g., late feedback or content delivery) will result in a revised project timeline.
Payment Schedule: Payments must be made within 15 days of the invoice date. Late payments may incur additional fees.
Termination: Either party may terminate the agreement with a 30-day written notice. The client will pay for all work completed up to the termination date.', CAST(250000.00 AS Decimal(18, 2)), 270)
INSERT [dbo].[ProjectTable] ([ProjectId], [ProjectName], [ProjectDescription], [CompanyId], [ProjectStatus], [ProjectPaymentTerms], [ProjectTermsAndConditions], [Budget], [ExpectedCompletionDurationInDays]) VALUES (21, N'E- Learning Platform', N'Description', 2, 5, 3, N'ABCD', CAST(250000.00 AS Decimal(18, 2)), 14)
SET IDENTITY_INSERT [dbo].[ProjectTable] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectTaskAssignmentTable] ON 

INSERT [dbo].[ProjectTaskAssignmentTable] ([ProjectTaskAssignementId], [ProjectTaskId], [FreelancerId], [AssignedDate], [ExpectedCompletionDate]) VALUES (1, 7, 1, CAST(N'2024-05-16T00:00:00.0000000' AS DateTime2), CAST(N'2024-05-31T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProjectTaskAssignmentTable] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectTaskDocumentTable] ON 

INSERT [dbo].[ProjectTaskDocumentTable] ([ProjectTaskDocumentId], [ProjectTaskId], [ProjectDocumentFilePath], [DocName]) VALUES (9, 5, N'\ProjectTaskDocument\3nf.jpg', N'ATM Architecture')
SET IDENTITY_INSERT [dbo].[ProjectTaskDocumentTable] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectTaskTable] ON 

INSERT [dbo].[ProjectTaskTable] ([ProjectTaskId], [TaskTitle], [ProjectId], [TaskDescription], [TaskAmount], [TaskStatus]) VALUES (5, N'Take Requirement from ATM User', 12, N'What can be the Test Cases here', CAST(140000.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[ProjectTaskTable] ([ProjectTaskId], [TaskTitle], [ProjectId], [TaskDescription], [TaskAmount], [TaskStatus]) VALUES (6, N'Create Poll Chit List', 11, N'Creation of Necessary Documentation', CAST(13000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProjectTaskTable] ([ProjectTaskId], [TaskTitle], [ProjectId], [TaskDescription], [TaskAmount], [TaskStatus]) VALUES (7, N'Collect Information from area', 17, N'Information must be collected from the voluntary persons', CAST(14000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProjectTaskTable] ([ProjectTaskId], [TaskTitle], [ProjectId], [TaskDescription], [TaskAmount], [TaskStatus]) VALUES (9, N'Test Title', 17, N'Test Desc', CAST(13000.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[ProjectTaskTable] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectTechnology] ON 

INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (1, 10, 1)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (2, 10, 2)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (3, 11, 2)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (4, 11, 4)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (5, 11, 9)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (6, 21, 10)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (7, 21, 11)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (8, 21, 12)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (9, 12, 1)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (10, 21, 9)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (11, 17, 1)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (12, 17, 11)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (13, 17, 12)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (14, 12, 4)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (15, 14, 4)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (16, 14, 9)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (17, 14, 11)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (18, 15, 4)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (19, 15, 6)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (20, 15, 10)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (21, 21, 6)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (22, 15, 2)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (23, 15, 11)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (24, 11, 5)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (25, 11, 11)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (26, 11, 12)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (27, 13, 1)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (28, 13, 7)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (29, 13, 12)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (30, 16, 1)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (31, 16, 5)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (32, 16, 11)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (33, 16, 4)
INSERT [dbo].[ProjectTechnology] ([ProjectTechnologyId], [ProjectId], [TechnologiesId]) VALUES (34, 16, 12)
SET IDENTITY_INSERT [dbo].[ProjectTechnology] OFF
GO
SET IDENTITY_INSERT [dbo].[SelectedApplicationTable] ON 

INSERT [dbo].[SelectedApplicationTable] ([SelectedApplicationId], [ProjectApplicationId], [ProjectApplicationsProjectApplicationId], [SelectionDate], [NeedStartDate], [AnyRemark]) VALUES (6, 1, NULL, CAST(N'2024-05-15T11:31:38.1770928' AS DateTime2), CAST(N'2024-05-30T00:00:00.0000000' AS DateTime2), N'Must Need To Start Within Given Time Span')
INSERT [dbo].[SelectedApplicationTable] ([SelectedApplicationId], [ProjectApplicationId], [ProjectApplicationsProjectApplicationId], [SelectionDate], [NeedStartDate], [AnyRemark]) VALUES (7, 2, NULL, CAST(N'2024-05-15T11:32:35.0648202' AS DateTime2), CAST(N'2024-05-30T00:00:00.0000000' AS DateTime2), N'Carry necessary document on joining date.')
INSERT [dbo].[SelectedApplicationTable] ([SelectedApplicationId], [ProjectApplicationId], [ProjectApplicationsProjectApplicationId], [SelectionDate], [NeedStartDate], [AnyRemark]) VALUES (11, 1, NULL, CAST(N'2024-05-24T18:27:36.1413248' AS DateTime2), CAST(N'2024-05-31T00:00:00.0000000' AS DateTime2), N'Remark 1')
INSERT [dbo].[SelectedApplicationTable] ([SelectedApplicationId], [ProjectApplicationId], [ProjectApplicationsProjectApplicationId], [SelectionDate], [NeedStartDate], [AnyRemark]) VALUES (12, 15, NULL, CAST(N'2024-05-25T17:03:48.4660800' AS DateTime2), CAST(N'2024-05-31T00:00:00.0000000' AS DateTime2), N'You Are Suitable For Job')
SET IDENTITY_INSERT [dbo].[SelectedApplicationTable] OFF
GO
SET IDENTITY_INSERT [dbo].[SkillCategoryTable] ON 

INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (1, N'Programming Languages')
INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (2, N'Data Analytics')
INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (3, N'Reaserch')
INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (4, N'Web Development Frameworks')
INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (5, N'Mobile Development Platforms')
INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (6, N'Database Management')
INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (7, N'Data Analysis and Visualization')
INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (8, N'Machine Learning and Artificial Intelligence')
INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (9, N'Cybersecurity')
INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (10, N'DevOps Tools and Practices')
INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (11, N'UI/UX Design')
INSERT [dbo].[SkillCategoryTable] ([SkillCategoryId], [SkillCategoryName]) VALUES (12, N'Quality Assurance (QA) and Testing')
SET IDENTITY_INSERT [dbo].[SkillCategoryTable] OFF
GO
SET IDENTITY_INSERT [dbo].[SkillTable] ON 

INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (1, N'C#', 1)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (3, N'Core Java', 2)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (4, N'Advanced Java', 1)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (5, N'JavaScript', 1)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (6, N'C++', 1)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (7, N'C', 1)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (8, N'Ruby', 1)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (9, N'PHP', 1)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (10, N'Kotlin', 1)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (11, N'React.js', 4)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (12, N'Angular', 4)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (13, N'Vue.js', 4)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (14, N'Django', 4)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (15, N'Flask', 4)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (16, N'Ruby on Rails', 4)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (17, N'ASP.NET', 4)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (18, N'iOS Development (Swift, Objective-C)', 5)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (19, N'Android Development (Java, Kotlin)', 5)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (20, N'React Native', 5)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (21, N'Flutter', 5)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (22, N'xamarin', 5)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (23, N'SQL', 6)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (24, N'MySQL', 6)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (25, N'PostgreSQL', 6)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (26, N'MongoDB', 6)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (27, N'Oracle', 6)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (28, N'Python (Pandas, NumPy)', 7)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (29, N'R', 7)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (30, N'SQL', 7)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (31, N'Tableau', 7)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (32, N'Power BI', 7)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (33, N'Ethical Hacking', 9)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (34, N'Penetration Testing y', 9)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (35, N'Network Security', 9)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (36, N'Incident Response', 9)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (37, N'Cryptography', 9)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (38, N'Docker', 10)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (39, N'Kubernetes', 10)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (40, N'Jenkins', 10)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (41, N'Ansible', 10)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (42, N'Terraform', 10)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (43, N'Adobe XD', 11)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (44, N'Sketch', 11)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (45, N'Figma', 11)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (46, N'InVision', 11)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (47, N'User Research', 11)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (48, N'Test Automation (Selenium, Appium, Cypress)', 12)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (49, N'Manual Testing', 12)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (50, N'Performance Testing', 12)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (51, N'Security Testing', 12)
INSERT [dbo].[SkillTable] ([SkillId], [SkillName], [SkillCategoryId]) VALUES (52, N'API Testing (Postman, SoapUI)', 12)
SET IDENTITY_INSERT [dbo].[SkillTable] OFF
GO
SET IDENTITY_INSERT [dbo].[StateTable] ON 

INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (3, N'Taxes', 3)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (5, N'New york', 2)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (6, N'Calfornia', 2)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (7, N'Illionis', 2)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (8, N'England', 5)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (9, N'Scotland', 2)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (10, N'Greater Manchester', 3)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (11, N'Tokyo Prefecture', 4)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (12, N'Osaka Prefecture', 4)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (13, N'Kyoto Prefecture', 4)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (14, N'New South Wales', 5)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (15, N'Victoria', 5)
INSERT [dbo].[StateTable] ([StateId], [StateName], [CountryId]) VALUES (16, N'Queensland', 4)
SET IDENTITY_INSERT [dbo].[StateTable] OFF
GO
SET IDENTITY_INSERT [dbo].[TechnologiesTable] ON 

INSERT [dbo].[TechnologiesTable] ([TechnologiesId], [TechnologyName]) VALUES (1, N'Artificial Intelligence and Machine Learning')
INSERT [dbo].[TechnologiesTable] ([TechnologiesId], [TechnologyName]) VALUES (2, N'Neural Network')
INSERT [dbo].[TechnologiesTable] ([TechnologiesId], [TechnologyName]) VALUES (4, N'Web Development')
INSERT [dbo].[TechnologiesTable] ([TechnologiesId], [TechnologyName]) VALUES (5, N'Mobile App Development')
INSERT [dbo].[TechnologiesTable] ([TechnologiesId], [TechnologyName]) VALUES (6, N'Cloud Computing')
INSERT [dbo].[TechnologiesTable] ([TechnologiesId], [TechnologyName]) VALUES (7, N'Data Science and Analytics')
INSERT [dbo].[TechnologiesTable] ([TechnologiesId], [TechnologyName]) VALUES (8, N'Cybersecurity')
INSERT [dbo].[TechnologiesTable] ([TechnologiesId], [TechnologyName]) VALUES (9, N'DevOps')
INSERT [dbo].[TechnologiesTable] ([TechnologiesId], [TechnologyName]) VALUES (10, N'Blockchain')
INSERT [dbo].[TechnologiesTable] ([TechnologiesId], [TechnologyName]) VALUES (11, N'UI/UX Design')
INSERT [dbo].[TechnologiesTable] ([TechnologiesId], [TechnologyName]) VALUES (12, N'Quality Assurance (QA) and Testing')
SET IDENTITY_INSERT [dbo].[TechnologiesTable] OFF
GO
SET IDENTITY_INSERT [dbo].[TermsAndConditionsForCompany] ON 

INSERT [dbo].[TermsAndConditionsForCompany] ([TNCCompanyId], [CompanyRule], [AddedDate]) VALUES (1, N'Uniform is compulsory', CAST(N'2024-04-25T18:17:47.0051491' AS DateTime2))
SET IDENTITY_INSERT [dbo].[TermsAndConditionsForCompany] OFF
GO
SET IDENTITY_INSERT [dbo].[TermsAndConditionsForFreelancer] ON 

INSERT [dbo].[TermsAndConditionsForFreelancer] ([TNCFreelancerId], [FreelancerRule], [AddedDate]) VALUES (1, N'Id Is Compulsory', CAST(N'2024-04-25T18:18:08.9752783' AS DateTime2))
SET IDENTITY_INSERT [dbo].[TermsAndConditionsForFreelancer] OFF
GO
ALTER TABLE [dbo].[FreelancerExperienceTable] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [FromDate]
GO
ALTER TABLE [dbo].[FreelancerExperienceTable] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ToDate]
GO
ALTER TABLE [dbo].[CityTable]  WITH CHECK ADD  CONSTRAINT [FK_CityTable_StateTable_StateId] FOREIGN KEY([StateId])
REFERENCES [dbo].[StateTable] ([StateId])
GO
ALTER TABLE [dbo].[CityTable] CHECK CONSTRAINT [FK_CityTable_StateTable_StateId]
GO
ALTER TABLE [dbo].[CompanyTable]  WITH CHECK ADD  CONSTRAINT [FK_CompanyTable_CityTable_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[CityTable] ([CityId])
GO
ALTER TABLE [dbo].[CompanyTable] CHECK CONSTRAINT [FK_CompanyTable_CityTable_CityId]
GO
ALTER TABLE [dbo].[FinishedProjectTable]  WITH CHECK ADD  CONSTRAINT [FK_FinishedProjectTable_ProjectTable_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[ProjectTable] ([ProjectId])
GO
ALTER TABLE [dbo].[FinishedProjectTable] CHECK CONSTRAINT [FK_FinishedProjectTable_ProjectTable_ProjectId]
GO
ALTER TABLE [dbo].[FreelancerCertificationTable]  WITH CHECK ADD  CONSTRAINT [FK_FreelancerCertificationTable_FreelancerTable_FreelancerId] FOREIGN KEY([FreelancerId])
REFERENCES [dbo].[FreelancerTable] ([FreelancerId])
GO
ALTER TABLE [dbo].[FreelancerCertificationTable] CHECK CONSTRAINT [FK_FreelancerCertificationTable_FreelancerTable_FreelancerId]
GO
ALTER TABLE [dbo].[FreelancerEducationTable]  WITH CHECK ADD  CONSTRAINT [FK_FreelancerEducationTable_EducationTable_EducationId] FOREIGN KEY([EducationId])
REFERENCES [dbo].[EducationTable] ([EducationId])
GO
ALTER TABLE [dbo].[FreelancerEducationTable] CHECK CONSTRAINT [FK_FreelancerEducationTable_EducationTable_EducationId]
GO
ALTER TABLE [dbo].[FreelancerEducationTable]  WITH CHECK ADD  CONSTRAINT [FK_FreelancerEducationTable_FreelancerTable_FreelancerId] FOREIGN KEY([FreelancerId])
REFERENCES [dbo].[FreelancerTable] ([FreelancerId])
GO
ALTER TABLE [dbo].[FreelancerEducationTable] CHECK CONSTRAINT [FK_FreelancerEducationTable_FreelancerTable_FreelancerId]
GO
ALTER TABLE [dbo].[FreelancerExperienceTable]  WITH CHECK ADD  CONSTRAINT [FK_FreelancerExperienceTable_FreelancerTable_FreelancerId] FOREIGN KEY([FreelancerId])
REFERENCES [dbo].[FreelancerTable] ([FreelancerId])
GO
ALTER TABLE [dbo].[FreelancerExperienceTable] CHECK CONSTRAINT [FK_FreelancerExperienceTable_FreelancerTable_FreelancerId]
GO
ALTER TABLE [dbo].[FreelancerPriviousProjectsTable]  WITH CHECK ADD  CONSTRAINT [FK_FreelancerPriviousProjectsTable_FreelancerTable_FreelancerId] FOREIGN KEY([FreelancerId])
REFERENCES [dbo].[FreelancerTable] ([FreelancerId])
GO
ALTER TABLE [dbo].[FreelancerPriviousProjectsTable] CHECK CONSTRAINT [FK_FreelancerPriviousProjectsTable_FreelancerTable_FreelancerId]
GO
ALTER TABLE [dbo].[LocationTable]  WITH CHECK ADD  CONSTRAINT [FK_LocationTable_CityTable_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[CityTable] ([CityId])
GO
ALTER TABLE [dbo].[LocationTable] CHECK CONSTRAINT [FK_LocationTable_CityTable_CityId]
GO
ALTER TABLE [dbo].[ProjectApplicationsTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectApplicationsTable_FreelancerTable_FreelancerId] FOREIGN KEY([FreelancerId])
REFERENCES [dbo].[FreelancerTable] ([FreelancerId])
GO
ALTER TABLE [dbo].[ProjectApplicationsTable] CHECK CONSTRAINT [FK_ProjectApplicationsTable_FreelancerTable_FreelancerId]
GO
ALTER TABLE [dbo].[ProjectApplicationsTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectApplicationsTable_ProjectTable_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[ProjectTable] ([ProjectId])
GO
ALTER TABLE [dbo].[ProjectApplicationsTable] CHECK CONSTRAINT [FK_ProjectApplicationsTable_ProjectTable_ProjectId]
GO
ALTER TABLE [dbo].[ProjectAssignedTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAssignedTable_ProjectTable_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[ProjectTable] ([ProjectId])
GO
ALTER TABLE [dbo].[ProjectAssignedTable] CHECK CONSTRAINT [FK_ProjectAssignedTable_ProjectTable_ProjectId]
GO
ALTER TABLE [dbo].[ProjectAssignedTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAssignedTable_SelectedApplicationTable_SelectedApplicationsSelectedApplicationId] FOREIGN KEY([SelectedApplicationsSelectedApplicationId])
REFERENCES [dbo].[SelectedApplicationTable] ([SelectedApplicationId])
GO
ALTER TABLE [dbo].[ProjectAssignedTable] CHECK CONSTRAINT [FK_ProjectAssignedTable_SelectedApplicationTable_SelectedApplicationsSelectedApplicationId]
GO
ALTER TABLE [dbo].[ProjectDocumentTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectDocumentTable_ProjectTable_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[ProjectTable] ([ProjectId])
GO
ALTER TABLE [dbo].[ProjectDocumentTable] CHECK CONSTRAINT [FK_ProjectDocumentTable_ProjectTable_ProjectId]
GO
ALTER TABLE [dbo].[ProjectSkillTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectSkillTable_ProjectTable_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[ProjectTable] ([ProjectId])
GO
ALTER TABLE [dbo].[ProjectSkillTable] CHECK CONSTRAINT [FK_ProjectSkillTable_ProjectTable_ProjectId]
GO
ALTER TABLE [dbo].[ProjectSkillTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectSkillTable_SkillTable_SkillId] FOREIGN KEY([SkillId])
REFERENCES [dbo].[SkillTable] ([SkillId])
GO
ALTER TABLE [dbo].[ProjectSkillTable] CHECK CONSTRAINT [FK_ProjectSkillTable_SkillTable_SkillId]
GO
ALTER TABLE [dbo].[ProjectStagesTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStagesTable_ProjectStagesTable_ProjectStageId1] FOREIGN KEY([ProjectStageId1])
REFERENCES [dbo].[ProjectStagesTable] ([ProjectStageId])
GO
ALTER TABLE [dbo].[ProjectStagesTable] CHECK CONSTRAINT [FK_ProjectStagesTable_ProjectStagesTable_ProjectStageId1]
GO
ALTER TABLE [dbo].[ProjectStagesTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStagesTable_ProjectTable_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[ProjectTable] ([ProjectId])
GO
ALTER TABLE [dbo].[ProjectStagesTable] CHECK CONSTRAINT [FK_ProjectStagesTable_ProjectTable_ProjectId]
GO
ALTER TABLE [dbo].[ProjectTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTable_CompanyTable_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[CompanyTable] ([CompanyId])
GO
ALTER TABLE [dbo].[ProjectTable] CHECK CONSTRAINT [FK_ProjectTable_CompanyTable_CompanyId]
GO
ALTER TABLE [dbo].[ProjectTaskAssignmentTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskAssignmentTable_FreelancerTable_FreelancerId] FOREIGN KEY([FreelancerId])
REFERENCES [dbo].[FreelancerTable] ([FreelancerId])
GO
ALTER TABLE [dbo].[ProjectTaskAssignmentTable] CHECK CONSTRAINT [FK_ProjectTaskAssignmentTable_FreelancerTable_FreelancerId]
GO
ALTER TABLE [dbo].[ProjectTaskAssignmentTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskAssignmentTable_ProjectTaskTable_ProjectTaskId] FOREIGN KEY([ProjectTaskId])
REFERENCES [dbo].[ProjectTaskTable] ([ProjectTaskId])
GO
ALTER TABLE [dbo].[ProjectTaskAssignmentTable] CHECK CONSTRAINT [FK_ProjectTaskAssignmentTable_ProjectTaskTable_ProjectTaskId]
GO
ALTER TABLE [dbo].[ProjectTaskDocumentTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskDocumentTable_ProjectTaskTable_ProjectTaskId] FOREIGN KEY([ProjectTaskId])
REFERENCES [dbo].[ProjectTaskTable] ([ProjectTaskId])
GO
ALTER TABLE [dbo].[ProjectTaskDocumentTable] CHECK CONSTRAINT [FK_ProjectTaskDocumentTable_ProjectTaskTable_ProjectTaskId]
GO
ALTER TABLE [dbo].[ProjectTaskQuerySolutionTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskQuerySolutionTable_ProjectTaskQueryTable_ProjectTaskQueryId] FOREIGN KEY([ProjectTaskQueryId])
REFERENCES [dbo].[ProjectTaskQueryTable] ([ProjectTaskQueryId])
GO
ALTER TABLE [dbo].[ProjectTaskQuerySolutionTable] CHECK CONSTRAINT [FK_ProjectTaskQuerySolutionTable_ProjectTaskQueryTable_ProjectTaskQueryId]
GO
ALTER TABLE [dbo].[ProjectTaskQueryTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskQueryTable_ProjectTaskTable_ProjectTaskId] FOREIGN KEY([ProjectTaskId])
REFERENCES [dbo].[ProjectTaskTable] ([ProjectTaskId])
GO
ALTER TABLE [dbo].[ProjectTaskQueryTable] CHECK CONSTRAINT [FK_ProjectTaskQueryTable_ProjectTaskTable_ProjectTaskId]
GO
ALTER TABLE [dbo].[ProjectTaskReportConflictSolutionTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskReportConflictSolutionTable_ProjectTaskReportConflictTable_ProjectTaskReportConflictId] FOREIGN KEY([ProjectTaskReportConflictId])
REFERENCES [dbo].[ProjectTaskReportConflictTable] ([ProjectTaskReportConflictId])
GO
ALTER TABLE [dbo].[ProjectTaskReportConflictSolutionTable] CHECK CONSTRAINT [FK_ProjectTaskReportConflictSolutionTable_ProjectTaskReportConflictTable_ProjectTaskReportConflictId]
GO
ALTER TABLE [dbo].[ProjectTaskReportConflictTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskReportConflictTable_ProjectTaskReportTable_ProjectTaskReportId] FOREIGN KEY([ProjectTaskReportId])
REFERENCES [dbo].[ProjectTaskReportTable] ([ProjectTaskReportId])
GO
ALTER TABLE [dbo].[ProjectTaskReportConflictTable] CHECK CONSTRAINT [FK_ProjectTaskReportConflictTable_ProjectTaskReportTable_ProjectTaskReportId]
GO
ALTER TABLE [dbo].[ProjectTaskReportReleasePaymentConflictSolutionTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskReportReleasePaymentConflictSolutionTable_ProjectTaskReportReleasePaymentConflictTable_ProjectTaskReportReleasePa~] FOREIGN KEY([ProjectTaskReportReleasePaymentConflictId])
REFERENCES [dbo].[ProjectTaskReportReleasePaymentConflictTable] ([ProjectTaskReportReleasePaymentConflictId])
GO
ALTER TABLE [dbo].[ProjectTaskReportReleasePaymentConflictSolutionTable] CHECK CONSTRAINT [FK_ProjectTaskReportReleasePaymentConflictSolutionTable_ProjectTaskReportReleasePaymentConflictTable_ProjectTaskReportReleasePa~]
GO
ALTER TABLE [dbo].[ProjectTaskReportReleasePaymentConflictTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskReportReleasePaymentConflictTable_ProjectTaskReportTable_ProjectTaskReportId] FOREIGN KEY([ProjectTaskReportId])
REFERENCES [dbo].[ProjectTaskReportTable] ([ProjectTaskReportId])
GO
ALTER TABLE [dbo].[ProjectTaskReportReleasePaymentConflictTable] CHECK CONSTRAINT [FK_ProjectTaskReportReleasePaymentConflictTable_ProjectTaskReportTable_ProjectTaskReportId]
GO
ALTER TABLE [dbo].[ProjectTaskReportReleasePaymentTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskReportReleasePaymentTable_ProjectTaskReportTable_ProjectTaskReportId] FOREIGN KEY([ProjectTaskReportId])
REFERENCES [dbo].[ProjectTaskReportTable] ([ProjectTaskReportId])
GO
ALTER TABLE [dbo].[ProjectTaskReportReleasePaymentTable] CHECK CONSTRAINT [FK_ProjectTaskReportReleasePaymentTable_ProjectTaskReportTable_ProjectTaskReportId]
GO
ALTER TABLE [dbo].[ProjectTaskReportTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskReportTable_ProjectTaskAssignmentTable_ProjectTaskAssignmentId] FOREIGN KEY([ProjectTaskAssignmentId])
REFERENCES [dbo].[ProjectTaskAssignmentTable] ([ProjectTaskAssignementId])
GO
ALTER TABLE [dbo].[ProjectTaskReportTable] CHECK CONSTRAINT [FK_ProjectTaskReportTable_ProjectTaskAssignmentTable_ProjectTaskAssignmentId]
GO
ALTER TABLE [dbo].[ProjectTaskReportTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskReportTable_ProjectTaskTable_ProjectTaskId] FOREIGN KEY([ProjectTaskId])
REFERENCES [dbo].[ProjectTaskTable] ([ProjectTaskId])
GO
ALTER TABLE [dbo].[ProjectTaskReportTable] CHECK CONSTRAINT [FK_ProjectTaskReportTable_ProjectTaskTable_ProjectTaskId]
GO
ALTER TABLE [dbo].[ProjectTaskTable]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTaskTable_ProjectTable_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[ProjectTable] ([ProjectId])
GO
ALTER TABLE [dbo].[ProjectTaskTable] CHECK CONSTRAINT [FK_ProjectTaskTable_ProjectTable_ProjectId]
GO
ALTER TABLE [dbo].[ProjectTechnology]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTechnology_ProjectTable_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[ProjectTable] ([ProjectId])
GO
ALTER TABLE [dbo].[ProjectTechnology] CHECK CONSTRAINT [FK_ProjectTechnology_ProjectTable_ProjectId]
GO
ALTER TABLE [dbo].[ProjectTechnology]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTechnology_TechnologiesTable_TechnologiesId] FOREIGN KEY([TechnologiesId])
REFERENCES [dbo].[TechnologiesTable] ([TechnologiesId])
GO
ALTER TABLE [dbo].[ProjectTechnology] CHECK CONSTRAINT [FK_ProjectTechnology_TechnologiesTable_TechnologiesId]
GO
ALTER TABLE [dbo].[SelectedApplicationTable]  WITH CHECK ADD  CONSTRAINT [FK_SelectedApplicationTable_ProjectApplicationsTable_ProjectApplicationsProjectApplicationId] FOREIGN KEY([ProjectApplicationsProjectApplicationId])
REFERENCES [dbo].[ProjectApplicationsTable] ([ProjectApplicationId])
GO
ALTER TABLE [dbo].[SelectedApplicationTable] CHECK CONSTRAINT [FK_SelectedApplicationTable_ProjectApplicationsTable_ProjectApplicationsProjectApplicationId]
GO
ALTER TABLE [dbo].[SkillTable]  WITH CHECK ADD  CONSTRAINT [FK_SkillTable_SkillCategoryTable_SkillCategoryId] FOREIGN KEY([SkillCategoryId])
REFERENCES [dbo].[SkillCategoryTable] ([SkillCategoryId])
GO
ALTER TABLE [dbo].[SkillTable] CHECK CONSTRAINT [FK_SkillTable_SkillCategoryTable_SkillCategoryId]
GO
ALTER TABLE [dbo].[StateTable]  WITH CHECK ADD  CONSTRAINT [FK_StateTable_CountryTable_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[CountryTable] ([CountryId])
GO
ALTER TABLE [dbo].[StateTable] CHECK CONSTRAINT [FK_StateTable_CountryTable_CountryId]
GO
ALTER TABLE [dbo].[TerminatedProjectTable]  WITH CHECK ADD  CONSTRAINT [FK_TerminatedProjectTable_ProjectTable_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[ProjectTable] ([ProjectId])
GO
ALTER TABLE [dbo].[TerminatedProjectTable] CHECK CONSTRAINT [FK_TerminatedProjectTable_ProjectTable_ProjectId]
GO
