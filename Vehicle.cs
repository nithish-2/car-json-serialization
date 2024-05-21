using System.Text.Json;
//creating namespace called "Q1_Car_FinalExam"
namespace Q1_Car_FinalExam  
{
    //creating vehicle class as public
    public class Vehicle 
    {
        //declaring required variables as public
        public string? vehicleMake { get; set; }
        public string? vehicleModel { get; set; }
        public string? vehicleYear { get; set; }
        public string? vehicleColor { get; set; }
        public string? vehicleVIN { get; set; }

        //default constructor
        public Vehicle()
        {

        }

        //overloaded constructor
        public Vehicle(string _vehicleMake, string _vehicleModel, string _vehicleYear, string _vehicleColor, string _vehicleVIN)
        {
            this.vehicleMake = _vehicleMake;
            this.vehicleModel = _vehicleModel;
            this.vehicleYear = _vehicleYear;
            this.vehicleColor = _vehicleColor;
            this.vehicleVIN = _vehicleVIN;
        }
    }
}