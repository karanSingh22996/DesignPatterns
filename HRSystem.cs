//-----------------------------------------------------------------------
// <copyright file="HRSystem.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// HR system class 
    /// </summary>
    public class HRSystem
    {
        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns>array of array string</returns>
        public string[][] GetEmployees()
        {
            ////creating and declaring array of string
            string[][] employees = new string[4][];
            employees[0] = new string[] { "100", "Deepak", "Team Leader" };
            employees[1] = new string[] { "101", "Rohit", "Developer" };
            employees[2] = new string[] { "102", "Gautam", "Developer" };
            employees[3] = new string[] { "103", "Dev", "Tester" };
            return employees;
        }
    }
}
