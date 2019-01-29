//-----------------------------------------------------------------------
// <copyright file="SingletonEx.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Singleton class is just demo of not creating more than one instance 
    /// sealed is a keyword use to restrict the inheritance inside nested class or outside the class
    /// </summary>
    public sealed class SingletonEx
    {
        /// <summary>
        /// The counter
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// The instance of singleton is set null 
        /// so that we can avoid creation of more tha one instance
        /// </summary>
        private static SingletonEx instance = null;

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance will return the instance 
        /// only if the value of instance is set to null
        /// </value>
        public static SingletonEx GetInstance
        {
            get
            {
                if (instance == null)
                {
                    ////creating instance of the class
                    instance = new SingletonEx();
                }

                return instance;
            }
        }

        /// <summary>
        /// Messages method will be printed as many
        /// times we calling with different instance of the class
        /// </summary>
        /// <param name="message">The message.</param>
        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Executions method is declared to call the methods by reference of the class.
        /// </summary>
        public void Execution()
        {
            ////creating first reference
            SingletonEx fromStudent = SingletonEx.GetInstance;
            fromStudent.Message("From student");
            ////creating second reference
            SingletonEx fromEmpoyee = SingletonEx.GetInstance;
            fromStudent.Message("From employee");          
        }
    }
}
