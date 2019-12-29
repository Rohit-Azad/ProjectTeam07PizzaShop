CREATE TABLE [dbo].[Orders] (
    [OrderID]          INT          IDENTITY (1, 1) NOT NULL,
	[CustomerName]    VARCHAR (30) NOT NULL,
	[Toppings]    VARCHAR (MAX) NULL,
    [Size]       VARCHAR (50) NOT NULL,
	[PaymentMethod]       VARCHAR (50) NOT NULL,
    [Price] VARCHAR (50) NOT NULL
    CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderID])
);
