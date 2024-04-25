CREATE TABLE [dbo].[Pelaaja] (
    [pelaajaID] INT          NOT NULL,
    [tyyppi]    CHAR (10)    NOT NULL,
    [nimi]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Pelaaja] PRIMARY KEY ([pelaajaID])
);

