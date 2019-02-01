//-----------------------------------------------------------------------
// <copyright file="Veggies.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Veggies is an abstract class
    /// </summary>
    public abstract class Veggies
    {
        /// <summary>
        /// The price per kg
        /// </summary>
        private double pricePerKg;

        /// <summary>
        /// The restaurants
        /// </summary>
        private List<IRestaurant> restaurants = new List<IRestaurant>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Veggies"/> class.
        /// </summary>
        /// <param name="pricePerKg">The price per kg.</param>
        public Veggies(double pricePerKg)
        {
            this.pricePerKg = pricePerKg;
        }

        /// <summary>
        /// Attaches the specified restaurant.
        /// </summary>
        /// <param name="restaurant">The restaurant.</param>
        public void Attach(IRestaurant restaurant)
        {
            this.restaurants.Add(restaurant);
        }

        /// <summary>
        /// Detaches the specified restaurant.
        /// </summary>
        /// <param name="restaurant">The restaurant.</param>
        public void Detach(IRestaurant restaurant)
        {
            this.restaurants.Remove(restaurant);
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            foreach (IRestaurant restaurant in this.restaurants)
            {
                restaurant.Update(this);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Gets or sets the price per kg.
        /// </summary>
        /// <value>
        /// The price per kg.
        /// </value>
        public double PricePerKg
        {
            get
            {
                return this.pricePerKg;
            }

            set
            {
                if (this.pricePerKg != value)
                {
                    this.pricePerKg = value;
                    this.Notify();
                }
            }
        }
    }
}
