﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nume] NCHAR(50) NOT NULL, 
    [Prenume] NCHAR(50) NOT NULL, 
    [AdresaMail] NCHAR(50) NOT NULL, 
    [Parola] NCHAR(50) NOT NULL, 
    [Greutate] INT NOT NULL, 
    [Necesar] INT NOT NULL DEFAULT 0
)
