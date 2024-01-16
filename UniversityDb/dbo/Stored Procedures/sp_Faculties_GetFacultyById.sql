CREATE PROCEDURE [dbo].[sp_Faculties_GetFacultyById]
    @FacultyId INT
AS
BEGIN
    SELECT * FROM [dbo].[Faculties]
    WHERE [FacultyId] = @FacultyId;
END;