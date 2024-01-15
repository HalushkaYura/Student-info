CREATE PROCEDURE [dbo].[sp_Departments_GetLastDepartment]
AS
BEGIN
    SELECT TOP 1 * FROM [dbo].[Departments]
    ORDER BY [DepartmentId] DESC;
END;