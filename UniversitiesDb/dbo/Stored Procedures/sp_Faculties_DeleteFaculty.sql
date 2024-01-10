CREATE PROCEDURE [dbo].[sp_Faculties_DeleteFaculty]
    @FacultyId INT
AS
BEGIN
    DELETE FROM [dbo].[Faculties]
    WHERE [FacultyId] = @FacultyId;
END;