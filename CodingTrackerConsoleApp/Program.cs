//Habit tracker app using SQlite
//should initialize a db on start and store the info as long as the application is running
using Microsoft.Data.Sqlite;

class Program
{
    static void Main(string[] args)
    {
         string connectionString = @"Data Source=Habit-Tracker.db";
       using (var connection = new SqliteConnection(connectionString))
       {
                connection.Open();
                var tableCmd = connection.CreateCommand();
            
            //@ sign allows the use of multi line sql statements
            //belows are the columns that are gonna exist within the tableset

                tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS new_habit (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Date TEXT,
                    Quantity INTEGER
                    )";

                tableCmd.ExecuteNonQuery();
                connection.Close();
       }
        




        Console.WriteLine("Welcome, what would you like to do?");
        Console.WriteLine("Enter 0 to close application.");
        Console.WriteLine("Enter 1 to View All Records");
        Console.WriteLine("Enter 2 to View a Record");
        Console.WriteLine("Enter 3 to Insert Record");
        Console.WriteLine("Enter 4 to Delete Record");
        Console.WriteLine("Enter 5 to Update Record");
        Console.WriteLine("---------------------------------------------------");

    }
}
