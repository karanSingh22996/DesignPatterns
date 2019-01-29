//-----------------------------------------------------------------------
// <copyright file="DesignPatterns.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Design pattern class is calling all the 
    /// class to execute their methods separately
    /// </summary>
    public class DesignPatterns
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            char ch;
            ////starting do while iteration
            do
            {
                Console.WriteLine("Enter 1 to execute First singleton program");
                int choice = Convert.ToInt32(Console.ReadLine());
                ////switch case to take to your desired class
                switch (choice)
                {
                    case 1:
                        SingletonEx fromStudent = SingletonEx.GetInstance;
                        fromStudent.Execution();
                        break;
                }

                Console.WriteLine("Do you want to execute more programs(y/n)");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while (ch != 'n');   
        }
    }
}
