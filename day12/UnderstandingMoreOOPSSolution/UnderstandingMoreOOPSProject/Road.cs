using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Road
    {
        void AssignAnimal()
        {
            Animal animal = null;
            Console.WriteLine("Enter horse or Donkey");
            string choice = Console.ReadLine().ToUpper();
            switch (choice)
            {
                case "HORSE":
                    animal = new Horse();
                    break;
                case "DONKEY":
                    animal = new Donkey();
                    break;
                default:
                    Console.WriteLine("Invali choice");
                    break;
            }
            PullCart(animal);
        }
        void PullCart(Animal animal)
        {
            animal.Eat();
            animal.Sleep();
            animal.Move();
        }

        static void Main(string[] args)
        {
            new Road().AssignAnimal();
            Console.ReadKey();
        }

    }
}
