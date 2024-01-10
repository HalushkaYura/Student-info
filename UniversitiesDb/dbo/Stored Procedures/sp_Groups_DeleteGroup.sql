CREATE PROCEDURE [dbo].[sp_Groups_DeleteGroup]
    @GroupId INT
AS
BEGIN
    DELETE FROM [dbo].[Groups]
    WHERE [GroupId] = @GroupId;
END;