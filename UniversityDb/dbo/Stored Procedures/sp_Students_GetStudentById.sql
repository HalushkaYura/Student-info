CREATE PROCEDURE [dbo].[sp_Students_GetStudentById]
    @StudentId INT
AS
BEGIN
    SELECT * FROM [dbo].[Students]
    WHERE [StudentId] = @StudentId;
END;
