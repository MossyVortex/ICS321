USE [BloodBankManagementSystem]
GO

/****** Object:  Table [dbo].[tbl_donors]    Script Date: 12/12/2023 3:20:21 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_donors](
	[donor_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[contact] [nvarchar](20) NULL,
	[gender] [nvarchar](10) NULL,
	[address] [nvarchar](250) NULL,
	[blood_group] [nvarchar](10) NULL,
	[added_date] [datetime] NULL,
	[image_name] [nvarchar](50) NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_donors] PRIMARY KEY CLUSTERED 
(
	[donor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

