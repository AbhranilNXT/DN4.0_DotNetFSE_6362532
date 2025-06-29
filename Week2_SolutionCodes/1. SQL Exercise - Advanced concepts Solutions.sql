CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Products (ProductName, Category, Price) VALUES
('Laptop A', 'Electronics', 1200.00),
('Laptop B', 'Electronics', 1100.00),
('Laptop C', 'Electronics', 1100.00),
('Laptop D', 'Electronics', 900.00),
('Phone A', 'Electronics', 800.00),
('Shirt A', 'Clothing', 50.00),
('Shirt B', 'Clothing', 45.00),
('Shirt C', 'Clothing', 45.00),
('Shirt D', 'Clothing', 30.00),
('Shoes A', 'Footwear', 100.00),
('Shoes B', 'Footwear', 95.00),
('Shoes C', 'Footwear', 95.00),
('Shoes D', 'Footwear', 80.00);



WITH ProductRanks AS (
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNum
    FROM
        Products
)
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RowNum
FROM
    ProductRanks
WHERE
    RowNum <= 3
ORDER BY
    Category,
    RowNum;

WITH RankedProducts AS (
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RankNum,
        DENSE_RANK() OVER (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS DenseRankNum
    FROM
        Products
)
SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RankNum,
    DenseRankNum
FROM
    RankedProducts;

