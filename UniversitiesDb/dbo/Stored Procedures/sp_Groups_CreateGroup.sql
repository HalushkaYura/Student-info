CREATE PROCEDURE [dbo].[sp_Groups_CreateGroup]
    @Name VARCHAR(255),
    @FacultyId INT
AS
BEGIN
    INSERT INTO [dbo].[Groups] ([Name], [FacultyId])
    VALUES (@Name, @FacultyId);
END;