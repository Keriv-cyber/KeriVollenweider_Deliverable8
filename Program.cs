using System;

namespace KeriVollenweider_Deliverable8
{
    //class Program
    //{
      //  static void Main(string[] args)
        //{
          //  Console.WriteLine("Hello World!");
        //}
    class Automobile
        {
            // Fields
            private string _make;
            private string _model;
            private int _mileage;
            private decimal _price;

            // Constructor 
            public Automobile()
            {
                _make = "";
                _model = "";
                _mileage = 0;
                _price = 0;
            }

            // Make property
            public string Make
            {
                get { return _make; }
                set { _make = value; }
            }

            // Model property
            public string Model
            {
                get { return _model; }
                set { _model = value; }

            }

            //Milage propertry
            public int Mileage
            {
                get { return _mileage; }
                set { _mileage = value; }
            }

            //Price property
            public decimal Price
            {
                get { return _price; }
                set { _price = value; }
            }

        }

        class Car : Automobile
        {
            // Field
            private int _doors;

            // Constructor
            public Car()
            {
                _doors = 0;
            }

            // Doors property
            public int Doors
            {
                get { return _doors; }
                set { _doors = value; }
            }
        }
 }
}
