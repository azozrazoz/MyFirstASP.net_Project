using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> GetAllCars { get; }
        IEnumerable<Car> GetFavCars { get; }
        Car GetCarById(int carId);
    }
}
