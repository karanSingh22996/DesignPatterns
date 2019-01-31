//-----------------------------------------------------------------------
// <copyright file="Scooter.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Scooter is an implementation class of an interface factory
    /// </summary>
    /// <seealso cref="DesignPatterns.IFactory" />
    public class Scooter : IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles of type integer.</param>
        public void Drive(int miles)
        {
            Console.WriteLine("Scooter run " + miles.ToString() + "kmph");
        }
    }
}
