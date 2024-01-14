CREATE TABLE [dbo].[Students] (
    [StudentId]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (255)  NOT NULL,
    [Surname]        VARCHAR (255)  NOT NULL,
    [Course]         INT            NOT NULL,
    [BornDate]       DATE           NULL,
    [GPA]            DECIMAL (5, 2) NOT NULL,
    [PhoneNumber]    VARCHAR (20)   NULL,
    [DateStartStudy] DATE           NOT NULL,
    [DateEndStudy]   DATE           NULL,
    [GroupId]        INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC),
    FOREIGN KEY ([GroupId]) REFERENCES [dbo].[Groups] ([GroupId])
);


GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================


CREATE TRIGGER tr_Student_InsertUpdateDelete
ON [dbo].[Students]
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Оновлюємо Count та GPA для всіх груп, які були задіяні в операціях INSERT, UPDATE, DELETE
UPDATE Groups
SET
    [Count] = CASE
                WHEN (SELECT COUNT(*) FROM Students WHERE GroupId = Groups.GroupId) > 0
                THEN (SELECT COUNT(*) FROM Students WHERE GroupId = Groups.GroupId)
                ELSE 0
             END,
    [GPA] = CASE
              WHEN (SELECT COUNT(*) FROM Students WHERE GroupId = Groups.GroupId) > 0
              THEN (SELECT AVG(GPA) FROM Students WHERE GroupId = Groups.GroupId)
              ELSE 0
           END
WHERE GroupId IN (SELECT GroupId FROM inserted UNION SELECT GroupId FROM deleted);
End;