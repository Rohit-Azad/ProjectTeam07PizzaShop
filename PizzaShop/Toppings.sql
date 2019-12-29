CREATE TABLE [dbo].[Toppings] (
    [ToppingID]    INT          IDENTITY (1, 1) NOT NULL,
    [ToppingName]  VARCHAR (30) NOT NULL,
    [ToppingPrice] FLOAT (53)   NOT NULL, 
    CONSTRAINT [PK_Toppings] PRIMARY KEY ([ToppingID])
);