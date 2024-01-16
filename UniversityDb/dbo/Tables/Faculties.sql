CREATE TABLE [dbo].[Faculties] (
    [FacultyId] INT           IDENTITY (1, 1) NOT NULL,
    [Note]      VARCHAR (255) NULL,
    [Name]      VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([FacultyId] ASC)
);

