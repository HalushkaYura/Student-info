CREATE TABLE [dbo].[Departments] (
    [DepartmentId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (255) NOT NULL,
    [FacultyId]     INT           NULL,
    PRIMARY KEY CLUSTERED ([DepartmentId] ASC),
    FOREIGN KEY ([FacultyId]) REFERENCES [dbo].[Faculties] ([FacultyId])  ON DELETE CASCADE
);

