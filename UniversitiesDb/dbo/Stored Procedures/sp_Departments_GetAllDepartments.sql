CREATE PROCEDURE [dbo].[sp_Departments_GetAllDepartments]
AS
BEGIN
    SELECT * FROM [dbo].[Departments];
END;