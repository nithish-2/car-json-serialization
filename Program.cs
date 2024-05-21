/* 
FINAL W23 PROG8145
QUESTION 1
===================
NAME: Nithish Jagadeesan
STUDENT ID: 8875048
EMAIL: nithish.jagadeesan@gmail.com
DATE: 20-04-2023
*/

//creating namespace called "Q1_Car_FinalExam"
namespace Q1_Car_FinalExam
{
    //creating a class called Program
    class Program
    {
        //instantiating an object called car from Car class
        static Car car = new Car();

        //declaring required variables as static
        static bool menuOption = true;

        //main function
        static void Main(string[] args)
        {
            Console.Clear();
            //creating menu section
            while (menuOption)
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("1. Add Car");
                Console.WriteLine("2. View Car");
                Console.WriteLine("3. Save Car");
                Console.WriteLine("4. Load Car");
                Console.WriteLine("5. Exit");
                Console.WriteLine("***************************************");
                string? optionNumber = Console.ReadLine();

                //calls addCar() function when 1 is choosed
                if (optionNumber == "1")
                {
                    addCar();
                }

                //calls viewCar() function when 2 is choosed
                else if (optionNumber == "2")
                {
                    viewCar();
                }

                //calls saveCar() function when 3 is choosed
                else if (optionNumber == "3")
                {
                    saveCar();
                }

                //calls loadCar() function when 4 is choosed
                else if (optionNumber == "4")
                {
                    loadCar();
                }

                //exits when 5 is choosed
                else if (optionNumber == "5")
                {
                    Console.Clear();
                    Console.WriteLine("********************************");
                    Console.WriteLine("Thank You!");
                    Console.WriteLine("********************************");
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("Please enter a valid input !");
                    Console.WriteLine("********************************");
                    menuOption = true;
                }
            }
        }

        //addCar function which gets car details from the user
        public static void addCar()
        {
            bool addCar = true;
            while (addCar)
            {
                //gets vehicle make input and validates it
                bool inputVehicleMake = true;
                while (inputVehicleMake)
                {
                    Console.WriteLine("Enter the vehicle make name:");
                    car.vehicleMake = Console.ReadLine();
                    if (!string.IsNullOrEmpty(car.vehicleMake))
                    {
                        Console.WriteLine("Please enter a valid vehicle make name!");
                        inputVehicleMake = true;
                    }
                    else
                    {
                        inputVehicleMake = false;
                    }
                }

                //gets vehicle model input and validates it
                bool inputVehicleModel = true;
                while (inputVehicleModel)
                {
                    Console.WriteLine("Enter the vehicle model name:");
                    car.vehicleModel = Console.ReadLine();
                    if (!string.IsNullOrEmpty(car.vehicleModel))
                    {
                        Console.WriteLine("Please enter a valid vehicle model name!");
                        inputVehicleModel = true;
                    }
                    else
                    {
                        inputVehicleModel = false;
                    }
                }

                //gets vehicle year input and validates it
                bool inputVehicleYear = true;
                while (inputVehicleYear)
                {
                    Console.WriteLine("Enter the vehicle year:");
                    car.vehicleYear = Console.ReadLine();
                    if (!!string.IsNullOrEmpty(car.vehicleYear))
                    {
                        Console.WriteLine("Please enter a valid vehicle year!");
                        inputVehicleYear = true;
                    }
                    else
                    {
                        inputVehicleYear = false;
                    }
                }

                //gets vehicle color input and validates it
                bool inputVehicleColor = true;
                while (inputVehicleColor)
                {
                    Console.WriteLine("Enter the vehicle color:");
                    car.vehicleColor = Console.ReadLine();
                    if (!string.IsNullOrEmpty(car.vehicleColor))
                    {
                        Console.WriteLine("Please enter a valid vehicle color!");
                        inputVehicleColor = true;
                    }
                    else
                    {
                        inputVehicleColor = false;
                    }
                }

                //gets vehicle VIN input and validates it
                bool inputVehicleVIN = true;
                while (inputVehicleVIN)
                {
                    Console.WriteLine("Enter the vehicle VIN:");
                    car.vehicleVIN = Console.ReadLine();
                    if (!string.IsNullOrEmpty(car.vehicleVIN))
                    {
                        Console.WriteLine("Please enter a valid vehicle VIN!");
                        inputVehicleVIN = true;
                    }
                    else
                    {
                        inputVehicleVIN = false;
                    }
                }

                //gets no of doors input and validates it
                bool inputNoOfDoors = true;
                while (inputNoOfDoors)
                {
                    Console.WriteLine("Enter the number of doors:");
                    car.noOfDoors = Console.ReadLine();
                    if (!string.IsNullOrEmpty(car.noOfDoors))
                    {
                        Console.WriteLine("Please enter a valid number of doors!");
                        inputNoOfDoors = true;
                    }
                    else
                    {
                        inputNoOfDoors = false;
                    }
                }

                //gets no of seats input and validates it
                bool inputNoOfSeats = true;
                while (inputNoOfSeats)
                {
                    Console.WriteLine("Enter the number of seats:");
                    car.noOfSeats = Console.ReadLine();
                    if (!string.IsNullOrEmpty(car.noOfSeats))
                    {
                        Console.WriteLine("Please enter a valid number of seats!");
                        inputNoOfSeats = true;
                    }
                    else
                    {
                        inputNoOfSeats = false;
                    }
                }

                //gets fuel type input and validates it
                bool inputFuelType = true;
                while (inputFuelType)
                {
                    Console.WriteLine("Enter the fuel type:");
                    car.fuelType = Console.ReadLine();
                    if (!string.IsNullOrEmpty(car.fuelType))
                    {
                        Console.WriteLine("Please enter a valid fuel type!");
                        inputFuelType = true;
                    }
                    else
                    {
                        inputFuelType = false;
                    }
                }
                addCar = false;
                menuOption = true;
            }
        }

        //viewCar function which displays car details to the user
        public static void viewCar()
        {
            try
            {
                Console.WriteLine(car.ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unfortunately, error occured while viewing car details: {exception.Message}");
            }
        }

        //saveCar function which saves car details JSON to car.json file
        public static void saveCar()
        {
            string? json = Car.SerializeJSONObject(car);
            try
            {
                File.WriteAllText("car.json", json);
                Console.WriteLine("List saved to car.json");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unfortunately, error occured while saving car details: {exception.Message}");
            }
        }

        //loadCar function which loads car details from car.json file to car object
        public static void loadCar()
        {
            if (File.Exists("car.json"))
            {
                try
                {
                    string json = File.ReadAllText("car.json");
                    car = Car.DeserializeJSONObject(json);
                    if (car != null)
                    {
                        Console.WriteLine("List loaded from people.json");
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Unfortunately, error occured while loading car details: {exception.Message}");
                }
            }
            else
            {
                Console.WriteLine("No file found.");
            }
        }
    }
}
