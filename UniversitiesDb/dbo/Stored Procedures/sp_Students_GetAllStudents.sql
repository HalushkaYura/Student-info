CREATE PROCEDURE [dbo].[sp_Students_GetAllStudents]
AS
BEGIN
    SELECT * FROM [dbo].[Students];
END;