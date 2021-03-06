USE [Hospital]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 12/13/2019 3:18:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[Doc_id] [int] NOT NULL,
	[pat_id] [int] NOT NULL,
	[Day] [varchar](50) NULL,
	[Time] [int] IDENTITY(1,1) NOT NULL,
	[Rate] [int] NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[Doc_id] ASC,
	[pat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doc_pateint]    Script Date: 12/13/2019 3:18:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doc_pateint](
	[d] [int] NOT NULL,
	[pat_id] [int] NOT NULL,
 CONSTRAINT [PK_doc_pateint] PRIMARY KEY CLUSTERED 
(
	[d] ASC,
	[pat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doc2]    Script Date: 12/13/2019 3:18:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doc2](
	[Doc_id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NULL,
	[Telphone] [int] NULL,
	[Speciality] [varchar](500) NULL,
	[Rate] [int] NULL,
	[affiliation] [varchar](500) NULL,
 CONSTRAINT [PK_doc2] PRIMARY KEY CLUSTERED 
(
	[Doc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 12/13/2019 3:18:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[pat_id] [int] NOT NULL,
	[History] [varchar](500) NOT NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[pat_id] ASC,
	[History] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient]    Script Date: 12/13/2019 3:18:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[pat_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NULL,
	[phone] [int] NULL,
	[Blood_pressure] [sql_variant] NULL,
	[Diabetic] [sql_variant] NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[pat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservedAPP]    Script Date: 12/13/2019 3:18:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservedAPP](
	[Doctor_id] [int] NOT NULL,
	[patient_id] [int] NOT NULL,
	[daay] [nvarchar](50) NOT NULL,
	[Time] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[working_hours]    Script Date: 12/13/2019 3:18:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[working_hours](
	[doc_id] [int] NOT NULL,
	[day] [nvarchar](50) NOT NULL,
	[doc_name] [nchar](10) NULL,
	[start_Time] [float] NULL,
	[End_time] [float] NULL,
 CONSTRAINT [PK_working_hours] PRIMARY KEY CLUSTERED 
(
	[doc_id] ASC,
	[day] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[doc2] ON 

INSERT [dbo].[doc2] ([Doc_id], [Name], [Telphone], [Speciality], [Rate], [affiliation]) VALUES (1, N'Ahmed     ', 1007582031, N'Dentist', 9, N'Dental')
INSERT [dbo].[doc2] ([Doc_id], [Name], [Telphone], [Speciality], [Rate], [affiliation]) VALUES (2, N'Rawan     ', 1245786458, N'Oculist', 7, N'Eyes')
INSERT [dbo].[doc2] ([Doc_id], [Name], [Telphone], [Speciality], [Rate], [affiliation]) VALUES (3, N'Shrouk    ', 1245678974, N'Dermatolog', 10, N'Leather')
INSERT [dbo].[doc2] ([Doc_id], [Name], [Telphone], [Speciality], [Rate], [affiliation]) VALUES (4, N'Radwa     ', 1023456978, N'Vet', 10, N'Veterinary')
INSERT [dbo].[doc2] ([Doc_id], [Name], [Telphone], [Speciality], [Rate], [affiliation]) VALUES (5, N'samaa     ', 1152349710, N'Psychiatrist', 8, N'Psychology')
INSERT [dbo].[doc2] ([Doc_id], [Name], [Telphone], [Speciality], [Rate], [affiliation]) VALUES (6, N'Wael      ', 1164870346, N'Dentist', 6, N'Dental')
INSERT [dbo].[doc2] ([Doc_id], [Name], [Telphone], [Speciality], [Rate], [affiliation]) VALUES (7, N'Sammy     ', 1578901364, N'Oculist', 9, N'Eyes')
SET IDENTITY_INSERT [dbo].[doc2] OFF
SET IDENTITY_INSERT [dbo].[patient] ON 

INSERT [dbo].[patient] ([pat_id], [name], [phone], [Blood_pressure], [Diabetic]) VALUES (1, N'Sara      ', 1236789451, CAST(N'120-139' AS nvarchar(7)), CAST(N'70-100' AS nvarchar(6)))
INSERT [dbo].[patient] ([pat_id], [name], [phone], [Blood_pressure], [Diabetic]) VALUES (2, N'Marwa     ', 1077777777, CAST(N'100-120' AS nvarchar(7)), CAST(N'70-140' AS nvarchar(6)))
INSERT [dbo].[patient] ([pat_id], [name], [phone], [Blood_pressure], [Diabetic]) VALUES (13, N'Seham     ', 1516121000, CAST(N'90-99' AS nvarchar(5)), CAST(N'101-125' AS nvarchar(7)))
INSERT [dbo].[patient] ([pat_id], [name], [phone], [Blood_pressure], [Diabetic]) VALUES (14, N'Omar      ', 1113131331, CAST(N'140-159' AS nvarchar(7)), CAST(N'141-200' AS nvarchar(7)))
INSERT [dbo].[patient] ([pat_id], [name], [phone], [Blood_pressure], [Diabetic]) VALUES (15, N'Hossam    ', 1000000001, CAST(N'120-139' AS nvarchar(7)), CAST(N'70-100' AS nvarchar(6)))
SET IDENTITY_INSERT [dbo].[patient] OFF
INSERT [dbo].[reservedAPP] ([Doctor_id], [patient_id], [daay], [Time]) VALUES (4, 1, N'Sunday', 10)
INSERT [dbo].[reservedAPP] ([Doctor_id], [patient_id], [daay], [Time]) VALUES (4, 1, N'sunday', 11)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (1, N'monday', N'Ahmed     ', 6, 9)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (1, N'sunday', N'Ahmed     ', 2, 6)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (2, N'monday', N'Rawan     ', 4, 8)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (2, N'sunday', N'Rawan     ', 2, 5)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (3, N'Thursday', N'Shrouk    ', 3, 7)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (3, N'Tuesday', N'Shrouk    ', 11, 3)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (4, N'Sunday', N'Radwa     ', 9, 12)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (4, N'Wensday', N'Radwa     ', 5, 9)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (5, N'Saterday', N'Samaa     ', 1, 4)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (5, N'wensday', N'Samaa     ', 7, 11)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (6, N'Monday', N'Wael      ', 12, 4)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (6, N'Thursday', N'Wael      ', 5, 9)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (7, N'sunday', N'Sammy     ', 3, 7)
INSERT [dbo].[working_hours] ([doc_id], [day], [doc_name], [start_Time], [End_time]) VALUES (7, N'Tuesday', N'Sammy     ', 7, 9)
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_patient] FOREIGN KEY([pat_id])
REFERENCES [dbo].[patient] ([pat_id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_patient]
GO
ALTER TABLE [dbo].[doc_pateint]  WITH CHECK ADD  CONSTRAINT [FK_doc_pateint_patient] FOREIGN KEY([pat_id])
REFERENCES [dbo].[patient] ([pat_id])
GO
ALTER TABLE [dbo].[doc_pateint] CHECK CONSTRAINT [FK_doc_pateint_patient]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_patient] FOREIGN KEY([pat_id])
REFERENCES [dbo].[patient] ([pat_id])
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_patient]
GO
