USE [BloodBankManagementSystem]
GO

/****** Object:  Table [dbo].[tbl_users]    Script Date: 12/12/2023 3:20:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](50) NULL,
	[email] [nvarchar](150) NULL,
	[password] [nvarchar](150) NULL,
	[full_name] [nvarchar](150) NULL,
	[contact] [nchar](20) NULL,
	[address] [nchar](250) NULL,
	[added_date] [datetime] NULL,
	[image_name] [nchar](50) NULL,
 CONSTRAINT [PK_tbl_users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

