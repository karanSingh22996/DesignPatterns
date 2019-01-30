//-----------------------------------------------------------------------
// <copyright file="Scooter.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Scooter run " + miles.ToString() + "kmph");
        }
    }
}
