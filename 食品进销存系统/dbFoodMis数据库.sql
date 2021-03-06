USE [dbFoodMis]
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[supplier](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[supplier_name] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[address] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[salesperson]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[salesperson](
	[number] [varchar](50) NOT NULL,
	[salesperson_name] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [pk_salesperson] PRIMARY KEY CLUSTERED 
(
	[number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sales_form]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sales_form](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[goods_id] [int] NOT NULL,
	[original_price] [varchar](50) NOT NULL,
	[price] [varchar](50) NOT NULL,
	[num] [varchar](50) NOT NULL,
	[good_name] [varchar](50) NOT NULL,
	[sales_id] [int] NOT NULL,
 CONSTRAINT [PK_sales_form_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sales]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sales](
	[id] [int] NOT NULL,
	[customer_name] [varchar](50) NOT NULL,
	[salesperson_name] [varchar](50) NOT NULL,
	[date] [varchar](50) NOT NULL,
	[money] [varchar](50) NOT NULL,
 CONSTRAINT [PK_sales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[receivables]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[receivables](
	[id] [varchar](50) NOT NULL,
	[buyer_name] [varchar](50) NOT NULL,
	[info] [varchar](50) NULL,
	[sales_id] [int] NOT NULL,
	[salesperson_name] [varchar](50) NOT NULL,
	[type] [varchar](50) NULL,
	[a_money] [varchar](50) NOT NULL,
	[y_money] [varchar](50) NULL,
	[status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_receivables] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[purchasing]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[purchasing](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[purchasing_id] [int] NULL,
	[purchasing_name] [varchar](50) NULL,
	[original_price] [float] NULL,
	[num] [int] NULL,
	[date] [varchar](50) NULL,
	[buyer_name] [varchar](50) NULL,
	[salesperson_name] [varchar](50) NULL,
 CONSTRAINT [PK_purchasing] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[purchasing] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[payment]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[payment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[supplier_name] [varchar](50) NULL,
	[info] [varchar](50) NULL,
	[purchasing_id] [int] NULL,
	[buyer_name] [varchar](50) NULL,
	[type] [varchar](50) NULL,
	[a_money] [float] NULL,
	[y_money] [float] NULL,
	[status] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[money]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[money](
	[goods_id] [int] NOT NULL,
	[purchased_num] [int] NOT NULL,
	[no_num] [int] NOT NULL,
	[profit] [varchar](50) NOT NULL,
 CONSTRAINT [PK_money] PRIMARY KEY CLUSTERED 
(
	[goods_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[goods]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[goods](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[goods_name] [varchar](50) NULL,
	[original_price] [float] NULL,
	[supplier_id] [int] NULL,
 CONSTRAINT [PK_goods] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[customer]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_name] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
 CONSTRAINT [pk_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[commodity_stock]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[commodity_stock](
	[goods_id] [int] NOT NULL,
	[num] [int] NULL,
	[commodity_name] [varchar](50) NULL,
	[original_price] [varchar](50) NULL,
	[price] [varchar](50) NULL,
	[unit] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[buyer]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[buyer](
	[number] [varchar](50) NULL,
	[buyer_name] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[password] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[admin]    Script Date: 01/16/2018 19:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[status] [int] NULL,
 CONSTRAINT [pk_admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_Check]    Script Date: 01/16/2018 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_Check]
as
select distinct a.username n1,b.number n2,s.number n3
from admin a,buyer b,salesperson s
GO
/****** Object:  Default [DF_admin_status]    Script Date: 01/16/2018 19:52:49 ******/
ALTER TABLE [dbo].[admin] ADD  CONSTRAINT [DF_admin_status]  DEFAULT ((0)) FOR [status]
GO
/****** Object:  Default [DF_buyer_password]    Script Date: 01/16/2018 19:52:49 ******/
ALTER TABLE [dbo].[buyer] ADD  CONSTRAINT [DF_buyer_password]  DEFAULT ((123)) FOR [password]
GO
/****** Object:  Default [DF_receivables_info]    Script Date: 01/16/2018 19:52:49 ******/
ALTER TABLE [dbo].[receivables] ADD  CONSTRAINT [DF_receivables_info]  DEFAULT ((0)) FOR [info]
GO
/****** Object:  Default [DF_receivables_y_money]    Script Date: 01/16/2018 19:52:49 ******/
ALTER TABLE [dbo].[receivables] ADD  CONSTRAINT [DF_receivables_y_money]  DEFAULT ((0)) FOR [y_money]
GO
/****** Object:  Default [DF_receivables_status]    Script Date: 01/16/2018 19:52:49 ******/
ALTER TABLE [dbo].[receivables] ADD  CONSTRAINT [DF_receivables_status]  DEFAULT ((0)) FOR [status]
GO
/****** Object:  Default [DF_salesperson_password]    Script Date: 01/16/2018 19:52:49 ******/
ALTER TABLE [dbo].[salesperson] ADD  CONSTRAINT [DF_salesperson_password]  DEFAULT ((123)) FOR [password]
GO
