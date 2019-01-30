//-----------------------------------------------------------------------
// <copyright file="VehicleFactory.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string vehicle);
    }
}
