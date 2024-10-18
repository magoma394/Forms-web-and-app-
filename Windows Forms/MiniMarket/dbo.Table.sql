CREATE TABLE [dbo].[MiniMarket]
(
	[Prooduct] VARCHAR(100) NOT NULL PRIMARY KEY, 
    [Price] VARCHAR(50) NOT NULL, 
    [ExpiryDate] VARCHAR(50) NOT NULL, 
    [Amount] VARCHAR(10) NULL DEFAULT 1
)
