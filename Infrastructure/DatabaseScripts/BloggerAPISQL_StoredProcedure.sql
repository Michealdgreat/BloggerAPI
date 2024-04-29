CREATE PROCEDURE AddPostWithCategories
    @Title NVARCHAR(255),
    @Description NVARCHAR(MAX),
    @PostUrl NVARCHAR(255),
    @Content NVARCHAR(MAX),
    @FeaturedImageUrl NVARCHAR(255),
    @Author NVARCHAR(255),
    @IsVisible BIT,
    @CategoryNames NVARCHAR(255)  
AS
BEGIN
    
    DECLARE @PostId INT;
    DECLARE @CategoryId INT;
    DECLARE @CategoryName NVARCHAR(255);

    
    INSERT INTO Posts (Title, Description, PostUrl, Content, FeaturedImageUrl, Author, IsVisible)
    VALUES (@Title, @Description, @PostUrl, @Content, @FeaturedImageUrl, @Author, @IsVisible);


    SET @PostId = SCOPE_IDENTITY();


    DECLARE @Pos INT;
    DECLARE @NextPos INT;
    DECLARE @Delim CHAR(1);
    SET @Delim = ',';
    SET @CategoryNames = @CategoryNames + @Delim;
    SET @Pos = CHARINDEX(@Delim, @CategoryNames);

    WHILE (@Pos > 0)
    BEGIN
        SET @NextPos = CHARINDEX(@Delim, @CategoryNames, @Pos + 1);
        SET @CategoryName = LTRIM(RTRIM(SUBSTRING(@CategoryNames, 1, @Pos - 1)));
        SET @CategoryNames = SUBSTRING(@CategoryNames, @NextPos, LEN(@CategoryNames));


        IF NOT EXISTS (SELECT 1 FROM Categories WHERE Name = @CategoryName)
        BEGIN

            INSERT INTO Categories (Name, Slug)
            VALUES (@CategoryName, LOWER(REPLACE(@CategoryName, ' ', '-')));


            SET @CategoryId = SCOPE_IDENTITY();


            INSERT INTO PostCategories (PostId, CategoryId)
            VALUES (@PostId, @CategoryId);
        END
        ELSE
        BEGIN

            SELECT @CategoryId = CategoryId FROM Categories WHERE Name = @CategoryName;


            INSERT INTO PostCategories (PostId, CategoryId)
            VALUES (@PostId, @CategoryId);
        END

        SET @Pos = CHARINDEX(@Delim, @CategoryNames);
    END
END;


CREATE PROCEDURE UpdatePost
    @PostId INT,
    @Title NVARCHAR(255),
    @Description NVARCHAR(MAX),
    @PostUrl NVARCHAR(255),
    @Content NVARCHAR(MAX),
    @FeaturedImageUrl NVARCHAR(255),
    @Author NVARCHAR(255),
    @IsVisible BIT
AS
BEGIN
    UPDATE Posts
    SET Title = @Title,
        Description = @Description,
        PostUrl = @PostUrl,
        Content = @Content,
        FeaturedImageUrl = @FeaturedImageUrl,
        Author = @Author,
        IsVisible = @IsVisible
    WHERE PostId = @PostId;
END;

CREATE PROCEDURE DeletePost
    @PostId INT
AS
BEGIN
    -- Remove from category
    DELETE FROM PostCategories
    WHERE PostId = @PostId;

    -- delete the post
    DELETE FROM Posts
    WHERE PostId = @PostId;
END;

CREATE PROCEDURE GetPost
    @PostId INT
AS
BEGIN
    SELECT p.PostId, p.Title, p.Description, p.PostUrl, p.Content, p.FeaturedImageUrl, p.PublishedDate, p.Author, p.IsVisible,
           c.CategoryId, c.Name AS CategoryName
    FROM Posts p
    LEFT JOIN PostCategories pc ON p.PostId = pc.PostId
    LEFT JOIN Categories c ON pc.CategoryId = c.CategoryId
    WHERE p.PostId = @PostId;
END;

CREATE PROCEDURE GetPostsByCategory
    @CategoryName NVARCHAR(255)
AS
BEGIN
    SELECT p.PostId, p.Title, p.Description, p.PostUrl, p.Content, p.FeaturedImageUrl, p.PublishedDate, p.Author, p.IsVisible
    FROM Posts p
    INNER JOIN PostCategories pc ON p.PostId = pc.PostId
    INNER JOIN Categories c ON pc.CategoryId = c.CategoryId
    WHERE c.Name = @CategoryName;
END;

CREATE PROCEDURE GetPostsByTitle
    @Title NVARCHAR(255)
AS
BEGIN
    SELECT PostId, Title, Description, PostUrl, Content, FeaturedImageUrl, PublishedDate, Author, IsVisible
    FROM Posts
    WHERE Title LIKE '%' + @Title + '%';
END;

CREATE PROCEDURE GetAllPosts
AS
BEGIN
    SELECT p.PostId, p.Title, p.Description, p.PostUrl, p.Content, p.FeaturedImageUrl, p.PublishedDate, p.Author, p.IsVisible,
           STRING_AGG(c.Name, ', ') AS Categories
    FROM Posts p
    LEFT JOIN PostCategories pc ON p.PostId = pc.PostId
    LEFT JOIN Categories c ON pc.CategoryId = c.CategoryId
    GROUP BY p.PostId, p.Title, p.Description, p.PostUrl, p.Content, p.FeaturedImageUrl, p.PublishedDate, p.Author, p.IsVisible
    ORDER BY p.PublishedDate DESC;
END;

CREATE PROCEDURE [dbo].[GetPostsByPostUrl]
    @PostUrl NVARCHAR(255)
AS
BEGIN
    SELECT PostId, Title, Description, PostUrl, Content, FeaturedImageUrl, PublishedDate, Author, IsVisible
    FROM Posts
    WHERE PostUrl = @PostUrl;
END;
