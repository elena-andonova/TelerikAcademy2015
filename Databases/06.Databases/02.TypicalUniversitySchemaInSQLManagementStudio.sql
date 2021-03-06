USE [master]
GO
/****** Object:  Database [TypicalUniversity]    Script Date: 9.10.2015 г. 19:46:40 ******/
CREATE DATABASE [TypicalUniversity]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TypicalUniversity', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TypicalUniversity.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TypicalUniversity_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TypicalUniversity_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TypicalUniversity] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TypicalUniversity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TypicalUniversity] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TypicalUniversity] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TypicalUniversity] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TypicalUniversity] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TypicalUniversity] SET ARITHABORT OFF 
GO
ALTER DATABASE [TypicalUniversity] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TypicalUniversity] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TypicalUniversity] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TypicalUniversity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TypicalUniversity] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TypicalUniversity] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TypicalUniversity] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TypicalUniversity] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TypicalUniversity] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TypicalUniversity] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TypicalUniversity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TypicalUniversity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TypicalUniversity] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TypicalUniversity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TypicalUniversity] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TypicalUniversity] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TypicalUniversity] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TypicalUniversity] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TypicalUniversity] SET  MULTI_USER 
GO
ALTER DATABASE [TypicalUniversity] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TypicalUniversity] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TypicalUniversity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TypicalUniversity] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TypicalUniversity] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TypicalUniversity]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 9.10.2015 г. 19:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[ProffessorId] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Courses_Students]    Script Date: 9.10.2015 г. 19:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses_Students](
	[CourseId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
 CONSTRAINT [PK_Courses_Students] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departments]    Script Date: 9.10.2015 г. 19:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FacultyId] [int] NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 9.10.2015 г. 19:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[FacultyId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proffessors]    Script Date: 9.10.2015 г. 19:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proffessors](
	[ProffessorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DepartmentId] [int] NOT NULL,
 CONSTRAINT [PK_Proffessors] PRIMARY KEY CLUSTERED 
(
	[ProffessorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proffessors_Titles]    Script Date: 9.10.2015 г. 19:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proffessors_Titles](
	[ProffessorId] [int] NOT NULL,
	[TitleId] [int] NOT NULL,
 CONSTRAINT [PK_Proffessors_Titles] PRIMARY KEY CLUSTERED 
(
	[ProffessorId] ASC,
	[TitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 9.10.2015 г. 19:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[FacultyId] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 9.10.2015 г. 19:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[TitleId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[TitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([DepartmentId])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Proffessors] FOREIGN KEY([ProffessorId])
REFERENCES [dbo].[Proffessors] ([ProffessorId])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Proffessors]
GO
ALTER TABLE [dbo].[Courses_Students]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Students_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
GO
ALTER TABLE [dbo].[Courses_Students] CHECK CONSTRAINT [FK_Courses_Students_Courses]
GO
ALTER TABLE [dbo].[Courses_Students]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Students_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
GO
ALTER TABLE [dbo].[Courses_Students] CHECK CONSTRAINT [FK_Courses_Students_Students]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([FacultyId])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[Proffessors]  WITH CHECK ADD  CONSTRAINT [FK_Proffessors_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([DepartmentId])
GO
ALTER TABLE [dbo].[Proffessors] CHECK CONSTRAINT [FK_Proffessors_Departments]
GO
ALTER TABLE [dbo].[Proffessors_Titles]  WITH CHECK ADD  CONSTRAINT [FK_Proffessors_Titles_Proffessors] FOREIGN KEY([ProffessorId])
REFERENCES [dbo].[Proffessors] ([ProffessorId])
GO
ALTER TABLE [dbo].[Proffessors_Titles] CHECK CONSTRAINT [FK_Proffessors_Titles_Proffessors]
GO
ALTER TABLE [dbo].[Proffessors_Titles]  WITH CHECK ADD  CONSTRAINT [FK_Proffessors_Titles_Titles] FOREIGN KEY([TitleId])
REFERENCES [dbo].[Titles] ([TitleId])
GO
ALTER TABLE [dbo].[Proffessors_Titles] CHECK CONSTRAINT [FK_Proffessors_Titles_Titles]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([FacultyId])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
USE [master]
GO
ALTER DATABASE [TypicalUniversity] SET  READ_WRITE 
GO
