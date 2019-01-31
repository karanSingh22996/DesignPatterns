//-----------------------------------------------------------------------
// <copyright file="ThirdPartyBillingSystem.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Third party billing system is client class 
    /// </summary>
    public class ThirdPartyBillingSystem
    {
        /// <summary>
        /// The employee source
        /// </summary>
        private ITarget employeeSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyBillingSystem"/> class.
        /// </summary>
        /// <param name="employeeSource">The employee source.</param>
        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        /// <summary>
        /// Shows the employee list.
        /// </summary>
        public void ShowEmployeeList()
        {
            List<string> employee = this.employeeSource.GetEmployeeList();
            ////To DO: Implement you business logic

            Console.WriteLine("######### Employee List ##########");
            foreach (var item in employee)
            {
                Console.Write(item);
            }
        }
    }
}
