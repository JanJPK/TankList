using System;

namespace JanPajdakLab2ZadanieDomowe
{
    [Serializable] public class Tank : ArmoredVehicle
    {
        // Caliber in [mm].
        public int Caliber { get; set; }

        // Is it equipped with countermeasures? 
        public bool Countermeasure { get; set; }

        // MBT (Main Battle Tank), light, medium, heavy.
        public string TankType { get; set; }

        public Tank(float weight, string driveType, string designation, int horsepower, string engineType, int caliber, bool countermeasure, string tankType) : base(weight, driveType, designation, horsepower, engineType)
        {
            Caliber = caliber;
            Countermeasure = countermeasure;
            TankType = tankType;
        }

        public string TankInformation()
        {
            string obrona = "";
            if (Countermeasure)
            {
                obrona = "Tak";
            }
            else
            {
                obrona = "Nie";
            }
            return this.ArmoredVehicleInformation() + "\r\nKaliber: " + Caliber.ToString() + "\r\nSys. obronne: " +
                   obrona + "\r\nTyp czołgu: " + TankType;
        }
    }
}