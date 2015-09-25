using System.Data.SqlClient;
using System.Linq;
using EntityFrameworkSprocApp.Data.Models;

namespace EntityFrameworkSprocApp.Data.Commands
{
    /// <summary>
    /// Class used to query the users table using gender as the filter.
    /// </summary>
    public class GetUsersOfGenderQuery
    {
        /// <summary>
        /// The database context (could be fetched from factory or injected)
        /// </summary>
        private readonly AppContext _context;

        /// <summary>
        /// The gender value to use as the filter
        /// </summary>
        private readonly Gender _gender;

        /// <summary>
        /// Filters the users table on gender
        /// </summary>
        /// <param name="context">The db context</param>
        /// <param name="gender">The gender</param>
        public GetUsersOfGenderQuery(AppContext context, Gender gender)
        {
            _context = context;
            _gender = gender;
        }


        /// <summary>
        /// Filters the users table on gender
        /// </summary>
        /// <returns>The users matching the gender</returns>
        public User[] Execute()
        {
            // Create the gender parameter
            var param1 = new SqlParameter
            {
                ParameterName = "gender",
                Value = _gender
            };

            // Execute the stored procedure, using the User class as the return type
            return _context.Database.SqlQuery<User>("exec GetUsersOfGender @gender", param1).ToArray<User>();
        }
    }
}
