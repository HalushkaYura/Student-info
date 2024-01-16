CREATE PROCEDURE [dbo].[sp_Groups_GetLastGroup]
AS
BEGIN
    SELECT TOP 1 * FROM [dbo].[Groups]
    ORDER BY [GroupId] DESC;
END;