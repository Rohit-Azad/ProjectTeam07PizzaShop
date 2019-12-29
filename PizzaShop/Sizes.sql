CREATE TABLE [dbo].[Sizes] (
    [SizeID]     INT          IDENTITY (1, 1) NOT NULL,
    [Size]       VARCHAR (10) NOT NULL,
    [PizzaPrice] FLOAT (53)   NOT NULL, 
    CONSTRAINT [PK_Sizes] PRIMARY KEY ([SizeID])
);