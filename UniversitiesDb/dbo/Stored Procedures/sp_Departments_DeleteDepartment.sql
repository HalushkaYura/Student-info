CREATE PROCEDURE [dbo].[sp_Departments_DeleteDepartment]
    @DepartmentId INT
AS
BEGIN
    DELETE FROM [dbo].[Departments]
    WHERE [DepartmentId] = @DepartmentId;
END;