CREATE PROCEDURE [dbo].[sp_Departments_GetDepartmentById]
    @DepartmentId INT
AS
BEGIN
    SELECT * FROM [dbo].[Departments]
    WHERE [DepartmentId] = @DepartmentId;
END;