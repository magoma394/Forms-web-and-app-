CREATE TABLE [dbo].[univLogin]
(
	[ID] VARCHAR(50) NOT NULL PRIMARY KEY DEFAULT NEXT VALUE FOR [dbo].[univlogin_ID_Sequence], 
    [Name] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NULL, 
    [PhoneNumber] VARCHAR(50) NULL, 
    [HighschoolGrade] VARCHAR(50) NOT NULL
)
