using System;
using EntityFrameworkSprocApp.Data;
using EntityFrameworkSprocApp.Data.Commands;
using EntityFrameworkSprocApp.Data.Models;

namespace EntityFrameworkSprocApp
{
    class Program
    {
        // Program entry point
        static void Main(string[] args)
        {
            using (var db = new AppContext())
            {
                // Create the query
                var query = new GetUsersOfGenderQuery(db, Gender.Female);
                
                // Excecute the query (the sproc)
                var users = query.Execute();
                
                // Output the results to the console
                foreach (var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }
        }
    }
}
