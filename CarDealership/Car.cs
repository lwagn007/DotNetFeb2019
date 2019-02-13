namespace CarDealership
{
    public enum CarType { Truck, Van, Sedan, Hybrid, Other }
    public enum Brand { Toyota, Ford, Chevrolet, Honda, Tesla, Lambourgini, BMW, Other }
    public class Car
    {
        public Brand BrandOfCar { get; set; }
        public CarType TypeOfCar { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public int NumOfDoors { get; set; }
        public int SafteyRating { get; set; }
        public bool IsFWD { get; set; }
        public bool HadAccident { get; set; }
        public bool HasHeatedSeats { get; set; }

        public Car()
        {

        }

        public Car(Brand brand, CarType type, int year, int mileage, string color, int doors, int safetyRating, bool isFWD, bool hadAccident, bool hasHeatSeats)
        {
            BrandOfCar = brand;
            TypeOfCar = type;
            Year = year;
            Mileage = mileage;
            Color = color;
            NumOfDoors = doors;
            SafteyRating = safetyRating;
            IsFWD = isFWD;
            HadAccident = hadAccident;
            HasHeatedSeats = hasHeatSeats;
        }
    }
}