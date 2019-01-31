//-----------------------------------------------------------------------
// <copyright file="EmployeeAdapter.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Employee adapter class is derived and implementation class
    /// </summary>
    /// <seealso cref="DesignPatterns.HRSystem" />
    /// <seealso cref="DesignPatterns.ITarget" />
    public class EmployeeAdapter : HRSystem, ITarget
    {
        /// <summary>
        /// Gets the employee list.
        /// </summary>
        /// <returns>list of string</returns>
        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            string[][] employees = GetEmployees();
            foreach (string[] employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add(",");
                employeeList.Add(employee[1]);
                employeeList.Add(",");
                employeeList.Add(employee[2]);
                employeeList.Add("\n");
            }

            return employeeList;
        }

        /// <summary>
        /// Billings the runner.
        /// </summary>
        public void BillingRunner()
        {
            ITarget itarget = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(itarget);
            client.ShowEmployeeList();
            Console.ReadKey();
        }
    }
}
