USE [EDeskOutSourcing]
GO
/****** Object:  Table [dbo].[AdminTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[CityTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[CompanyFAQTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[CompanyTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[CountryTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[EducationTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[FinishedProjectTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[FreelancerCertificationTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[FreelancerEducationTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[FreelancerExperienceTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[FreelancerFAQTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[FreelancerPriviousProjectsTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[FreelancerTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[LocationTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[PaymentModeTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectApplicationsTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectAssignedTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectDocumentTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectSkillTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectStagesTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTaskAssignmentTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTaskDocumentTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTaskQuerySolutionTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTaskQueryTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTaskReportConflictSolutionTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTaskReportConflictTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTaskReportReleasePaymentConflictSolutionTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTaskReportReleasePaymentConflictTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTaskReportReleasePaymentTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTaskReportTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTaskTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[ProjectTechnology]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[SelectedApplicationTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[SkillCategoryTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[SkillTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[StateTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[TechnologiesTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[TerminatedProjectTable]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[TermsAndConditionsForCompany]    Script Date: 06-06-2024 15:08:11 ******/
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
/****** Object:  Table [dbo].[TermsAndConditionsForFreelancer]    Script Date: 06-06-2024 15:08:11 ******/
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
