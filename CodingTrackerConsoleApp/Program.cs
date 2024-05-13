//Habit tracker app using SQlite
//should initialize a db on start and store the info as long as the application is running
using Microsoft.Data.Sqlite;
using CodingTrackerConsoleApp.Controller;

class Program
{
    static void Main(string[] args)
    { 
        //intlzes the sqlite conn       
       static string connectionString = @"Data Source=habit-Tracker.db";
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
        
        
 private static void InsertRecord()
    {
            //format the date
            string date = GetDateInput();


    }

    internal string GetDateInput()
    {
        Console.WriteLine("\nPlease enter in the data format as mm-dd-yy\n");
        //exit back to menu case
        string userAns = Console.ReadLine();

        if(userAns == "0")
        GetUserInput();
    }





        

    static void GetUserInput()
    {
    Console.Clear();
    bool closeApp = false;
    while(closeApp == false)
    {
            Console.WriteLine("Welcome, what would you like to do?");
            Console.WriteLine("Enter 0 to close application.");
            Console.WriteLine("Enter 1 to View All Records");
            Console.WriteLine("Enter 2 to View a Record");
            Console.WriteLine("Enter 3 to Insert Record");
            Console.WriteLine("Enter 4 to Delete Record");
            Console.WriteLine("Enter 5 to Update Record");
            Console.WriteLine("---------------------------------------------------");

            long commandInput = Convert.ToInt64(Console.ReadLine());

            switch(commandInput)
            {
                case 0: 
                Console.WriteLine("Operation ended.");
                closeApp = true;
                break;
                case 1:
                GetAllRecords();
                break;
                case 2:
                ViewRecord();
                break;
                case 3:
                InsertRecord();
                break;
                case 4:
                DeleteRecord();
                break;
                case 5:
                UpdateRecord();
                break;
                default:
                Console.WriteLine("Please enter again with a valid integer(1-5)");
                break;





   void InsertRecord()
      {
            //format the date
            string date = GetDateInput();
             using (var connection = new SqliteConnection(connectionString))
             {
                connection.Open();
                var tableCmd = connection.CreateCommand();


             }

             string GetDateInput()
             {
                Console.WriteLine("\nPlease enter in the data format as mm-dd-yy\n");
                string userAns = Console.ReadLine();
                //exit back to menu case
                if(userAns == "0")
                GetUserInput();
                else;
                return userAns;
             }


                
         }
    }

    }


        

    }


//figure out how to implement this within a class/ avoid spaghetti code
    // private static void UpdateRecord()
    // {
    //     throw new NotImplementedException();
    // }

    // private static void DeleteRecord()
    // {
    //     throw new NotImplementedException();
    // }

    private static void InsertRecord()
    {
            //format the date
            string date = GetDateInput();


    }

    internal string GetDateInput()
    {
        Console.WriteLine("\nPlease enter in the data format as mm-dd-yy\n");
        //exit back to menu case
        string userAns = Console.ReadLine();

        if(userAns == "0")
        GetUserInput();
    }

    // private static void ViewRecord()
    // {
    //     throw new NotImplementedException();
    // }

    // private static void GetAllRecords()
    // {
    //     throw new NotImplementedException();
    // }
}
}
