//using .NET framework for which provides functionality for working with JSON
using System.Text.Json;

//creating namespace called "Q1_Car_FinalExam"
namespace Q1_Car_FinalExam
{
    //creating a public class called Car which inherits from Vehicle class
    public class Car : Vehicle
    {
        //declaring required variables as public
        public string? noOfDoors { get; set; }
        public string? noOfSeats { get; set; }
        public string? fuelType { get; set; }

        //default contructor
        public Car()
        {

        }

        //overloaded constructor
        public Car(string _noOfDoors, string _noOfSeats, string _fuelType)
        {
            this.noOfDoors = _noOfDoors;
            this.noOfSeats = _noOfSeats;
            this.fuelType = _fuelType;
        }

        //ToString function which displays car details
        public override string ToString()
        {
            if (string.IsNullOrEmpty(vehicleMake))
            {
                return "No data available";
            }
            else
            {
                return $"{vehicleMake},{vehicleModel},{vehicleYear},{vehicleColor},{vehicleVIN},{noOfDoors},{noOfSeats},{fuelType}";
            }
        }

        //SerializeJSONObject function serializes JSON objects
        public static string? SerializeJSONObject(Car car)
        {
            try
            {
                return JsonSerializer.Serialize(car);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unfortunately, error occured while serializing JSON objects: {exception.Message}");
                return null;
            }
        }

        //DeserializeJSONObject function deserializes JSON objects
        public static Car? DeserializeJSONObject(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<Car>(json);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unfortunately, error occured while deserializing JSON objects: {exception.Message}");
                return null;
            }
        }
    }
}