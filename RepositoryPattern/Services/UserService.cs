using RepositoryPattern.Core;
using RepositoryPattern.Services.Interface;
using RepositoryPattern.Services.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPattern.Services
{
    public class UsersService : IUsersService
    {
        private readonly IRepository<User> _userRepository;

        public UsersService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <param name="user">User</param>
        public virtual void DeleteUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _userRepository.Delete(user);
        }

        /// <summary>
        /// Get a user by identifier
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <returns>User</returns>
        public virtual async Task<User> GetUser(int userId)
        {
            if (userId <= 0)
                return null;

            var user = await _userRepository.GetById(userId);
            return user;
        }

        /// <summary>
        /// Get users
        /// </summary>
        /// <returns>Users</returns>
        public async Task<IEnumerable<User>> GetAll()
        {
            var user = await _userRepository.GetAll();
            return user;
        }

        ///// <summary>
        ///// Get a user by email
        ///// </summary>
        ///// <param name="email">Email</param>
        ///// <returns>User</returns>
        //public virtual User GetUserByEmail(string email)
        //{
        //    if (string.IsNullOrEmpty(email))
        //        return null;

        //    return _userRepository.Query(x => x.Email == email).FirstOrDefault();
        //}

        /// <summary>
        /// Get users by identifiers
        /// </summary>
        /// <param name="userIds">User identifiers</param>
        /// <returns>Users</returns>
        public virtual IList<User> GetUsersByIds(int[] userIds)
        {
            return _userRepository.GetByIds(userIds);
        }

        /// <summary>
        /// Insert a user
        /// </summary>
        /// <param name="user">User</param>
        public virtual async Task InsertUser(User user)
        {
            await _userRepository.Insert(user);
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="user">User</param>
        public virtual void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }

        /// <summary>
        /// Save user
        /// </summary>
        /// <returns>Count(retun 0 if succsess)</returns>
        public async Task<int> SaveAsync()
        {
            return await _userRepository.Save();
        }
    }
}
