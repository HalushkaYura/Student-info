CREATE TABLE [dbo].[Groups] (
    [GroupId]   INT            IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (255)  NOT NULL,
    [Count]     INT            NOT NULL DEFAULT 0,
    [GPA]       DECIMAL (5, 2) NOT NULL DEFAULT 0,
    [FacultyId] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([GroupId] ASC),
    FOREIGN KEY ([FacultyId]) REFERENCES [dbo].[Faculties] ([FacultyId])
);

