CREATE PROCEDURE [dbo].[sp_Faculties_CreateFaculty]
    @Note VARCHAR(255),
    @Name VARCHAR(255), 
    @FacultyId INT OUTPUT
AS
BEGIN
    INSERT INTO [dbo].[Faculties] ([Note], [Name])
    VALUES (@Note, @Name);

    SET @FacultyId = SCOPE_IDENTITY();
END;