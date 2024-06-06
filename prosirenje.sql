CREATE TABLE [dbo].[Odgajivacnice] (
    [OdgajivacniceId] INT           NOT NULL,
    [Naziv]           NVARCHAR (50) NOT NULL,
    [BrTelefona]      NVARCHAR (50) NULL,
    [Email]           NVARCHAR (50) NULL,
    [Adresa]          NVARCHAR (50) NULL,
    [Drzava]          NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([OdgajivacniceId] ASC)
);
/* DODAVANJE KOLONE OdgajivacnicaId u tabelu Pas 
kao spoljasnji kljuc */
ALTER TABLE [dbo].[Pas]
ADD [OdgajivacnicaId] INT NULL;
ALTER TABLE [dbo].[Pas]
ADD CONSTRAINT [FK_Pas_Odgajivacnica]
FOREIGN KEY ([OdgajivacnicaId])
REFERENCES [dbo].[Odgajivacnice] ([OdgajivacniceId]);
/* У табели раса треба додати и напомену у 
којој ће се чувати додатна запажања о 
карактеристикама расе.*/
ALTER TABLE [dbo].[Rasa]
ADD [Napomena] NVARCHAR (MAX) NULL;


