//-----------------------------------------------------------------------
// <copyright file="IChatMediator.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// Declaring an interface
    /// </summary>
    public interface IChatMediator
    {
        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user of type user.</param>
        void AddUser(User user);

        /// <summary>
        /// Sends the message to all users.
        /// </summary>
        /// <param name="message">The message of string.</param>
        /// <param name="currentUsr">The current user of type user.</param>
        void SendMessageToAllUsers(string message, User currentUsr);
    }
}
