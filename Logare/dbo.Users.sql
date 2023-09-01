CREATE TABLE [dbo].[Users] (
    [Id]         INT        NOT NULL,
    [Nume]       NCHAR (50) NOT NULL,
    [Prenume]    NCHAR (50) NOT NULL,
    [AdresaMail] NCHAR (50) NOT NULL,
    [Parola]     NCHAR (50) NOT NULL,
    [Greutate]   INT NOT NULL,
    [Necesar]    INT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

