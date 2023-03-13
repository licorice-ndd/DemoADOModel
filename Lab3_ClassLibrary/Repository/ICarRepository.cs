using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3_ClassLibrary.DataAccess;

namespace Lab3_ClassLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int carId);
        void InsertCar(Car car);
        void DeleteCar(int carId);
        void UpdateCar(Car car);
    }
}

/*dotnet ef dbcontext scaffold 
"Server=(local);uid=sa;pwd=123456;database=MyStock"
Microsoft.EntityFrameworkCore.SqlServer --output-dir DataAccess
dotnet ef dbcontext scaffold 
"Server=(local);uid=sa;pwd=123456;database=MyStock" 
Microsoft.EntityFrameworkCore.SqlServer --output-dir DataAccess*/