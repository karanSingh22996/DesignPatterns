//-----------------------------------------------------------------------
// <copyright file="Restaurant.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Restaurant is an implementation class of an interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IRestaurant" />
    public class Restaurant : IRestaurant
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The veggie
        /// </summary>
        ////private Veggies veggie;

        /// <summary>
        /// The purchase threshold
        /// </summary>
        private double purchaseThreshold;

        /// <summary>
        /// Initializes a new instance of the <see cref="Restaurant"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="purchaseThreshold">The purchase threshold.</param>
        public Restaurant(string name, double purchaseThreshold)
        {
            this.name = name;
            this.purchaseThreshold = purchaseThreshold;
        }

        /// <summary>
        /// Updates the specified veggie.
        /// </summary>
        /// <param name="veggie">The veggie.</param>
        public void Update(Veggies veggie)
        {
            Console.WriteLine("Notified {0} of {1}'s price chnage to {2:c} perKg ", this.name, veggie.GetType().Name, veggie.PricePerKg);
            if (veggie.PricePerKg < this.purchaseThreshold)
            {
                Console.WriteLine(this.name + " wants to buy some " + veggie.GetType().Name + " !");
            }
        }
    }
}
