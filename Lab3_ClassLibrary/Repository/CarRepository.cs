using Lab3_ClassLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ClassLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarByID(int carId) => CarDAO.Instance.GetCarByID(carId);
        public IEnumerable<Car> GetCars() => CarDAO.Instance.GetCarList();
        public void InsertCar(Car car) => CarDAO.Instance.AddNew(car);
        public void DeleteCar(int carId) => CarDAO.Instance.Remove(carId);
        public void UpdateCar(Car car) => CarDAO.Instance.Update(car);

    }
}
