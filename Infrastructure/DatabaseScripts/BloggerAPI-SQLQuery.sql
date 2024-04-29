

CREATE TABLE Posts (
    PostId INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    PostUrl NVARCHAR(255) NOT NULL,
    Content NVARCHAR(MAX) NOT NULL,
    FeaturedImageUrl NVARCHAR(255) NOT NULL,
    PublishedDate DATETIME NOT NULL DEFAULT GETDATE(),
    Author NVARCHAR(255) NOT NULL,
    IsVisible BIT NOT NULL DEFAULT 1
);

CREATE TABLE Categories (
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Slug NVARCHAR(255) NOT NULL
);

CREATE TABLE PostCategories (
    PostId INT,
    CategoryId INT,
    CONSTRAINT PK_PostCategories PRIMARY KEY (PostId, CategoryId),
    CONSTRAINT FK_PostCategories_Posts FOREIGN KEY (PostId) REFERENCES Posts(PostId),
    CONSTRAINT FK_PostCategories_Categories FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

CREATE INDEX idx_category_name ON Categories (Name);
CREATE INDEX idx_category_slug ON Categories (Slug);

CREATE INDEX idx_postcategories_postid ON PostCategories (PostId);
CREATE INDEX idx_postcategories_categoryid ON PostCategories (CategoryId);
