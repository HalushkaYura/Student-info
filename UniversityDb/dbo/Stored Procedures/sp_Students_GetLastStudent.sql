CREATE PROCEDURE [dbo].[sp_Students_GetLastStudent]
AS
BEGIN
    SELECT TOP 1 * FROM [dbo].[Students]
    ORDER BY [StudentId] DESC;
END;