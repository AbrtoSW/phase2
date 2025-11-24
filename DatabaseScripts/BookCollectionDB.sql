CREATE TABLE Authors (
    AuthorID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Country VARCHAR(50) NULL
);

CREATE TABLE Books (
    BookID INT IDENTITY(1,1) PRIMARY KEY,
    Title VARCHAR(150) NOT NULL,
    ISBN VARCHAR(20) NULL,
    PublicationYear INT NULL,
    Genre VARCHAR(50) NULL,

    AuthorID INT NOT NULL,
    IsRead BIT NOT NULL DEFAULT 0,

    -- PhysicalBook fields
    ShelfLocation VARCHAR(50) NULL,
    Condition VARCHAR(50) NULL,
    IsHardcover BIT NULL,

    -- EBook fields
    FileFormat VARCHAR(20) NULL,
    FileSizeMB DECIMAL(10,2) NULL,
    FilePathOrLink VARCHAR(255) NULL,

    BookType VARCHAR(20) NOT NULL,  -- "Physical" or "EBook"

    CONSTRAINT FK_Books_Authors
        FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID)
);

CREATE PROCEDURE sp_AddBook
(
    @Title VARCHAR(150),
    @ISBN VARCHAR(20),
    @PublicationYear INT,
    @Genre VARCHAR(50),
    @AuthorID INT,
    @IsRead BIT,
    @ShelfLocation VARCHAR(50),
    @Condition VARCHAR(50),
    @IsHardcover BIT,
    @FileFormat VARCHAR(20),
    @FileSizeMB DECIMAL(10,2),
    @FilePathOrLink VARCHAR(255),
    @BookType VARCHAR(20)
)
AS
INSERT INTO Books
(
    Title, ISBN, PublicationYear, Genre, AuthorID, IsRead,
    ShelfLocation, Condition, IsHardcover,
    FileFormat, FileSizeMB, FilePathOrLink,
    BookType
)
VALUES
(
    @Title, @ISBN, @PublicationYear, @Genre, @AuthorID, @IsRead,
    @ShelfLocation, @Condition, @IsHardcover,
    @FileFormat, @FileSizeMB, @FilePathOrLink,
    @BookType
);


CREATE PROCEDURE sp_UpdateBook
(
    @BookID INT,
    @Title VARCHAR(150),
    @ISBN VARCHAR(20),
    @PublicationYear INT,
    @Genre VARCHAR(50),
    @AuthorID INT,
    @IsRead BIT,
    @ShelfLocation VARCHAR(50),
    @Condition VARCHAR(50),
    @IsHardcover BIT,
    @FileFormat VARCHAR(20),
    @FileSizeMB DECIMAL(10,2),
    @FilePathOrLink VARCHAR(255),
    @BookType VARCHAR(20)
)
AS
UPDATE Books
SET
    Title = @Title,
    ISBN = @ISBN,
    PublicationYear = @PublicationYear,
    Genre = @Genre,
    AuthorID = @AuthorID,
    IsRead = @IsRead,
    ShelfLocation = @ShelfLocation,
    Condition = @Condition,
    IsHardcover = @IsHardcover,
    FileFormat = @FileFormat,
    FileSizeMB = @FileSizeMB,
    FilePathOrLink = @FilePathOrLink,
    BookType = @BookType
WHERE BookID = @BookID;


CREATE PROCEDURE sp_DeleteBook
(
    @BookID INT
)
AS
DELETE FROM Books WHERE BookID = @BookID;


CREATE PROCEDURE sp_GetAllBooks
AS
SELECT * FROM Books;


CREATE PROCEDURE sp_GetBooksByAuthor
(
    @AuthorID INT
)
AS
SELECT * FROM Books WHERE AuthorID = @AuthorID;

CREATE PROCEDURE sp_AddAuthor
(
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Country VARCHAR(50)
)
AS
INSERT INTO Authors (FirstName, LastName, Country)
VALUES (@FirstName, @LastName, @Country);

CREATE PROCEDURE sp_UpdateAuthor
(
    @AuthorID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Country VARCHAR(50)
)
AS
UPDATE Authors
SET FirstName = @FirstName,
    LastName = @LastName,
    Country = @Country
WHERE AuthorID = @AuthorID;

CREATE PROCEDURE sp_GetAllAuthors
AS
SELECT * FROM Authors;
