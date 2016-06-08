IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Buecher] (
    [BookId] int NOT NULL IDENTITY,
    [Publisher] nvarchar(20),
    [Title] nvarchar(80),
    CONSTRAINT [PK_Buecher] PRIMARY KEY ([BookId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20160608073854_InitBooks', N'1.0.0-rc2-20901');

GO

ALTER TABLE [Buecher] ADD [MainAuthor] nvarchar(max);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20160608074223_AddMainAuthor', N'1.0.0-rc2-20901');

GO

