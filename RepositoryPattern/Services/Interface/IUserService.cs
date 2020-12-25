using RepositoryPattern.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPattern.Services.Interface
{
    public interface IUsersService
    {
        /// <summary>
        /// Get a user
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <returns>A user</returns>
        Task<User> GetUser(int userId);

        /// <summary>
        /// Get users
        /// </summary>
        /// <returns>Users</returns>
        Task<IEnumerable<User>> GetAll();

        /// <summary>
        /// Get a customer by email
        /// </summary>
        /// <param name="email">User email</param>
        /// <returns>A User</returns>
        User GetUserByEmail(string email);


        /// <summary>
        /// Get a users by identifiers
        /// </summary>
        /// <param name="userIds">User identifiers</param>
        /// <returns>Users</returns>
        IList<User> GetUsersByIds(int[] userIds);

        /// <summary>
        /// Insert a User
        /// </summary>
        /// <param name="user">User</param>
        Task InsertUser(User user);


        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="user">User</param>
        void UpdateUser(User user);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <param name="user">User</param>
        void DeleteUser(User user);

        /// <summary>
        /// Save user
        /// </summary>
        /// <returns>Count(retun 0 if succsess)</returns>
        Task<int> SaveAsync();

    }
}
