using System.Data.SqlClient;

namespace LibrarySystem.Utilities
{
    internal class SQLDatabaseUtils
    {
        private SQLDatabaseUtils()
        {
            //
        }

        public static string StringConnection => "Data Source=localhost;Initial Catalog=LibrarySystem;Integrated Security=True";

        public static void CreateDatabase()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Integrated Security=True"))
            {
                connection.Open();

                // Check if the database already exists if not create new one
                SqlCommand cmd = new SqlCommand(@"IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'LibrarySystem') 
                                                BEGIN 
                                                CREATE DATABASE LibrarySystem 
                                                END", connection);
                cmd.ExecuteNonQuery();

                // Use the newly created database
                cmd = new SqlCommand("USE LibrarySystem", connection);
                cmd.ExecuteNonQuery();

                // Check if the Books table already exists if not create new one
                cmd = new SqlCommand(@"IF OBJECT_ID('Books', 'U') IS NULL 
                                    BEGIN 
                                    CREATE TABLE Books(
                                    bookID int IDENTITY(1,1) PRIMARY KEY,
                                    bookName varchar(100) NOT NULL,
                                    bookAuthor varchar(100) NOT NULL,
                                    bookQuantity int NOT NULL,
                                    bookAddDate date NOT NULL,
                                    IsDeleted bit NOT NULL DEFAULT 0) 
                                    END", connection);
                cmd.ExecuteNonQuery();

                // Check if the Students table already exists if not create new one
                cmd = new SqlCommand(@"IF OBJECT_ID('Students', 'U') IS NULL 
                                    BEGIN 
                                    CREATE table Students(
                                    studentID int IDENTITY(1,1) PRIMARY KEY,
                                    studentFirstName varchar(100) NOT NULL,
                                    studentMiddleInitial varchar(2),
                                    studentLastName varchar(100) NOT NULL,
                                    studentNumber varchar(100) NOT NULL,
                                    studentYear varchar(100) NOT NULL,
                                    studentCourse varchar(100) NOT NULL,
                                    studentAddDate date NOT NULL,
                                    studentContactNumber varchar(100) NOT NULL,
                                    studentEmail varchar(100) NOT NULL,
                                    studentCurrentlyRentedBooks int DEFAULT 0,
                                    IsDeleted bit NOT NULL DEFAULT 0) 
                                    END", connection);
                cmd.ExecuteNonQuery();

                // Check if the IssueBooks table already exists if not create new one
                cmd = new SqlCommand(@"IF OBJECT_ID('IssueBooks', 'U') IS NULL 
                                    BEGIN 
                                    CREATE TABLE IssueBooks(
                                    issueID int IDENTITY(1,1) PRIMARY KEY,
                                    bookID int NOT NULL,
                                    FOREIGN KEY (bookID) REFERENCES Books(bookID),
                                    studentID int NOT NULL,
                                    FOREIGN KEY (studentID) REFERENCES Students(studentID),
                                    issueDate date NOT NULL,
                                    dueDate date NOT NULL,
                                    renewTimes int DEFAULT 0) 
                                    END", connection);
                cmd.ExecuteNonQuery();

                // Check if the IssueHistory table already exists if not create new one
                cmd = new SqlCommand(@"IF OBJECT_ID('IssueHistory', 'U') IS NULL 
                                    BEGIN 
                                    CREATE TABLE IssueHistory(
                                    issueID int IDENTITY(1,1) PRIMARY KEY,
                                    bookID int NOT NULL,
                                    FOREIGN KEY (bookID) REFERENCES Books(bookID),
                                    studentID int NOT NULL,
                                    FOREIGN KEY (studentID) REFERENCES Students(studentID),
                                    issueDate date NOT NULL,
                                    dueDate date NOT NULL,
                                    renewTimes int NOT NULL DEFAULT 0)
                                    END", connection);
                cmd.ExecuteNonQuery();

                // Check if the ReturnHistory table already exists if not create new one
                cmd = new SqlCommand(@"IF OBJECT_ID('ReturnHistory', 'U') IS NULL 
                                    BEGIN 
                                    CREATE TABLE ReturnHistory(
                                    returnID int IDENTITY(1, 1) PRIMARY KEY,
                                    issueID int NOT NULL,
                                    FOREIGN KEY(issueID) REFERENCES IssueHistory(issueID),
                                    bookID int NOT NULL,
                                    FOREIGN KEY(bookID) REFERENCES Books(bookID),
                                    studentID int NOT NULL,
                                    FOREIGN KEY(studentID) REFERENCES Students(studentID),
                                    issueDate date NOT NULL,
                                    dueDate date NOT NULL,
                                    returnDate date NOT NULL) 
                                    END", connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
