
namespace DesignPatterns
{
    using System;
    public class CarFacade
    {
        CarAccessories accessories;
        CarBody body;
        CarEngine engine;
        CarModel model;
        public CarFacade()
        {
            model = new CarModel();
            body = new CarBody();
            engine = new CarEngine();
            accessories = new CarAccessories();
        }
        public void CreateCompleteCar()
        {
            Console.WriteLine("---------------Creating Car------------");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();
            Console.WriteLine("------------Car Creation Complete---------");
        }
    }
}
