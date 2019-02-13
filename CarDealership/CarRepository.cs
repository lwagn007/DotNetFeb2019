using System.Collections.Generic;

namespace CarDealership
{
    public class CarRepository
    {
        List<Car> _carList;

        public List<Car> GetCarList()
        {
            _carList = new List<Car>();
            return _carList;
        }

        public void AddCarToList(Car car)
        {
            _carList.Add(car);
        }

        public bool GetBooleanFromString(string boolResponse)
        {
            if (boolResponse.ToLower().Contains("y"))
                return true;
            else
                return false;
        }

        public void RemoveCarFromList(Car car)
        {
            _carList.Remove(car);
        }

        public Brand GetBrandByInt(int brandChoice)
        {
            Brand brand;
            switch (brandChoice)
            {
                case 1:
                    brand = Brand.Toyota;
                    break;
                case 2:
                    brand = Brand.Ford;
                    break;
                case 3:
                    brand = Brand.Chevrolet;
                    break;
                case 4:
                    brand = Brand.Honda;
                    break;
                case 5:
                    brand = Brand.Tesla;
                    break;
                case 6:
                    brand = Brand.Lambourgini;
                    break;
                case 7:
                    brand = Brand.BMW;
                    break;
                default:
                    brand = Brand.Other;
                    break;
            }
            return brand;
        }

        public CarType GetCarTypeByInt(int typeChoice)
        {
            CarType type;
            switch (typeChoice)
            {
                case 1:
                    type = CarType.Truck;
                    break;
                case 2:
                    type = CarType.Van;
                    break;
                case 3:
                    type = CarType.Sedan;
                    break;
                case 4:
                    type = CarType.Hybrid;
                    break;
                default:
                    type = CarType.Other;
                    break;
            }
            return type;
        }
    }
}