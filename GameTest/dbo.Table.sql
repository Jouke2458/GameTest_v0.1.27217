CREATE TABLE [dbo].[Table] (
    [Id]     INT NOT NULL,
    [id_kat] INT NULL,
    [tekst] VARCHAR(300) NULL, 
    [otvet] VARCHAR(50) NULL, 
    [nomer] INT NULL, 
    [password] VARCHAR(8) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

