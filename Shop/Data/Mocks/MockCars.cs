using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> GetAllCars 
        {
            get
            {
                return new List<Car>
                {
                    new Car{
                        name = "Tesla Model X",
                        shortDesc = "Электромобиль кроссовер.",
                        longDesc = "Тесла Модель Х - это полноразмерный кроссовер с тремя рядами сидений. " +
                        "Его габаритные размеры составляют: длина 5004 мм, ширина 2083 мм, высота 1626 мм, а колесная база- 3061 мм. " +
                        "Что касается дорожного просвета, то он напрямую зависит от положения пневматической подвески.",
                        img = "/img/tesla-x.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.GetAllCategories.First()
                    },
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Электромобиль седан",
                        longDesc = "Знакомьтесь - Tesla Model S. " +
                        "Менять мир к лучшему этот полноразмерный пятидверный лифтбек класса люкс начал с 2012 года. " +
                        "Идейным отцом проекта является американский инженер и предприниматель Илон Маск, " +
                        "который еще в 2009 году представил прототип Model S всему миру на Франкфуртском автосалоне.",
                        img = "/img/tesla-s.jpg",
                        price = 143000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.GetAllCategories.First()
                    },
                    new Car
                    {
                        name = "Tesla Model Y",
                        shortDesc = "Электрический кроссовер",
                        longDesc = "Tesla Model Y - электрический кроссовер производства компании Tesla. " +
                        "Модель была представлена в марте 2019 года, серийное производство начато на фабрике во Фримонте в январе 2020, " +
                        "а поставки потребителям с 13 марта 2020. Машина представлена как кроссовер среднего класса, " +
                        "аналогичная таким машинам как VW Touareg, Nissan Murano, " +
                        "Lexus RX и её электрическому конкуренту под названием Audi E-tron.",
                        img = "/img/tesla-y.jpg",
                        price = 35000,
                        isFavourite = true,
                        available = true,
                        category = _categoryCars.GetAllCategories.First()
                    },
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetCarById(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
