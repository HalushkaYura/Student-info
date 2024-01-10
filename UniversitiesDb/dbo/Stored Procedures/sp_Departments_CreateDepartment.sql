CREATE PROCEDURE [dbo].[sp_Departments_CreateDepartment]
    @Name VARCHAR(255),
    @FacultyId INT
AS
BEGIN
    INSERT INTO [dbo].[Departments] ([Name], [FacultyId])
    VALUES (@Name, @FacultyId);
END;