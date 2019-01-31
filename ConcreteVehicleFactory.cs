//-----------------------------------------------------------------------
// <copyright file="ConcreteVehicleFactory.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Concrete vehicle factory is extending vehicle factory class and
    /// implementing all the unimplemented methods
    /// </summary>
    /// <seealso cref="DesignPatterns.VehicleFactory" />
    public class ConcreteVehicleFactory : VehicleFactory
    {
        /// <summary>
        /// Gets the vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle of string type.</param>
        /// <returns>factory of interface type</returns>
        /// <exception cref="ApplicationException">throw the type can not be created</exception>
        public override IFactory GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", vehicle));
            }
        }

        /// <summary>
        /// Runners this instance.
        /// </summary>
        public void Runner()
        {
            ////creating object of concrete using the reference of an interface
            VehicleFactory factory = new ConcreteVehicleFactory();
            ////calling method using the reference of an interface
            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);
            ////calling method using reference of an interface
            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);
        }
    }
}
