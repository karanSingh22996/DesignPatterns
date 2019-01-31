//-----------------------------------------------------------------------
// <copyright file="ITarget.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System.Collections.Generic;

    /// <summary>
    /// I target is an interface
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Gets the employee list.
        /// </summary>
        /// <returns>list of type string</returns>
        List<string> GetEmployeeList();
    }
}
