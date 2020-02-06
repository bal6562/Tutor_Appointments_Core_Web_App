SET IDENTITY_INSERT [dbo].[Faculty] ON
INSERT INTO [dbo].[Faculty] ([Id], [Name], [Email]) VALUES (1, N'Information and Communication Technology', N'ictfaculty@uni.com')
INSERT INTO [dbo].[Faculty] ([Id], [Name], [Email]) VALUES (2, N'Science ', N'science@uni.com')
SET IDENTITY_INSERT [dbo].[Faculty] OFF
SET IDENTITY_INSERT [dbo].[Tutor] ON
INSERT INTO [dbo].[Tutor] ([Id], [Name], [TutorEmail], [Mobile], [FacultyId]) VALUES (1, N'Will Robinson', N'will@uni.com', N'0213456789', 1)
INSERT INTO [dbo].[Tutor] ([Id], [Name], [TutorEmail], [Mobile], [FacultyId]) VALUES (2, N'Jason Franklin', N'jason@uni.com', N'0215556788', 2)
SET IDENTITY_INSERT [dbo].[Tutor] OFF
SET IDENTITY_INSERT [dbo].[Student] ON
INSERT INTO [dbo].[Student] ([Id], [Name], [StudentEmail]) VALUES (1, N'Simon Houston', N'simon@uni.com')
INSERT INTO [dbo].[Student] ([Id], [Name], [StudentEmail]) VALUES (2, N'David Bayer', N'davidb@uni.com')
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[Appointment] ON
INSERT INTO [dbo].[Appointment] ([Id], [StudentId], [TutorId], [AppointmentDate]) VALUES (1, 2, 2, N'2020-01-30 09:30:00')
INSERT INTO [dbo].[Appointment] ([Id], [StudentId], [TutorId], [AppointmentDate]) VALUES (2, 2, 1, N'2020-01-23 22:20:00')
SET IDENTITY_INSERT [dbo].[Appointment] OFF
