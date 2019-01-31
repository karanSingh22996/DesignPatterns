//-----------------------------------------------------------------------
// <copyright file="Product.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Product class is implementation class of an interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IProduct" />
    public class Product : IProduct
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The base price
        /// </summary>
        private float basePrice;

        /// <summary>
        /// The current price
        /// </summary>
        private float currentPrice;

        /// <summary>
        /// The customers
        /// </summary>
        private List<Customer> customers = new List<Customer>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="basePrice">The base price.</param>
        public Product(string name, float basePrice)
        {
            this.name = name;
            this.basePrice = basePrice;
            this.currentPrice = basePrice;
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public float Price
        {
            get
            {
                return this.currentPrice;
            }

            set
            {
                //// if price of the laptop will be less than the base price then 
                //// notification will forwarded to the subscribers
                this.currentPrice = value;
                if (value <= this.basePrice)
                {
                    this.Notify();
                }
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return this.name; }
        }

        /// <summary>
        /// Gets the discount.
        /// </summary>
        /// <value>
        /// The discount.
        /// </value>
        public float Discount
        {
            get { return (this.basePrice - this.currentPrice) * 100 / this.basePrice; }
        }

        /// <summary>
        /// Gets the current price.
        /// </summary>
        /// <value>
        /// The current price.
        /// </value>
        public float CurrentPrice
        {
            get { return this.currentPrice; }
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            foreach (Customer observer in this.customers)
            {
                observer.Update(this);
            }
        }

        /// <summary>
        /// Subscribes the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void Subscribe(Customer customer)
        {
            this.customers.Add(customer);
        }

        /// <summary>
        /// the UnSubscribe
        /// </summary>
        /// <param name="customer">The customer of type customer</param>
        public void UnSubscribe(Customer customer)
        {
            this.customers.Remove(customer);
        }

        /// <summary>
        /// Runners the observer.
        /// </summary>
        public static void RunnerObserver()
        {
            Product laptop = new Product("DELL", 1000);
            Console.WriteLine("--------Customer 1 and Customer 2 is subscribed to the Laptop Product----------");
            //// attach or subscribe customer 1
            Customer customer1 = new Customer("customer 1");
            laptop.Subscribe(customer1);
            //// attach or subscribe customer 2
            Customer customer2 = new Customer("customer 2");
            laptop.Subscribe(customer2);

            //// publish notification to the subscribers
            laptop.Price = 800;

            Console.WriteLine("--------customer 2 is unsubscribed and customer 3 is subscribed to the Laptop Product----------");
            //// customer 2 is unsubscribed and customer 3 is subscribed
            laptop.UnSubscribe(customer2);
            Customer customer3 = new Customer("customer 3");
            laptop.Subscribe(customer3);
            laptop.Price = 900;
        }
    }
}
