using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent app) { appDBContent = app; }

        public IEnumerable<Car> GetAllCars => appDBContent.Cars.Include(x => x.category);

        public IEnumerable<Car> GetFavCars => appDBContent.Cars.Where(x => x.isFavourite == true);

        public Car GetCarById(int carId) => appDBContent.Cars.FirstOrDefault(x => x.id == carId);
    }
}
