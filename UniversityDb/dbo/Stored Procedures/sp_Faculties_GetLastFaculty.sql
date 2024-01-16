CREATE PROCEDURE [dbo].[sp_Faculties_GetLastFaculty]
AS
BEGIN
    SELECT TOP 1 * FROM [dbo].[Faculties]
    ORDER BY [FacultyId] DESC;
END;