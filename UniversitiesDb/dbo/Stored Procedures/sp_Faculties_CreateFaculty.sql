CREATE PROCEDURE [dbo].[sp_Faculties_CreateFaculty]
    @Note VARCHAR(255),
    @Name VARCHAR(255) 
AS
BEGIN
    INSERT INTO [dbo].[Faculties] ([Note], [Name])
    VALUES (@Note, @Name);
END;