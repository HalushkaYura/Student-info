CREATE PROCEDURE [dbo].[sp_Students_DeleteStudent]
    @StudentId INT
AS
BEGIN
    DELETE FROM [dbo].[Students]
    WHERE [StudentId] = @StudentId;
END;