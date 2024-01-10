CREATE PROCEDURE [dbo].[sp_Students_UpdateStudent]
    @StudentId INT,
    @Name NVARCHAR(255),
    @Surname NVARCHAR(255),
    @Course INT,
    @Scholarship BIT,
    @Payer BIT,
    @BornDate DATE,
    @Sex VARCHAR(1),
    @GPA DECIMAL(5,2),
    @PhoneNumber VARCHAR(20),
    @DateStartStudy DATE,
    @DateEndStudy DATE,
    @GroupId INT
AS
BEGIN
    UPDATE [dbo].[Students]
    SET
        [Name] = @Name,
        [Surname] = @Surname,
        [Course] = @Course,
        [Scholarship] = @Scholarship,
        [Payer] = @Payer,
        [BornDate] = @BornDate,
        [Sex] = @Sex,
        [GPA] = @GPA,
        [PhoneNumber] = @PhoneNumber,
        [DateStartStudy] = @DateStartStudy,
        [DateEndStudy] = @DateEndStudy,
        [GroupId] = @GroupId
    WHERE
        [StudentId] = @StudentId;
END;
