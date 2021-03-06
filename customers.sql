USE [customers]
GO
/****** Object:  Table [dbo].[tblKhach]    Script Date: 4/14/2021 4:46:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhach](
	[Makhach] [int] IDENTITY(1,1) NOT NULL,
	[TenKhach] [varchar](255) NULL,
	[DiaChi] [varchar](255) NULL,
	[DienThoai] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[Makhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
