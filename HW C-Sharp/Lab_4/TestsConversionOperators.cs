using System;
using System.Collections.Generic;
using ConversionOperators;


namespace ConversionOperators
{
    public class TestsConversionOperators
    {
        public bool TestAll()
        {
            return HorseToCar() && CarToHorse();
        }
        
        private bool HorseToCar()
        {
            var car = new Car();
            car = new Horse("Pony", 5, 200, 1.1, true, 90, "brown");
            if (car.Type != "Passenger" || car.IsStudded != true || car.Colour != "brown")
            {
                return false;
            }
            
            car = new Horse("Boerperd", 5, 200, 1.1, true, 90, "brown");
            if (car.Type != "Boerperd" || car.Weight != 200)
            {
                return false;
            }
            
            car = (Horse)(new Horse("Belgian horse", 5, 200, 1.1, true, 90, "brown"));
            if (car.Type != "Cargo" || car.Height != 1.1)
            {
                return false;
            }

            return true;
        }

        private bool CarToHorse()
        {
            var horse = new Horse();

            horse = new Car("Cargo" , 10, 550, 1.5, true, 90, "blue");
            if (horse.Breed != "Belgian horse" || horse.Age != 10)
            {
                return false;
            }

            horse = new Car("Audi A4", 11, 999, 1.5, false, 90, "blue");
            if (horse.Breed != "Audi A4" || horse.Age != 11 || horse.IsShod)
            {
                return false;
            }
            
            horse = (Horse)(new Car("blablabla", 15, 887, 1.7, false, 42, "orange"));
            if (horse.Breed != "blablabla" || horse.Age != 15 || horse.IsShod)
            {
                return false;
            }
            
            return true;
        }
    }
}
