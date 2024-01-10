CREATE PROCEDURE [dbo].[sp_Departments_GetDepartmentById]
    @DepartmentsId INT
AS
BEGIN
    SELECT * FROM [dbo].[Departments]
    WHERE [DepartmentsId] = @DepartmentsId;
END;