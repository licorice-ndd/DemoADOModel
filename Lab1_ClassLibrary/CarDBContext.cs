using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_ClassLibrary
{
    public class CarDBContext
    {
        // Initialize car list
        private static List<Car> CarList = new List<Car>()
        {
            new Car{ CarID = 1, CarName = "CRV1", Manufacturer="Honda", Price = 10005000, ReleaseYear = 2020 },
            new Car{ CarID = 2, CarName = "CRV2", Manufacturer="Toyota", Price = 20005000, ReleaseYear = 2021 },
            new Car{ CarID = 3, CarName = "CRV3", Manufacturer="Subaru", Price = 30005000, ReleaseYear = 2022 },
            new Car{ CarID = 4, CarName = "CRV4", Manufacturer="Huyndai", Price = 40005000, ReleaseYear = 2023 },
            new Car{ CarID = 5, CarName = "CRV5", Manufacturer="Ford", Price = 50005000, ReleaseYear = 2024 }
        };

        // Using singleton pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null) instance = new CarDBContext();
                }
                return instance;
            }
        }
        public List<Car> GetCarList => CarList;
        public Car GetCarByID(int carID)
        {
            // using linq to object
            Car car = CarList.SingleOrDefault(pro => pro.CarID == carID);
            return car;
        }

        public void AddNew(Car car)
        {
            Car pro = GetCarByID(car.CarID);
            if (pro != null)
            {
                CarList.Add(car);
            }
            else
            {
                throw new Exception("Car is already exits");
            }
        }
        public void Update(Car car)
        {
            Car c = GetCarByID(car.CarID);
            if( c != null)
            {
                var index =CarList.IndexOf(c);
                CarList[index] = car;
            }else throw new Exception("Car doest already exits");
        }
        public void Remove(int CarID)
        {
            Car p = GetCarByID(CarID);
            if (p != null) { CarList.Remove(p); }
            else throw new Exception("Car doest already exits");
        }
    }
}
