USE [RestaurantMangementSystem]
GO
/****** Object:  Table [dbo].[EmployeeChart]    Script Date: 8/25/2021 4:47:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployeeChart](
	[ID] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[Salary] [int] NOT NULL,
 CONSTRAINT [PK_EmployeeChart] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FoodMenuTable]    Script Date: 8/25/2021 4:47:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FoodMenuTable](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsernameTable]    Script Date: 8/25/2021 4:47:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsernameTable](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'Cash-01', N'Mim', N'Cashier', 12000)
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'Cash-02', N'Rahim', N'Cashier', 12000)
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'CK-01', N'Mina', N'Cook', 10000)
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'CK-02', N'Salman', N'Cook', 10000)
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'CK-03', N'Mira', N'Cook', 10000)
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'CR-01', N'Sumi', N'Cleaner', 3000)
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'CR-02', N'Monir', N'cleaner', 3000)
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'CR-03', N'Salim', N'Cleaner', 3000)
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'WT-01', N'Babita', N'Waiter', 5000)
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'WT-02', N'Mini', N'Waiter', 5000)
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'WT-03', N'Rahman', N'Waiter', 5000)
INSERT [dbo].[EmployeeChart] ([ID], [Name], [Role], [Salary]) VALUES (N'WT-04', N'Karim', N'Waiter', 5000)
INSERT [dbo].[FoodMenuTable] ([ID], [Name], [Price]) VALUES (1, N'Rice', 10)
INSERT [dbo].[FoodMenuTable] ([ID], [Name], [Price]) VALUES (2, N'Khichuri', 50)
INSERT [dbo].[FoodMenuTable] ([ID], [Name], [Price]) VALUES (3, N'Biriyani', 100)
INSERT [dbo].[FoodMenuTable] ([ID], [Name], [Price]) VALUES (4, N'Fuchka', 20)
INSERT [dbo].[FoodMenuTable] ([ID], [Name], [Price]) VALUES (5, N'Chotpoti', 20)
INSERT [dbo].[FoodMenuTable] ([ID], [Name], [Price]) VALUES (6, N'Coke', 20)
INSERT [dbo].[FoodMenuTable] ([ID], [Name], [Price]) VALUES (7, N'Water', 10)
INSERT [dbo].[FoodMenuTable] ([ID], [Name], [Price]) VALUES (8, N'Dui', 20)
INSERT [dbo].[FoodMenuTable] ([ID], [Name], [Price]) VALUES (9, N'a', -1)
INSERT [dbo].[UsernameTable] ([Username], [Password]) VALUES (N'Manager', N'123')
INSERT [dbo].[UsernameTable] ([Username], [Password]) VALUES (N'Cashier', N'456')
