USE [master]
GO
/****** Object:  Database [CafeManagement]    Script Date: 12/26/2023 5:14:20 PM ******/
CREATE DATABASE [CafeManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CafeManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CafeManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CafeManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CafeManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CafeManagement] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CafeManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CafeManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CafeManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CafeManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CafeManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CafeManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [CafeManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CafeManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CafeManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CafeManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CafeManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CafeManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CafeManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CafeManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CafeManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CafeManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CafeManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CafeManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CafeManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CafeManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CafeManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CafeManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CafeManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CafeManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CafeManagement] SET  MULTI_USER 
GO
ALTER DATABASE [CafeManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CafeManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CafeManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CafeManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CafeManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CafeManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CafeManagement] SET QUERY_STORE = ON
GO
ALTER DATABASE [CafeManagement] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CafeManagement]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[userName] [nvarchar](100) NOT NULL,
	[displayName] [nvarchar](100) NOT NULL,
	[passWord] [nvarchar](1000) NOT NULL,
	[accountType] [nvarchar](100) NOT NULL,
	[phoneNumber] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idTable] [int] NOT NULL,
	[customer] [nvarchar](100) NULL,
	[datePayment] [date] NULL,
	[status] [int] NOT NULL,
	[discount] [int] NULL,
	[note] [nvarchar](1000) NULL,
	[dateCheckin] [date] NULL,
	[totalMoney] [int] NOT NULL,
 CONSTRAINT [PK__Bill__3213E83F020C2CF1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
 CONSTRAINT [PK__BillInfo__3213E83FA054EB5B] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] NOT NULL,
	[name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[phoneNumber] [nvarchar](100) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[dateOfBirth] [date] NULL,
	[level] [nvarchar](100) NULL,
	[points] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[phoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] NOT NULL,
	[name] [nvarchar](100) NULL,
	[numPeople] [int] NOT NULL,
	[status] [nvarchar](100) NOT NULL,
	[location] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([userName], [displayName], [passWord], [accountType], [phoneNumber]) VALUES (N'cfmanager', N'Manager', N'249122641822331841581498563668924619818533', N'admin', N'0962456445')
INSERT [dbo].[Account] ([userName], [displayName], [passWord], [accountType], [phoneNumber]) VALUES (N'kmyk16', N'Kieu My', N'2319947144131232252143722171291205203142161', N'staff', N'0348598721')
INSERT [dbo].[Account] ([userName], [displayName], [passWord], [accountType], [phoneNumber]) VALUES (N'knguyenne', N'Khoi Nguyen', N'918482555123422720745212117634243399', N'staff', N'0872436824')
INSERT [dbo].[Account] ([userName], [displayName], [passWord], [accountType], [phoneNumber]) VALUES (N'maimember', N'testmember', N'2227522216618040874680152552531274624934', N'Member', N'21522321')
INSERT [dbo].[Account] ([userName], [displayName], [passWord], [accountType], [phoneNumber]) VALUES (N'nguyen203', N'Thao Nguyen', N'5642928548932482309517712018223199191', N'satff', N'0359276213')
INSERT [dbo].[Account] ([userName], [displayName], [passWord], [accountType], [phoneNumber]) VALUES (N'quynhmai123', N'Quynh Mai', N'154140781779634222518921625222771484591', N'staff', N'0865308367')
INSERT [dbo].[Account] ([userName], [displayName], [passWord], [accountType], [phoneNumber]) VALUES (N'testdiscount', N'testdiscount', N'11713316584126123795137682411598112193162', N'Member', N'0123456789')
INSERT [dbo].[Account] ([userName], [displayName], [passWord], [accountType], [phoneNumber]) VALUES (N'tnguyentest', N'thao nguyen ne', N'19061232197154250922223221980151213255219', N'Member', N'2152239200')
INSERT [dbo].[Account] ([userName], [displayName], [passWord], [accountType], [phoneNumber]) VALUES (N'trangbd', N'Thuy Trang', N'20118653174137147173103245372542082419452251', N'Member', N'0987862495')
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([id], [idTable], [customer], [datePayment], [status], [discount], [note], [dateCheckin], [totalMoney]) VALUES (97, 1, NULL, CAST(N'2023-12-26' AS Date), 1, 0, N'', CAST(N'2023-12-26' AS Date), 28000)
INSERT [dbo].[Bill] ([id], [idTable], [customer], [datePayment], [status], [discount], [note], [dateCheckin], [totalMoney]) VALUES (98, 1, NULL, CAST(N'2023-12-26' AS Date), 1, 0, N'', CAST(N'2023-12-26' AS Date), 160000)
INSERT [dbo].[Bill] ([id], [idTable], [customer], [datePayment], [status], [discount], [note], [dateCheckin], [totalMoney]) VALUES (99, 1, NULL, CAST(N'2023-12-26' AS Date), 1, 0, N'', CAST(N'2023-12-26' AS Date), 116000)
INSERT [dbo].[Bill] ([id], [idTable], [customer], [datePayment], [status], [discount], [note], [dateCheckin], [totalMoney]) VALUES (100, 3, NULL, CAST(N'2023-12-26' AS Date), 1, 0, N'', CAST(N'2023-12-26' AS Date), 40000)
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (114, 97, 3001, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (115, 98, 5001, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (116, 98, 5004, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (117, 99, 6002, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (118, 99, 3001, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (119, 100, 5001, 1)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
GO
INSERT [dbo].[Category] ([id], [name]) VALUES (10, N'Coffee')
INSERT [dbo].[Category] ([id], [name]) VALUES (20, N'Smoothies')
INSERT [dbo].[Category] ([id], [name]) VALUES (30, N'Splash')
INSERT [dbo].[Category] ([id], [name]) VALUES (40, N'Milk tea')
INSERT [dbo].[Category] ([id], [name]) VALUES (50, N'Fruit tea')
INSERT [dbo].[Category] ([id], [name]) VALUES (60, N'Cakes and snacks')
INSERT [dbo].[Category] ([id], [name]) VALUES (70, N'Topping')
GO
INSERT [dbo].[Customer] ([phoneNumber], [name], [dateOfBirth], [level], [points]) VALUES (N'0123456789', N'testdiscount', CAST(N'2023-12-25' AS Date), N'Bronze', 0)
INSERT [dbo].[Customer] ([phoneNumber], [name], [dateOfBirth], [level], [points]) VALUES (N'0348598721', N'Kieu My', CAST(N'2003-05-08' AS Date), N'Gold', 1000)
INSERT [dbo].[Customer] ([phoneNumber], [name], [dateOfBirth], [level], [points]) VALUES (N'0359276213', N'Thao Nguyen', CAST(N'2003-04-12' AS Date), N'Silver', 500)
INSERT [dbo].[Customer] ([phoneNumber], [name], [dateOfBirth], [level], [points]) VALUES (N'0865308367', N'Quynh Mai', CAST(N'2003-03-27' AS Date), N'Diamond', 2800)
INSERT [dbo].[Customer] ([phoneNumber], [name], [dateOfBirth], [level], [points]) VALUES (N'0872436824', N'Khoi Nguyen', CAST(N'2003-01-01' AS Date), N'Member', 0)
INSERT [dbo].[Customer] ([phoneNumber], [name], [dateOfBirth], [level], [points]) VALUES (N'0987862495', N'Thuy Trang', CAST(N'2003-04-30' AS Date), N'Member', 10)
INSERT [dbo].[Customer] ([phoneNumber], [name], [dateOfBirth], [level], [points]) VALUES (N'21522321', N'testmember', CAST(N'2003-03-27' AS Date), N'Member', 320)
GO
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1001, N'Cà Phê Sữa Đá', 10, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1002, N'Cà Phê Đen Đá', 10, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1003, N'Cà Phê Sữa Nóng', 10, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1004, N'Bạc Xĩu', 10, 28000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1005, N'Americano', 10, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1006, N'Cappuccino', 10, 32000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2001, N'Sinh Tố dâu', 20, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2002, N'Sinh Tố bơ', 20, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2003, N'Sinh Tố Chuối', 20, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2004, N'Sinh Tố Xoài', 20, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3001, N'Nước Ép Cam', 30, 28000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3002, N'Nước Ép Ổi', 30, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3003, N'Nước Ép Dưa Hấu', 30, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3004, N'Nước Ép Táo', 30, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3005, N'Nước Ép Lựu', 30, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4001, N'Trà Sữa Matcha', 40, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4002, N'Trà Sữa Thái Xanh', 40, 29000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4003, N'Trà Sữa Thái Đỏ', 40, 29000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4004, N'Sữa Tươi Trân Châu Đường Đen', 40, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4005, N'Trà Sữa Olong', 40, 38000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4006, N'Trà Sữa Bạc Hà', 40, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4007, N'Trà Sữa Dâu', 40, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4008, N'Trà Sữa Socola', 40, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5001, N'Trà Đào Cam Sả', 50, 40000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5002, N'Trà Hoa Cúc Mật Ong', 50, 40000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5003, N'Trà Olong Sen Vàng', 50, 42000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5004, N'Trà Bưởi Hồng', 50, 40000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5005, N'Trà Gừng', 50, 32000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5006, N'Trà Chanh', 50, 28000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5007, N'Trà Nấm Linh Chi Táo Đỏ', 50, 45000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5008, N'Trà Cam Quế Đào', 50, 42000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5009, N'Trà Đen Machiato', 50, 40000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6001, N'Tiramisu', 60, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6002, N'Bánh Su Kem', 60, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6003, N'Mousse Passion Cheese', 60, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6004, N'Bông Lan Trứng Muối', 60, 40000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6005, N'Mochi Kem Matcha', 60, 19000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6006, N'Croissant Trứng Muối', 60, 35000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7001, N'Trân Châu Trắng', 70, 7000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7002, N'Trân Châu Đen', 70, 7000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7003, N'Kem Trứng Nướng', 70, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7004, N'Đào Miếng', 70, 5000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7005, N'Phô Mai Tươi', 70, 10000)
GO
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (1, N'F1_01', 4, N'Free', N'First floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (2, N'F1_02', 4, N'Free', N'First floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (3, N'F1_03', 4, N'Free', N'First floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (4, N'F1_04', 4, N'Free', N'First floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (5, N'F1_05', 2, N'Free', N'First floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (6, N'F1_06', 2, N'Free', N'First floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (7, N'F2_01', 2, N'Free', N'Second floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (8, N'F2_02', 2, N'Free', N'Second floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (9, N'F2_03', 2, N'Free', N'Second floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (10, N'F2_04', 2, N'Free', N'Second floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (11, N'F2_05', 6, N'Free', N'Second floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (12, N'F2_06', 6, N'Free', N'Second floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (13, N'F2_07', 6, N'Free', N'Second floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (14, N'F2_08', 10, N'Free', N'Second floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (15, N'F2_09', 10, N'Free', N'Second floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (16, N'F2_10', 10, N'Free', N'Second floor')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (17, N'G_01', 4, N'Free', N'Garden')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (18, N'G_02', 4, N'Free', N'Garden')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (19, N'G_03', 4, N'Free', N'Garden')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (20, N'G_04', 2, N'Free', N'Garden')
INSERT [dbo].[TableFood] ([id], [name], [numPeople], [status], [location]) VALUES (21, N'G_05', 2, N'Free', N'Garden')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UN_phoneNumber]    Script Date: 12/26/2023 5:14:21 PM ******/
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [UN_phoneNumber] UNIQUE NONCLUSTERED 
(
	[phoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ('Member') FOR [accountType]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF__Bill__status__412EB0B6]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF__Bill__discount__19AACF41]  DEFAULT ((0)) FOR [discount]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF__Bill__dateChecki__2CBDA3B5]  DEFAULT (getdate()) FOR [dateCheckin]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF__Bill__totalMoney__2EA5EC27]  DEFAULT ((0)) FOR [totalMoney]
GO
ALTER TABLE [dbo].[BillInfo] ADD  CONSTRAINT [DF__BillInfo__count__44FF419A]  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ('Member') FOR [level]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((0)) FOR [points]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT ((4)) FOR [numPeople]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK__Bill__customer__66603565] FOREIGN KEY([customer])
REFERENCES [dbo].[Customer] ([phoneNumber])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK__Bill__customer__66603565]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK__Bill__customer__6E01572D] FOREIGN KEY([customer])
REFERENCES [dbo].[Customer] ([phoneNumber])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK__Bill__customer__6E01572D]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK__Bill__status__4222D4EF] FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK__Bill__status__4222D4EF]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK__BillInfo__count__45F365D3] FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK__BillInfo__count__45F365D3]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK__BillInfo__idFood__46E78A0C] FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK__BillInfo__idFood__46E78A0C]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD FOREIGN KEY([phoneNumber])
REFERENCES [dbo].[Account] ([phoneNumber])
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD FOREIGN KEY([phoneNumber])
REFERENCES [dbo].[Account] ([phoneNumber])
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD FOREIGN KEY([phoneNumber])
REFERENCES [dbo].[Account] ([phoneNumber])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[Category] ([id])
GO
/****** Object:  StoredProcedure [dbo].[USP_FindOrder]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_FindOrder]
 @dateCheckin date , @idTable int 
 AS
 BEGIN
	SELECT * FROM dbo.Bill WHERE CONVERT(DATE, dateCheckin, 103) = CONVERT(DATE, @dateCheckin, 103) and idTable = @idTable AND status = 2
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetListBillByDate]
@dayFrom nvarchar(100), @dayTo nvarchar(100)
as
begin
select bi.id as [Bill ID],ta.name as [Table Name], datePayment as [Day Payment], totalMoney as [Total Price ],discount as [Discount(%)], bi.customer as [Customer PhoneNumber]
from Bill bi, TableFood ta
where datePayment >= @dayFrom and datePayment<= @dayTo and bi.status=1
and ta.id=bi.idTable
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateOfCustomer]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetListBillByDateOfCustomer]
@dayFrom nvarchar(100), @dayTo nvarchar(100), @phone nvarchar(100)
as
begin
select bi.id as [Bill], bi.discount as [Discount] , bi.totalMoney as [Total Money], bi.datePayment as [Date]
from Customer cu, Bill bi 
where cu.phoneNumber=bi.customer
and datePayment >= @dayFrom and datePayment<= @dayTo and bi.status=1 and @phone=cu.phoneNumber
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetTableList]
AS SELECT * FROM dbo.TableFood
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableListByDateCheckin]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetTableListByDateCheckin] -- lọc ds bàn theo vị trí
@dateCheckin date
AS
BEGIN 
	SELECT Tablefood.* FROM dbo.TableFood, dbo.bill  WHERE tablefood.id = bill.idtable and CONVERT(DATE, bill.dateCheckin, 103) = CONVERT(DATE, @dateCheckin, 103)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableListByLocation]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetTableListByLocation]
@location NVARCHAR(100)
AS
BEGIN 
	SELECT * FROM dbo.TableFood WHERE location = @location
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBill] 
@idTable INT
AS 
BEGIN
INSERT dbo.Bill (  idTable, customer, datePayment, status)
VALUES ( @idTable, NULL, NULL, 0)
END 
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBillInfo]
@idBill INT, @idFood int, @count INT
AS
BEGIN
	DECLARE @isExistBillInfo INT
	DECLARE @foodCount INT = 1

	SELECT @isExistBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b WHERE idBill=@idBill AND idFood = @idFood
	
	IF(@isExistBillInfo > 0) 
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0) 
			UPDATE dbo.BillInfo SET count = @foodCount + @count WHERE idFood=@idFood
		ELSE 
			DELETE dbo.BillInfo WHERE idBill= @idBill AND  idFood= @idFood
	END

	ELSE 
		if(@count > 0)
		begin 
			INSERT dbo.BillInfo
					(idBill, idFood, count)
			VALUES (@idBill, @idFood, @count)
		end
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillOrder]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBillOrder] 
@idTable INT
AS 
BEGIN
INSERT dbo.Bill (  idTable, customer, datePayment, status)
VALUES ( @idTable, NULL, NULL, 2)
END 
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Them vao sql để fix lỗi log in chữ hoa chữ thường
CREATE PROCEDURE [dbo].[USP_Login] @userName NVARCHAR(100), @passWord NVARCHAR(100)
AS
BEGIN
SELECT * FROM dbo.Account 
WHERE Account.userName COLLATE SQL_Latin1_General_CP1_CS_AS = @userName 
AND Account.passWord COLLATE SQL_Latin1_General_CP1_CS_AS = @passWord
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateBill]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateBill]
@idBill INT, @totalmoney FLOAT, @discount INT, @note NVARCHAR(1000)
AS
BEGIN
	UPDATE dbo.Bill
	SET datePayment=GETDATE(), status= 1, totalmoney = @totalmoney, discount = @discount,  note = @note
	WHERE id = @idBill
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateBillOrder]    Script Date: 12/26/2023 5:14:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateBillOrder]
@idBill INT, @totalmoney int, @note NVARCHAR(1000)
AS
BEGIN
	UPDATE dbo.Bill
	SET totalmoney = @totalmoney,  note = @note
	WHERE id = @idBill
END
GO
USE [master]
GO
ALTER DATABASE [CafeManagement] SET  READ_WRITE 
GO
