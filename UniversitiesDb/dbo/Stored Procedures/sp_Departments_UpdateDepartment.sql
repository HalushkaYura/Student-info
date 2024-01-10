CREATE PROCEDURE [dbo].[sp_Departments_UpdateDepartment]
    @DepartmentId INT,
    @Name VARCHAR(255),
    @FacultyId INT
AS
BEGIN
    UPDATE [dbo].[Departments]
    SET [Name] = @Name,
        [FacultyId] = @FacultyId
    WHERE [DepartmentsId] = @DepartmentId;
END;