CREATE TABLE [dbo].[Stock] (
    [ItemId]        INT            NOT NULL,
    [ItemName]      VARCHAR (50)   NULL,
    [CompanyName]   VARCHAR (50) NULL,
    [Price]         FLOAT (53)     NULL,
    [TotalQuantity] INT            NULL,
    [AvailQuantity] INT            NULL,
    PRIMARY KEY CLUSTERED ([ItemId] ASC)
);

