CREATE TABLE [dbo].[Departments] (
    [DepartmentsId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (255) NOT NULL,
    [FacultyId]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([DepartmentsId] ASC),
    FOREIGN KEY ([FacultyId]) REFERENCES [dbo].[Faculties] ([FacultyId])
);

