using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI.Models
{
    public class Car
    {
        public int CarNumber { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }

        public Car() { }
        public Car(int carno,string model,string brand,float price)
        {
            CarNumber = carno;
            Model = model;
            Brand = brand;
            Price = price;
        }
        List<Car> cars = new List<Car>();
        public List<Car> getCars()
        {
            cars.Add(new Car(1973, "Amaze", "Honda", 3943434));
            cars.Add(new Car(1756, "Getz", "Honda", 754543));
            cars.Add(new Car(1783, "Ertiga", "Maruti", 5675675));
            cars.Add(new Car(8973, "Vento", "Vols", 6787688));
            return cars;
        }
        public void AddCar(Car c)
        {
            cars.Add(c);
        }
        public void DeleteCar(int id)
        {
            Car c = (from i in getCars()
                     where i.CarNumber == id
                     select i).FirstOrDefault();
            cars.Remove(c);
        }
    }
}
