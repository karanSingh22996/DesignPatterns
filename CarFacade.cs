//-----------------------------------------------------------------------
// <copyright file="CarFacade.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Car facade class
    /// </summary>
    public class CarFacade
    {
        /// <summary>
        /// The accessories
        /// </summary>
        private CarAccessories accessories;

        /// <summary>
        /// The body
        /// </summary>
        private CarBody body;

        /// <summary>
        /// The engine
        /// </summary>
        private CarEngine engine;

        /// <summary>
        /// The model
        /// </summary>
        private CarModel model;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarFacade"/> class.
        /// </summary>
        public CarFacade()
        {
            this.model = new CarModel();
            this.body = new CarBody();
            this.engine = new CarEngine();
            this.accessories = new CarAccessories();
        }

        /// <summary>
        /// Creates the complete car.
        /// </summary>
        public void CreateCompleteCar()
        {
            Console.WriteLine("---------------Creating Car------------");
            this.model.SetModel();
            this.engine.SetEngine();
            this.body.SetBody();
            this.accessories.SetAccessories();
            Console.WriteLine("------------Car Creation Complete---------");
        }
    }
}
