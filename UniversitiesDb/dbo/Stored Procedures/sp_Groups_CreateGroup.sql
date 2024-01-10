CREATE PROCEDURE [dbo].[sp_Groups_CreateGroup]
    @Name VARCHAR(255),
    @FacultyId INT
AS
BEGIN
    INSERT INTO [dbo].[Groups] ([Name], [Count], [FacultyId])
    VALUES (@Name, 0, @FacultyId);
END;