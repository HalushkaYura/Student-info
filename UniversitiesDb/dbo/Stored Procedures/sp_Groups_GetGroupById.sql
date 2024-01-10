CREATE PROCEDURE [dbo].[sp_Groups_GetGroupById]
    @GroupId INT
AS
BEGIN
    SELECT * FROM [dbo].[Groups]
    WHERE [GroupId] = @GroupId;
END;