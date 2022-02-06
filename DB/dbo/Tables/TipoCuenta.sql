﻿CREATE TABLE [dbo].[TipoCuenta] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]    NVARCHAR (50) NOT NULL,
    [UsuarioId] INT           NOT NULL,
    [Orden]     INT           NOT NULL,
    CONSTRAINT [PK_TipoCuenta] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TipoCuenta_Usuarios] FOREIGN KEY ([UsuarioId]) REFERENCES [dbo].[Usuarios] ([Id])
);

