﻿CREATE PROCEDURE [dbo].[sp_Students_CreateStudent]
    @Name NVARCHAR(255),
    @Surname NVARCHAR(255),
    @Course INT,
    @BornDate DATE,
    @GPA DECIMAL(5,2),
    @PhoneNumber VARCHAR(20),
    @DateStartStudy DATE,
    @DateEndStudy DATE,
    @GroupId INT
AS
BEGIN
    INSERT INTO [dbo].[Students] (
        [Name], [Surname], [Course], 
        [BornDate],  [GPA], [PhoneNumber], [DateStartStudy], [DateEndStudy], [GroupId]
    )
    VALUES (
        @Name, @Surname, @Course, 
        @BornDate, @GPA, @PhoneNumber, @DateStartStudy, @DateEndStudy, @GroupId
    );
END;