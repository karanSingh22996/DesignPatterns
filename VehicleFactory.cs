//-----------------------------------------------------------------------
// <copyright file="VehicleFactory.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// vehicle factory is an abstract class
    /// </summary>
    public abstract class VehicleFactory
    {
        /// <summary>
        ///  Gets the vehicle method.
        /// </summary>
        /// <param name="vehicle">The vehicle of string.</param>
        /// <returns>interface type</returns>
        public abstract IFactory GetVehicle(string vehicle);
    }
}
