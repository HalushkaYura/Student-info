CREATE PROCEDURE [dbo].[sp_Groups_UpdateGroup]
    @GroupId INT,
    @Name VARCHAR(255),
    @FacultyId INT
AS
BEGIN
    UPDATE [dbo].[Groups]
    SET [Name] = @Name,
        [FacultyId] = @FacultyId
    WHERE [GroupId] = @GroupId;
END;