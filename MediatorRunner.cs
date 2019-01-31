//-----------------------------------------------------------------------
// <copyright file="MediatorRunner.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// Mediator runner is execution class of mediator design pattern
    /// </summary>
    public class MediatorRunner
    {
        /// <summary>
        /// Runners this instance.
        /// </summary>
        public void Runner()
        {
            ////creating object of chat mediator class using reference of inerface
            IChatMediator chatMediator = new ChatMediator();
            ////creating object of basic user class with abstract class reference
            User manjunath = new BasicUser(chatMediator, "Manjunath");
            ////creating object of Premium user class with abstract class reference
            User karan = new PremiumUser(chatMediator, "Karan");
            ////creating object of basic premium class with abstract class reference
            User parmesh = new PremiumUser(chatMediator, "Parmesh");
            ////calling add user method with the reference of interface
            chatMediator.AddUser(manjunath);
            ////calling add user method with the reference of interface
            chatMediator.AddUser(karan);
            ////calling add user method with the reference of interface
            chatMediator.AddUser(parmesh);
            ////creating object of basic user class with abstract class reference
            User salu = new BasicUser(chatMediator, "Salu");
            ////calling add user method with the reference of interface
            chatMediator.AddUser(salu);
            salu.SendMessage("salu:->Hey i am online");
        }
    }
}
