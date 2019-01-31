//-----------------------------------------------------------------------
// <copyright file="VisitorRunner.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System.Collections.Generic;

    /// <summary>
    /// Visitor runner class is execution class 
    /// of visitor design pattern
    /// </summary>
    public class VisitorRunner
    {
        /// <summary>
        /// Runners this instance.
        /// </summary>
        public void Runner()
        {
            ////list object craetion 
            List<IStore> store = new List<IStore>();
            ////adding object of the class in list
            store.Add(new Car() { CarName = "A1", Price = 200M, CarType = "Mercedes" });
            ////adding object of the class in list
            store.Add(new Car() { CarName = "A2", Price = 100M, CarType = "Normal" });
            ////adding object of the class in list
            store.Add(new RaceBike() { BikeName = "B1", Price = 50M, BikeType = "Bullet" });
            ////adding object of the class in list
            store.Add(new RaceBike() { BikeName = "B2", Price = 30M, BikeType = "Normal" });
            ////Show price of each item
            PriceVisitor priceVisitor = new PriceVisitor();
            ////iteration will iterate list
            foreach (var element in store)
            {
                element.Visit(priceVisitor);
            }
            ////Show weight of each item
            WeightVisitor weightVisitor = new WeightVisitor();
            foreach (var element in store)
            {
                element.Visit(weightVisitor);
            }          
        }
    }
}
