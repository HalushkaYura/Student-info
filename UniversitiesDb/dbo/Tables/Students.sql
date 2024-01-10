CREATE TABLE [dbo].[Students] (
    [StudentId]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (255)  NOT NULL,
    [Surname]        VARCHAR (255)  NOT NULL,
    [Course]         INT            NOT NULL,
    [Scholarship]    BIT            NULL,
    [Payer]          BIT            NULL,
    [BornDate]       DATE           NULL,
    [Sex]            VARCHAR (1)    NULL,
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

    DECLARE @GroupId INT;

    -- Отримуємо GroupId для нового, оновленого або видаленого студента
    SELECT @GroupId = COALESCE(i.GroupId, d.GroupId, u.GroupId)
    FROM inserted i
    FULL JOIN deleted d ON i.StudentId = d.StudentId
    FULL JOIN updated u ON i.StudentId = u.StudentId;

    -- Оновлюємо поле Count та GPA відповідно до кількості студентів та середнього GPA в групі
    UPDATE Groups
    SET
        [Count] = (SELECT COUNT(*) FROM Students WHERE GroupId = @GroupId),
        [GPA] = (SELECT AVG(GPA) FROM Students WHERE GroupId = @GroupId)
    WHERE GroupId = @GroupId;
END;
