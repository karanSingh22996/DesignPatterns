//-----------------------------------------------------------------------
// <copyright file="User.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// declaring an abstract class
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// The chat mediator
        /// </summary>
        private IChatMediator chatMediator;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="chatMediator">The chat mediator.</param>
        /// <param name="name">The name.</param>
        public User(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// Gets the chat mediator.
        /// </summary>
        /// <value>
        /// The chat mediator.
        /// </value>
        public IChatMediator ChatMediator
        {
            get
            {
                return this.chatMediator;
            }
        }
        
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public abstract void SendMessage(string message);

        /// <summary>
        /// Receives the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public abstract void ReceiveMessage(string message);
    }
}