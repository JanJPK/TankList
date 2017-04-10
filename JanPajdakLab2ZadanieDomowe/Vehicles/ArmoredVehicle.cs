using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanPajdakLab2ZadanieDomowe
{
     [Serializable] public class ArmoredVehicle
    {
        // Location of its image.
        public string ImagePath { get; set; }

        // Description of the vehicle.
        public string Description { get; set; }

        // Weight in [t].
        public float Weight { get; set; }

        // Tracked or wheeled?
        public string DriveType { get; set; }

        // Its name, for instance T-72M1.
        public string Designation { get; set; }

        public int Horsepower { get; set; }

        // Diesel, gasoline, gas turbine (multi-fuel turbine engine used in ex. M1A1 Abrams)
        public string EngineType { get; set; }

        public ArmoredVehicle(float weight, string driveType, string designation, int horsepower, string engineType)
        {
            Weight = weight;
            DriveType = driveType;
            Designation = designation;
            Horsepower = horsepower;
            EngineType = engineType;
        }

         public ArmoredVehicle()
         {
             
         }

         public string ArmoredVehicleInformation()
         {
             return "Nazwa: " + Designation + "\r\nWaga [t]: " + Weight.ToString() + "\r\nMoc silnika [km]: " + Horsepower.ToString() +
                    "\r\nTyp silnika: " + EngineType + "\r\nNapęd: " + DriveType;
         }

    }
}
