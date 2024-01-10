CREATE PROCEDURE [dbo].[sp_Departments_GetDepartmentById]
    @DepartmentId INT
AS
BEGIN
    SELECT * FROM [dbo].[Departments]
    WHERE [DepartmentsId] = @DepartmentId;
END;