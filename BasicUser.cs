//-----------------------------------------------------------------------
// <copyright file="BasicUser.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Basic user is derived class of an abstract class user
    /// </summary>
    /// <seealso cref="DesignPatterns.User" />
    public class BasicUser : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicUser"/> class.
        /// </summary>
        /// <param name="chatMediator">The chat mediator.</param>
        /// <param name="name">The name.</param>
        public BasicUser(IChatMediator chatMediator, string name)
        : base(chatMediator, name)
        {
        }

        /// <summary>
        /// Receives the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public override void ReceiveMessage(string message)
        {
            Console.WriteLine("Basic User: " + this.Name + " receive message: " + message);
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public override void SendMessage(string message)
        {
            ChatMediator.SendMessageToAllUsers(message, this);
        }
    }
}
