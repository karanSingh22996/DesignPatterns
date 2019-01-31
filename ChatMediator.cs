//-----------------------------------------------------------------------
// <copyright file="ChatMediator.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System.Collections.Generic;

    /// <summary>
    /// Chat mediator is a class which is implementing an interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IChatMediator" />
    public class ChatMediator : IChatMediator
    {
        /// <summary>
        /// The users
        /// </summary>
        private List<User> users;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMediator"/> class.
        /// </summary>
        public ChatMediator()
        {
            ////initializing the object of list in constructor
            this.users = new List<User>();
        }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user of type user.</param>
        public void AddUser(User user)
        {
            ////adding user to the list
            this.users.Add(user);
        }

        /// <summary>
        /// Sends the message to all users.
        /// </summary>
        /// <param name="message">The message of string.</param>
        /// <param name="currentUsr">The current user of type user.</param>
        public void SendMessageToAllUsers(string message, User currentUsr)
        {
            ////iterating for each loop for list
            this.users.ForEach(w =>
            {
                if (w != currentUsr)    ////don't send message to sender
                {
                    w.ReceiveMessage(message);
                }
            });
        }
    }
}
