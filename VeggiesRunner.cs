//-----------------------------------------------------------------------
// <copyright file="VeggiesRunner.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// Veggie runner is class to execute the objects 
    /// </summary>
    public class VeggiesRunner
    {
        /// <summary>
        /// Runners this instance.
        /// </summary>
        public void Runner()
        {
            ////carrot object is created and threshold value is set
            Carrots carrots = new Carrots(10.0);
            ////Attach is called with reference to carrot class and new object of restaurant is attached
            carrots.Attach(new Restaurant("Parmesh", 8.0));
            ////Attach is called with reference to carrot class and new object of restaurant is attached
            carrots.Attach(new Restaurant("Manju", 7.5));
            ////Attach is called with reference to carrot class and new object of restaurant is attached
            carrots.Attach(new Restaurant("Manoj", 7.9));
            ////fluctutating pattern is set so that restaurant come in action if price 
            ////is less than their threshold only then restaurant will notify that i want to buy
            carrots.PricePerKg = 6.0;
            carrots.PricePerKg = 11.0;
        }
    }
}
