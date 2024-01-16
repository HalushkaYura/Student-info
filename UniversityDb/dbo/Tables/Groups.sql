CREATE TABLE [dbo].[Groups] (
    [GroupId]   INT            IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (255)  NOT NULL,
    [Count]     INT            DEFAULT ((0)) NOT NULL,
    [GPA]       DECIMAL (5, 2) DEFAULT ((0)) NOT NULL,
    [FacultyId] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([GroupId] ASC),
    FOREIGN KEY ([FacultyId]) REFERENCES [dbo].[Faculties] ([FacultyId])
);

