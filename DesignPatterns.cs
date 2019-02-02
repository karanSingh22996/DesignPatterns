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
            try
            {
                char ch = '\x0000';
                int choice = 0;
                ////starting do while iteration
                do
                {
                    Console.WriteLine("Enter 1 to execute First singleton program");
                    Console.WriteLine("Enter 2 to execute Factory design Progrm");
                    Console.WriteLine("Enter 3 to execute Adapter design Pattern Program");
                    Console.WriteLine("Enter 4 to execute shoping portal client done with Adapter design Pattern");
                    Console.WriteLine("Enter 5 to execute Car creation which is done using Facade design Pattern");
                    Console.WriteLine("Enter 6 to exceute shape of polygon class done using Proxy design Patterns");
                    Console.WriteLine("Enter 7 to execute Subscribe/Unsubscribe product from shooping site using Observer Design Pattern");
                    Console.WriteLine("Enter 8 to Execute store/visitor program using Visitor Design Pattern");
                    Console.WriteLine("Enter 9 to execute chatRoom program using Mediator design Patterns");
                    Console.WriteLine("Enter 10 to execute restaurant/veg market using Observer Design Pattern");
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Only number is accepted " + e.Message);
                    }
                    ////switch case to take to your desired class
                    switch (choice)
                    {
                        case 1:
                            SingletonEx fromStudent = SingletonEx.GetInstance;
                            fromStudent.Execution();
                            break;
                        case 2:
                            ConcreteVehicleFactory concreteVehicleFactory = new ConcreteVehicleFactory();
                            concreteVehicleFactory.Runner();
                            break;
                        case 3:
                            EmployeeAdapter employeeAdapter = new EmployeeAdapter();
                            employeeAdapter.BillingRunner();
                            break;
                        case 4:
                            VendorAdapter vendorAdapter = new VendorAdapter();
                            vendorAdapter.SellingItems();
                            break;
                        case 5:
                            CarFacade carFacade = new CarFacade();
                            carFacade.CreateCompleteCar();
                            break;
                        case 6:
                            ProxyPolygon proxyPolygon = new ProxyPolygon();
                            proxyPolygon.ProxyRunner();
                            break;
                        case 7:
                            Product.RunnerObserver();
                            break;
                        case 8:
                            VisitorRunner visitorRunner = new VisitorRunner();
                            visitorRunner.Runner();
                            break;
                        case 9:
                            MediatorRunner mediatorRunner = new MediatorRunner();
                            mediatorRunner.Runner();
                            break;
                        case 10:
                            VeggiesRunner veggiesRunner = new VeggiesRunner();
                            veggiesRunner.Runner();
                            break;
                        default:
                            Console.WriteLine("Enter number in range only");
                            break;
                    }

                    Console.WriteLine("Do you want to execute more programs(y/n)");
                    try
                    {
                        ch = Convert.ToChar(Console.ReadLine());
                    }
                    catch (SystemException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                while (ch != 'n');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
