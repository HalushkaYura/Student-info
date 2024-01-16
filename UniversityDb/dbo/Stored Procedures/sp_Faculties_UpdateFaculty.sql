CREATE PROCEDURE [dbo].[sp_Faculties_UpdateFaculty]
    @FacultyId INT,
    @Note VARCHAR(255),
    @Name VARCHAR(255) 
AS
BEGIN
    UPDATE [dbo].[Faculties]
    SET [Note] = @Note,
        [Name] = @Name
    WHERE [FacultyId] = @FacultyId;
END;