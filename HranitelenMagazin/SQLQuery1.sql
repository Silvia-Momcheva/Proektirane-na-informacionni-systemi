USE [master]
GO
/****** Object:  Database [HranitelenMagazin]    Script Date: 12/29/2022 5:56:16 PM ******/
CREATE DATABASE [HranitelenMagazin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HranitelenMagazin', FILENAME = N'C:\Users\User\HranitelenMagazin.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HranitelenMagazin_log', FILENAME = N'C:\Users\User\HranitelenMagazin_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HranitelenMagazin] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HranitelenMagazin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HranitelenMagazin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET ARITHABORT OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HranitelenMagazin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HranitelenMagazin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HranitelenMagazin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HranitelenMagazin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HranitelenMagazin] SET  MULTI_USER 
GO
ALTER DATABASE [HranitelenMagazin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HranitelenMagazin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HranitelenMagazin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HranitelenMagazin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HranitelenMagazin] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HranitelenMagazin] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HranitelenMagazin] SET QUERY_STORE = OFF
GO
USE [HranitelenMagazin]
GO
/****** Object:  Table [dbo].[Доставка]    Script Date: 12/29/2022 5:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Доставка](
	[Код_на_доставка] [int] NOT NULL,
	[Код_на_доставчик] [int] NOT NULL,
	[Дата_на_доставка] [date] NOT NULL,
 CONSTRAINT [PK_Доставка] PRIMARY KEY CLUSTERED 
(
	[Код_на_доставка] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Доставчик]    Script Date: 12/29/2022 5:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Доставчик](
	[Код_доставчик] [int] NOT NULL,
	[Наименование] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Доставчик] PRIMARY KEY CLUSTERED 
(
	[Код_доставчик] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Категория_стоки]    Script Date: 12/29/2022 5:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Категория_стоки](
	[Код_категория] [int] NOT NULL,
	[Име_на_категория] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Категория_стоки] PRIMARY KEY CLUSTERED 
(
	[Код_категория] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Марка]    Script Date: 12/29/2022 5:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Марка](
	[Код_на_марка] [int] NOT NULL,
	[Наименование] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Марка] PRIMARY KEY CLUSTERED 
(
	[Код_на_марка] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Продажби]    Script Date: 12/29/2022 5:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Продажби](
	[Код_на_продажба] [int] NOT NULL,
	[Код_на_служител] [int] NOT NULL,
	[Дата_на_продажба] [date] NOT NULL,
 CONSTRAINT [PK_Продажби] PRIMARY KEY CLUSTERED 
(
	[Код_на_продажба] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Служители]    Script Date: 12/29/2022 5:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Служители](
	[Код_служител] [int] NOT NULL,
	[Име_на_служител] [nvarchar](50) NOT NULL,
	[Длъжност] [nvarchar](10) NOT NULL,
	[Адрес] [nvarchar](50) NOT NULL,
	[Телефон] [nchar](10) NOT NULL,
	[Дата_на_назначаване] [date] NOT NULL,
 CONSTRAINT [PK_Служители] PRIMARY KEY CLUSTERED 
(
	[Код_служител] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Стока_Доставка]    Script Date: 12/29/2022 5:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Стока_Доставка](
	[Код_стока] [int] NOT NULL,
	[Код_доставка] [int] NOT NULL,
	[Брой] [int] NOT NULL,
	[Цена] [money] NOT NULL,
 CONSTRAINT [PK_Стока_Доставка] PRIMARY KEY CLUSTERED 
(
	[Код_стока] ASC,
	[Код_доставка] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Стоки]    Script Date: 12/29/2022 5:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Стоки](
	[Код_стока] [int] NOT NULL,
	[Код_доставка] [int] NOT NULL,
	[Име_на_стока] [nvarchar](30) NOT NULL,
	[Категория] [int] NOT NULL,
	[Марка] [int] NOT NULL,
	[Ед.цена] [nchar](10) NOT NULL,
	[Наличност] [int] NOT NULL,
 CONSTRAINT [PK_Стоки] PRIMARY KEY CLUSTERED 
(
	[Код_стока] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Стоки_Продажби]    Script Date: 12/29/2022 5:56:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Стоки_Продажби](
	[Код_на_продажба] [int] NOT NULL,
	[Код_на_стока] [int] NOT NULL,
	[Брой] [int] NOT NULL,
	[Цена] [money] NOT NULL,
 CONSTRAINT [PK_Стоки_Продажби] PRIMARY KEY CLUSTERED 
(
	[Код_на_продажба] ASC,
	[Код_на_стока] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Доставка] ([Код_на_доставка], [Код_на_доставчик], [Дата_на_доставка]) VALUES (1, 1, CAST(N'2022-12-21' AS Date))
INSERT [dbo].[Доставка] ([Код_на_доставка], [Код_на_доставчик], [Дата_на_доставка]) VALUES (2, 2, CAST(N'2022-11-22' AS Date))
INSERT [dbo].[Доставка] ([Код_на_доставка], [Код_на_доставчик], [Дата_на_доставка]) VALUES (3, 1, CAST(N'2022-11-23' AS Date))
INSERT [dbo].[Доставка] ([Код_на_доставка], [Код_на_доставчик], [Дата_на_доставка]) VALUES (4, 2, CAST(N'2022-10-10' AS Date))
INSERT [dbo].[Доставка] ([Код_на_доставка], [Код_на_доставчик], [Дата_на_доставка]) VALUES (5, 1, CAST(N'2022-11-11' AS Date))
GO
INSERT [dbo].[Доставчик] ([Код_доставчик], [Наименование]) VALUES (1, N'ПРОГРЕС')
INSERT [dbo].[Доставчик] ([Код_доставчик], [Наименование]) VALUES (2, N'ЛИЛА ')
GO
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (1, N'млечни продукти')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (2, N'захарни изделия')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (3, N'месни продукти')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (4, N'морски продукти')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (5, N'подправки')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (6, N'яйчни продукти')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (7, N'плодове')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (8, N'зеленчуци')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (9, N'безалкохолни напитки')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (10, N'алкохолни напитки')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (11, N'готови за консумация храни')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (12, N'масла и мазнини')
INSERT [dbo].[Категория_стоки] ([Код_категория], [Име_на_категория]) VALUES (13, N'други храни')
GO
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (1, N'Nestle')
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (2, N'Домлян')
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (3, N'Milka')
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (4, N'Верея')
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (5, N'PepsiCo')
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (6, N'Coca-Cola')
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (7, N'Mars')
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (8, N'Ferrero')
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (9, N'Unilever')
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (10, N'Danone')
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (11, N'Jim Beam')
INSERT [dbo].[Марка] ([Код_на_марка], [Наименование]) VALUES (12, N'Devin')
GO
INSERT [dbo].[Продажби] ([Код_на_продажба], [Код_на_служител], [Дата_на_продажба]) VALUES (1, 2, CAST(N'2022-10-12' AS Date))
INSERT [dbo].[Продажби] ([Код_на_продажба], [Код_на_служител], [Дата_на_продажба]) VALUES (2, 2, CAST(N'2022-10-13' AS Date))
INSERT [dbo].[Продажби] ([Код_на_продажба], [Код_на_служител], [Дата_на_продажба]) VALUES (3, 2, CAST(N'2022-11-12' AS Date))
INSERT [dbo].[Продажби] ([Код_на_продажба], [Код_на_служител], [Дата_на_продажба]) VALUES (4, 1, CAST(N'2022-10-10' AS Date))
INSERT [dbo].[Продажби] ([Код_на_продажба], [Код_на_служител], [Дата_на_продажба]) VALUES (5, 1, CAST(N'2022-10-11' AS Date))
GO
INSERT [dbo].[Служители] ([Код_служител], [Име_на_служител], [Длъжност], [Адрес], [Телефон], [Дата_на_назначаване]) VALUES (1, N'Мелина Станева', N'Управител', N'ul. "Pop Dimitar" 59-120', N'0893647362', CAST(N'2020-12-12' AS Date))
INSERT [dbo].[Служители] ([Код_служител], [Име_на_служител], [Длъжност], [Адрес], [Телефон], [Дата_на_назначаване]) VALUES (2, N'Ралица Станева', N'Работник', N'ж.к. Възраждане II', N'0898989898', CAST(N'2021-12-11' AS Date))
GO
INSERT [dbo].[Стока_Доставка] ([Код_стока], [Код_доставка], [Брой], [Цена]) VALUES (10201, 1, 50, 250.0000)
INSERT [dbo].[Стока_Доставка] ([Код_стока], [Код_доставка], [Брой], [Цена]) VALUES (10201, 2, 30, 150.0000)
INSERT [dbo].[Стока_Доставка] ([Код_стока], [Код_доставка], [Брой], [Цена]) VALUES (20101, 2, 35, 52.5000)
INSERT [dbo].[Стока_Доставка] ([Код_стока], [Код_доставка], [Брой], [Цена]) VALUES (50901, 1, 90, 180.0000)
GO
INSERT [dbo].[Стоки] ([Код_стока], [Код_доставка], [Име_на_стока], [Категория], [Марка], [Ед.цена], [Наличност]) VALUES (10201, 2, N'Течен шоколад Nestle ', 2, 1, N'5         ', 17)
INSERT [dbo].[Стоки] ([Код_стока], [Код_доставка], [Име_на_стока], [Категория], [Марка], [Ед.цена], [Наличност]) VALUES (20101, 1, N'Кисело мляко "Домлян"', 1, 2, N'1.50      ', 10)
INSERT [dbo].[Стоки] ([Код_стока], [Код_доставка], [Име_на_стока], [Категория], [Марка], [Ед.цена], [Наличност]) VALUES (50901, 2, N'Безалкохолна напитка Пепси 1л', 9, 5, N'2         ', 15)
INSERT [dbo].[Стоки] ([Код_стока], [Код_доставка], [Име_на_стока], [Категория], [Марка], [Ед.цена], [Наличност]) VALUES (70201, 1, N'Шоколад Марс', 2, 7, N'1.20      ', 27)
INSERT [dbo].[Стоки] ([Код_стока], [Код_доставка], [Име_на_стока], [Категория], [Марка], [Ед.цена], [Наличност]) VALUES (111001, 1, N'Джим Бийм 250мл', 10, 1, N'25        ', 5)
GO
INSERT [dbo].[Стоки_Продажби] ([Код_на_продажба], [Код_на_стока], [Брой], [Цена]) VALUES (1, 10201, 5, 25.0000)
INSERT [dbo].[Стоки_Продажби] ([Код_на_продажба], [Код_на_стока], [Брой], [Цена]) VALUES (1, 20101, 2, 3.0000)
INSERT [dbo].[Стоки_Продажби] ([Код_на_продажба], [Код_на_стока], [Брой], [Цена]) VALUES (2, 10201, 3, 15.0000)
INSERT [dbo].[Стоки_Продажби] ([Код_на_продажба], [Код_на_стока], [Брой], [Цена]) VALUES (3, 10201, 2, 10.0000)
INSERT [dbo].[Стоки_Продажби] ([Код_на_продажба], [Код_на_стока], [Брой], [Цена]) VALUES (3, 50901, 2, 4.0000)
GO
ALTER TABLE [dbo].[Доставка]  WITH CHECK ADD  CONSTRAINT [FK_Доставка_Доставчик] FOREIGN KEY([Код_на_доставчик])
REFERENCES [dbo].[Доставчик] ([Код_доставчик])
GO
ALTER TABLE [dbo].[Доставка] CHECK CONSTRAINT [FK_Доставка_Доставчик]
GO
ALTER TABLE [dbo].[Продажби]  WITH CHECK ADD  CONSTRAINT [FK_Продажби_Служители] FOREIGN KEY([Код_на_служител])
REFERENCES [dbo].[Служители] ([Код_служител])
GO
ALTER TABLE [dbo].[Продажби] CHECK CONSTRAINT [FK_Продажби_Служители]
GO
ALTER TABLE [dbo].[Стока_Доставка]  WITH CHECK ADD  CONSTRAINT [FK_Стока_Доставка_Доставка] FOREIGN KEY([Код_доставка])
REFERENCES [dbo].[Доставка] ([Код_на_доставка])
GO
ALTER TABLE [dbo].[Стока_Доставка] CHECK CONSTRAINT [FK_Стока_Доставка_Доставка]
GO
ALTER TABLE [dbo].[Стока_Доставка]  WITH CHECK ADD  CONSTRAINT [FK_Стока_Доставка_Стоки] FOREIGN KEY([Код_стока])
REFERENCES [dbo].[Стоки] ([Код_стока])
GO
ALTER TABLE [dbo].[Стока_Доставка] CHECK CONSTRAINT [FK_Стока_Доставка_Стоки]
GO
ALTER TABLE [dbo].[Стоки]  WITH CHECK ADD  CONSTRAINT [FK_Стоки_Категория_стоки] FOREIGN KEY([Категория])
REFERENCES [dbo].[Категория_стоки] ([Код_категория])
GO
ALTER TABLE [dbo].[Стоки] CHECK CONSTRAINT [FK_Стоки_Категория_стоки]
GO
ALTER TABLE [dbo].[Стоки]  WITH CHECK ADD  CONSTRAINT [FK_Стоки_Марка] FOREIGN KEY([Марка])
REFERENCES [dbo].[Марка] ([Код_на_марка])
GO
ALTER TABLE [dbo].[Стоки] CHECK CONSTRAINT [FK_Стоки_Марка]
GO
ALTER TABLE [dbo].[Стоки_Продажби]  WITH CHECK ADD  CONSTRAINT [FK_Стоки_Продажби_Продажби] FOREIGN KEY([Код_на_продажба])
REFERENCES [dbo].[Продажби] ([Код_на_продажба])
GO
ALTER TABLE [dbo].[Стоки_Продажби] CHECK CONSTRAINT [FK_Стоки_Продажби_Продажби]
GO
ALTER TABLE [dbo].[Стоки_Продажби]  WITH CHECK ADD  CONSTRAINT [FK_Стоки_Продажби_Стоки] FOREIGN KEY([Код_на_стока])
REFERENCES [dbo].[Стоки] ([Код_стока])
GO
ALTER TABLE [dbo].[Стоки_Продажби] CHECK CONSTRAINT [FK_Стоки_Продажби_Стоки]
GO
USE [master]
GO
ALTER DATABASE [HranitelenMagazin] SET  READ_WRITE 
GO
