CREATE PROCEDURE [dbo].[sp_Departments_DeleteDepartment]
    @DepartmentsId INT
AS
BEGIN
    DELETE FROM [dbo].[Departments]
    WHERE [DepartmentsId] = @DepartmentsId;
END;