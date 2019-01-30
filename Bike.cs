//-----------------------------------------------------------------------
// <copyright file="Bike.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Bike class is implementation class of factory interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IFactory" />
    public class Bike : IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles  of type integer.</param>
        public void Drive(int miles)
        {
            Console.WriteLine("Bike runs with " + miles.ToString() + " kmph");
        }
    }
}
