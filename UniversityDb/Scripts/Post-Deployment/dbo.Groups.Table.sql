SET IDENTITY_INSERT [dbo].[Groups] ON 

INSERT [dbo].[Groups] ([GroupId], [Name], [Count], [GPA], [FacultyId]) VALUES (1, N'KNIT-33', 6, CAST(76.50 AS Decimal(5, 2)), 1038)
INSERT [dbo].[Groups] ([GroupId], [Name], [Count], [GPA], [FacultyId]) VALUES (2, N'Inf-13O', 7, CAST(76.43 AS Decimal(5, 2)), 1038)
INSERT [dbo].[Groups] ([GroupId], [Name], [Count], [GPA], [FacultyId]) VALUES (4, N'Mat 21', 8, CAST(83.38 AS Decimal(5, 2)), 1037)
INSERT [dbo].[Groups] ([GroupId], [Name], [Count], [GPA], [FacultyId]) VALUES (5, N'Teachers', 5, CAST(69.60 AS Decimal(5, 2)), 1037)
SET IDENTITY_INSERT [dbo].[Groups] OFF
GO
