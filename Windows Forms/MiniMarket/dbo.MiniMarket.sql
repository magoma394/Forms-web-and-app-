CREATE TABLE [dbo].[MiniMarket] (
    [Product]    VARCHAR (100) NOT NULL,
    [Price]       VARCHAR (50)  NOT NULL,
    [ExpiryDate] VARCHAR (50)  NOT NULL,
    [Amount]      VARCHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([Product] ASC)
);

