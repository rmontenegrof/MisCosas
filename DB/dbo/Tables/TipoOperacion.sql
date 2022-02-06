CREATE TABLE [dbo].[TipoOperacion] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Descripcion] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TipoOperaciones] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TipoOperacion_TipoOperacion] FOREIGN KEY ([Id]) REFERENCES [dbo].[TipoOperacion] ([Id])
);

