CREATE TABLE [dbo].[Tulokset]
(
	[tulosID] INT NOT NULL PRIMARY KEY, 
    [peli] INT NOT NULL, 
    [pelaaja] INT NOT NULL, 
    [kokonaispisteet] INT NOT NULL, 
    CONSTRAINT [FK_Tulokset_Peli] FOREIGN KEY ([peli]) REFERENCES [Peli]([peliID]), 
    CONSTRAINT [FK_Tulokset_Pelaaja] FOREIGN KEY ([pelaaja]) REFERENCES [Pelaaja]([pelaajaID])
)
